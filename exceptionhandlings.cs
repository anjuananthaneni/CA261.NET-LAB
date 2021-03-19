using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultithreadingTutorial
{
    class HelloThread
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Create new Thread...\n");

           
            Thread newThread = new Thread(WriteB);

            Console.WriteLine("Start newThread...\n");

           
            newThread.Start();

            Console.WriteLine("Call Write('-') in main Thread...\n");

                    for (int i = 0; i < 50; i++)
            {
                Console.Write('-');

                
                Thread.Sleep(70);
            }


            Console.WriteLine("Main Thread finished!\n");
            Console.Read();
        }

        public static void WriteB()
        {
            
            for (int i = 0; i < 100; i++)
            {
                Console.Write('B');

                
                Thread.Sleep(100);
            }

        }
    }


}

