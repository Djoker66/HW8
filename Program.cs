using System;
using System.Runtime.Intrinsics.X86;

namespace HW8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1) Verilmiş M dəyərindən verilmiş N dəyərinədək 21-ə bölünən ədədlərin ədədi ortasını tapan proqram

            //int sum = 0;
            //int count = 0;
            //int N = 1000;
            //int M = 1;
            //int average;

            //for(int i = 0; i < N;i++)
            //{
            //    if (M % 21 == 0)
            //    {
            //        count++;
            //        sum += M;
            //        M++;
            //    }
            //    else
            //    {
            //        M++;
            //    }
            //}

            //if (count > 0)
            //{
            //    average = sum / count;
            //    Console.WriteLine(average);

            //}
            //else 
            //{
            //    Console.WriteLine("0-a bolmek olmaz");

            //}

            // 2) Verilmiş ədədin rəqəmləri cəmini tapan proqram

            //int n = 54;
            //int a = 0;
            //int sum = 0;


            //while (n > 0) 
            //{
            //        a = n % 10;
            //        sum += a;
            //        n = (n - a) / 10;

            //}
            //Console.WriteLine(sum);

            // 3) Verilmiş ayın ədədinə görə hansı fəsil olduğunu tapan proqram

            //    int n=21;

            //    if(n>=1 && n<=12)
            //    {
            //        if(n>=3 && n<=5)
            //        {
            //            Console.WriteLine("Yaz");
            //        }
            //        else if (n >= 6 && n <=8)
            //        {
            //            Console.WriteLine("Yay");

            //        }
            //        else if (n >= 9 && n <= 11)
            //        {
            //            Console.WriteLine("Payiz");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Qiw");
            //        }    
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error");
            //    }

            // 4) Verilmiş yazıda rəqəm olmamasını yoxlayan proqram, əgər rəqəm varsa yenidən yazının
            // daxil edilməsini istəməlidir ta ki rəqəmsiz daxil edilənədək.

            //Console.WriteLine("Yazin");
            //string inputStr = Console.ReadLine();


            //string[] nums = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            //for (int i=0; i<nums.Length; i++) 

            //{
            //    if (nums[i] == "0")
            //    {
            //        Console.WriteLine("Reqem daxil etmek olmaz");
            //        Console.ReadLine();

            //    }

            //   else if (nums[i] == "1")
            //    {
            //        Console.WriteLine("Reqem daxil etmek olmaz");
            //        Console.ReadLine();

            //    }

            //    else if (nums[i] == "2")
            //    {
            //        Console.WriteLine("Reqem daxil etmek olmaz");
            //        Console.ReadLine();
            //    }

            //    else if (nums[i] == "3")
            //    {
            //        Console.WriteLine("Reqem daxil etmek olmaz"); 
            //        Console.ReadLine();
            //    }

            //    else if (nums[i] == "4")
            //    {
            //        Console.WriteLine("Reqem daxil etmek olmaz");
            //        Console.ReadLine();
            //    }
            //    else if (nums[i] == "5")
            //    {
            //        Console.WriteLine("Reqem daxil etmek olmaz");
            //        Console.ReadLine();
            //    }
            //    else if (nums[i] == "6")
            //    {
            //        Console.WriteLine("Reqem daxil etmek olmaz");
            //        Console.ReadLine();
            //    }
            //    else if (nums[i] == "7")
            //    {
            //        Console.WriteLine("Reqem daxil etmek olmaz"); 
            //        Console.ReadLine();

            //    }
            //    else if (nums[i] == "8")
            //    {
            //        Console.WriteLine("Reqem daxil etmek olmaz");
            //        Console.ReadLine();

            //    }
            //    else if (nums[i] == "9")
            //    {
            //        Console.WriteLine("Reqem daxil etmek olmaz");
            //        Console.ReadLine();

            //    }

            //    else
            //    {
            //        Console.WriteLine("Reqem yoxdur");
            //    }

            //}

            // 5) Verilmiş 2 ədəd üzərində verilmiş operator simvoluna uyğun riyazi əməliyyat aparan proqram.
            // Misalçün consoledan 5,10 və + daxil edilsə 5 və 10 - u toplayıb nəticəsini göstərsin.
            // Console - dan daxil edilən operator + , -, *, / operatorlarından biri deyilsə operator yanlışdır yazılsın.

            Console.WriteLine("Birinci eded:");
            string n1 = Console.ReadLine();
            Console.WriteLine("Ikinci eded:");
            string n2 = Console.ReadLine();
            Console.WriteLine("Operator:");
            string n3 = Console.ReadLine();

            var num1 = Convert.ToInt32(n1);
            var num2 = Convert.ToInt32(n2);
            int result;
            

            if(n3 == "+")
            {
                result = num1 + num2;
                Console.WriteLine(result); 

            }
            else if (n3 == "-") 
            {
                result = num1 - num2;
                Console.WriteLine(result);
            }
            else if (n3 == "*")
            {
                result = num1 * num2;
                Console.WriteLine(result);
            }
            else if (n3 == "/")
            {
                result = num1 / num2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error");
            }



        }
    }
}
