using System;

namespace QuizCH2
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //    int i = 0;
            //    while (i < 1000)
            //  {
            //      Console.WriteLine(++i);
            //  }

            //  int i = 1001;
            //  while (i != 1)
            //  {
            //      Console.WriteLine(--i);
            //  }







            Console.WriteLine(QSix(1, 4));

            static int QSix(int begin, int end)
            {
                int sum = 0;
                while (begin <= end)
                {
                    
                    sum += begin;
                    Console.WriteLine(sum);
                    begin++;
                 

                }
              
                return sum;

            }


            //    static (int,int) QSeven(int length, int width){
            // 
            //        return ((length * length + width * width),(length * width)) ;
            //    }
            //

            //Q8  static int QEight( int a, int b, int c)
            //  {
            //      if (a > b && a > c)
            //      {
            //          return a;
            //      }
            //      else if (b > a && b > c)
            //      {
            //          return b;
            //      }
            //      else if (c > a && c > b)
            //      {
            //          return c;
            //      }
            //      else return 0;
            //  }


        }
    
        }
    }


