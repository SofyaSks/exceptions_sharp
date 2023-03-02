using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//using static System.Exception;

//exception:
//system exception : базовый класс для всех исключений среды crl, стандартные ошибки
//application exception : созданные разработчиками

public class MyException :ApplicationException
{
    // 1 способ
    //private string message;
    /* public MyException()
     {
         message = "My Exception";
         TimeException = DateTime.Now;
     }
     public override string Message 
     {
         get {return message; }

     }*/

    // 2 способ
    public DateTime TimeException { get; private set; }
    public MyException() : base("My Exception division != 0")
    {
        TimeException = DateTime.Now;
    }


    /*[Serializable] // Exception + табулятор 
    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }*/

    
}


namespace exceptions_sharp
{
    internal class Program
    {
        static void f2() {
            throw new Exception("My exception");
        }

        static void f1()
        {
            f2();
        }

        static void f()
        {
            try
            {
                f1();
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message);
                WriteLine($"Stack trace: {ex.StackTrace}");
            }
        }
        /*static int myFunction(int n1, int n2)
        {
            int res = 0;
            try
            { res = n1 / n2; }
            catch(DivideByZeroException ex)
            {
                WriteLine(ex.Message);
                throw;
            }
            return res;
        }
       static void myFunc(int num)
        {
            *//*int num1, num2, res = 0;

               try
               {
                   num1 = int.Parse(ReadLine());
                   num2 = int.Parse(ReadLine());
                   res = num1 / num2;
                   WriteLine(res);

                   *//*if (res / 3 != 0)
                   {
                       throw new MyException();

                   }*//*
               }
               catch (DivideByZeroException dev)
               {
                   WriteLine(dev.Message);
               }
               catch (MyException exp)
               {
                   WriteLine(exp.Message);
                   WriteLine(exp.TimeException);
               }
               finally
               {
                   WriteLine($"Очистка ресурсов");
               }
               return 0;*//*

            if (num == 6)
                throw new Exception("Error num = 6");
            if (num == 1)
                throw new Exception("Error num = 1");


        }*/
        static void Main(string[] args)
        {
            WriteLine($"START");
            f();
            WriteLine("END");
          //  int num1, num2, res;
            /*int tmp = myFunc();
            string str;
            str = "Ivanov";
            WriteLine($"{str} - {tmp}");
            // try-finally можно без catch но обработки исключения не будет 
            WriteLine($"END");*/

            /*try
            {
                myFunc(2);
                myFunc(1);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            finally
            {
                WriteLine("Очистка ресурсов");
            }
            WriteLine($"END");*/

            /*int[] arr = new int[5];
            int j = 0;
            try
            {
                
                for (int i = -4; i < 4; i++)
                {
                    try
                    {
                        arr[j] = 200 / i;
                        WriteLine(arr[j]);
                        j++;
                    }
                    catch (DivideByZeroException ex)
                    {
                        WriteLine("inner exception");
                        WriteLine(ex.Message);
                    }
                   
                }
                WriteLine("*******************");
            }
            catch (Exception e) // ловит то что не було замечено
            {
                WriteLine("outer exception");
                WriteLine(e.Message);
            }
            finally
            {
                WriteLine("Очистка ресурсов");
            }
            WriteLine($"END");*/
        }
    }
}
