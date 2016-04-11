using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingAContinuation
{

    //Listing 1-10 Adding a continuation
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                //throw new Exception();
                return 42;
            });
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Faulted");  
            },TaskContinuationOptions.OnlyOnFaulted);
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);


            Console.WriteLine(t.Result);
        }
    }
}
