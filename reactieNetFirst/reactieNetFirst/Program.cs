using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reactive.Linq;
using System.Reactive;

using System.Threading.Tasks;

namespace reactieNetFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var observable = Observable.Range(5, 10);

            IObserver<int> observer = Observer.Create<int>(
                Console.WriteLine, (error) => { Console.WriteLine($"error:{error.Message}"); },
                () => { Console.WriteLine("observer completed"); });


            var sub = observable.Subscribe(observer);
            Console.ReadKey();

            sub.Dispose();
        }
    }
}
