using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async___Task
{
    class Program
    {
        public int Count { get; set; }
        private Object object1 = new Object();
        private Object object2 = new Object();
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Loop1);
            Thread thread2 = new Thread(Loop2);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();            
        }
        #region Loops
        static void Loop1()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Loop1 {i}");
            }
        }
        static void Loop2()
        {
            for (int i = 100; i < 200; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Loop2 {i}");
            }
        }
        static void Loop3()
        {
            for (int i = 300; i < 400; i++)
            {
                Console.WriteLine($"Loop3 {i}");
            }
        }
        #endregion

        #region Medthods
        void Increase()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock (object1)
                {
                    lock (object2)
                    {
                        Console.WriteLine(i);
                        Count++;
                    }
                }


            }
        }
        void Decrease()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock (object2)
                {
                    lock (object1)
                    {
                        Console.WriteLine(i);
                        Count--;
                    }
                }

            }
        }

        #endregion  

        public static async Task<int> Sum()  // async metod geriye bir sey qaytarir ve onu await elemeliyik
        {
            int result = 0;
            var task = Task.Run(() =>        // predicate isteyir bizden
            {
                for (int i = 0; i < 100; i++)
                {
                    result += i;
                }
            });
            await task;
            return result;
        }
        private async Task<int> Test(int count)
        {
            Console.WriteLine("eggs pan");
            await Task.Delay(200);
            Console.WriteLine($"{count}");
            Console.WriteLine("cooking");
            await Task.Delay(2000);
            Console.WriteLine("plate");
            return 5;
        }
    }
}
