using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Apache.Ignite.Core;
using Apache.Ignite.Core.Cache;
using Apache.Ignite.Core.Cache.Configuration;

namespace IgniteEFCacheStore
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            InitializeDb();

            using (var ignite = Ignition.StartFromApplicationConfiguration())
            {
                var blogs = ignite.GetOrCreateCache<int, student>(new CacheConfiguration
                {
                    Name = "blogs",
                    CacheStoreFactory = new BlogCacheStoreFactory(),
                    ReadThrough = true,
                    WriteThrough = true,
                    KeepBinaryInStore = false   // Store works with concrete classes.
                });

                //var posts = ignite.GetOrCreateCache<int, Post>(new CacheConfiguration
                //{
                //    Name = "posts",
                //    CacheStoreFactory = new PostCacheStoreFactory(),
                //    ReadThrough = true,
                //    WriteThrough = true,
                //    KeepBinaryInStore = false   // Store works with concrete classes.
                //});

                Console.WriteLine("\n>>> Example started\n\n");

                // Load all posts, but do not load blogs.
                Console.WriteLine("Calling ICache.LoadCache...");
                blogs.LoadCache(null);

                // Show all posts with their blogs.
                DisplayData( blogs);

                // Add new data to cache.
                Console.WriteLine("Adding new post to existing blog..");

                var postId = blogs.Max(x => x.Key) + 1;  // Generate new id.

                //posts[1] = new Post
                //{
                //    BlogId = blogs.Min(x => x.Key), // Existing blog
                //    PostId = postId,
                //    Title = "New Post From Ignite"
                //};

                // Show all posts with their blogs.
              //  DisplayData( blogs);

                // Remove newly added post.
                Console.WriteLine("Removing post with id {0}...", postId);
                blogs.Remove(postId);

                Console.WriteLine("\n>>> Example finished.\n");
            }
        }

        private static void DisplayData(ICache<int, student> blogs)
        {
            Console.WriteLine("\n>>> List of all posts:");

            foreach (var post in blogs) // Cache iterator does not go to store.
            {
                Console.WriteLine("Retrieving blog with id {0}...", post.Value.id);
                var blog = blogs[post.Value.id]; // Retrieving by key goes to store.

                Console.WriteLine(">>> Post '{0}' in blog '{1}'", post.Value.city, blog.name);

            }

            Console.WriteLine(">>> End list.\n");
        }

        private static void InitializeDb()
        {
            using (var ctx = new demoEntities())
            {
                // ReSharper disable once AssignNullToNotNullAttribute
               // var dataSource = Path.GetFullPath(ctx.Database.Connection.DataSource);

            }
        }
    }
}
