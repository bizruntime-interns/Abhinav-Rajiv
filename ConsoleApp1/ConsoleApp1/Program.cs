using System;
using System.Linq;
using System.Reactive.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                IObservable<int> source = Observable.Generate(
                    5, i => i < 10,
                    i => i + 1,
                    i => i * i,
                    i=>TimeSpan.FromSeconds(i)
                    //i => TimeSpan.FromSeconds(i)
                );

                using (source.Subscribe(
                    x => Console.WriteLine("OnNext:  {0}", x),
                    ex => Console.WriteLine("OnError: {0}", ex.Message),
                    () => Console.WriteLine("OnCompleted")
                ))
                {
                    Console.WriteLine("Press ENTER to unsubscribe...");
                    Console.ReadLine();
                }
            
        }  
    }
}
