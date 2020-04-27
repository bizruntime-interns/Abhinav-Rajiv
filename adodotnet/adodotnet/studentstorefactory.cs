using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Apache.Ignite.Core;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Store;
using Apache.Ignite.Core.Common;
using Apache.Ignite.Core.Resource;

namespace adodotnet
{
    public class studentstore : ICacheStore<int, IBinaryObject>
    {
        [InstanceResource]
        private IIgnite ignite { get; set; }
        
        public const string db= "data source =.; database = demo; integrated security = SSPI";
        public void Delete(int key)
        {
          
        }

        public void DeleteAll(IEnumerable<int> keys)
        {
          foreach(var key in keys)
            {
                Delete(key);
            }
        }

        public IBinaryObject Load(int key)
        {
            Console.WriteLine("Load called");
            using (SqlConnection con = new SqlConnection(db))
            {
                SqlCommand cmd = new SqlCommand("select name,salary from student where id = @0", con);
                
                cmd.Parameters.AddWithValue("@0", key);
                con.Open();
                foreach(IDataRecord reader in cmd.ExecuteReader())
                {
                    return ignite.GetBinary()
                        .GetBuilder("student")
                        .SetStringField("name", reader.GetString(0))
                        .SetIntField("salary", reader.GetInt32(1))
                        .Build();
                }
                return null;
            }
        }

        public IEnumerable<KeyValuePair<int, IBinaryObject>> LoadAll(IEnumerable<int> keys)
        {
            return keys.ToDictionary(x =>x, Load);
        }

        public void LoadCache(Action<int, IBinaryObject> act, params object[] args)
        {
        
        }

        public void SessionEnd(bool commit)
        {
            
        }

        public void Write(int key, IBinaryObject val)
        {
            Console.WriteLine("write to database");
            using (SqlConnection con = new SqlConnection(db))
            {
                SqlCommand cmd = new SqlCommand("insert into student (id,name,city,salary,location) values(@id,@name,@city,@salary,@location) ",con);
                cmd.Parameters.AddWithValue("@id", key);
                cmd.Parameters.AddWithValue("@name", val.GetField<string>("name"));
                cmd.Parameters.AddWithValue("@city", val.GetField<string>("city"));
                cmd.Parameters.AddWithValue("@salary", val.GetField<int>("salary"));
                cmd.Parameters.AddWithValue("@location", val.GetField<string>("location"));
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void WriteAll(IEnumerable<KeyValuePair<int, IBinaryObject>> entries)
        {
           foreach(var pair in entries)
            {
                Write(pair.Key, pair.Value);
            }
        }
    }

    public class studentfactory : IFactory<studentstore>
    {
        public studentstore CreateInstance()
        {
            return new studentstore();
        }
    }
}