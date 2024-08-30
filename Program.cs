using System;
using System.ComponentModel.Design;

namespace Exception_Justin_Palmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result = 0f;

            Random rand = new Random();
            int myInt = rand.Next(2, 30);
            // try and catch state ment allows you to define a block of code to be tested for errors while it is being ececuted 
            try
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a number other tan zero.");
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());
                try
                {
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                } // finally statements let's you execute code, ater the result 
                finally
                {
                    Console.WriteLine("Calclations completed with a result of " + result);
                }

                try
                {
                    CheckAge(myInt);
                }
                catch 
                {
                    Console.WriteLine($"You are {myInt} not old enouth!");
                }
            }   
            
        }/// <summary>
        ///  throw statements allows you to create a custom error 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
            static float Divide(float x, float y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }

        static void CheckAge(int age)
        {
            if (age >= 17)
            {
                Console.WriteLine($"You are {age}, you can play mature games!");
            }
            else
            {
                throw new ArgumentException();
            }


        }

    }








}