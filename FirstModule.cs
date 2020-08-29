using System;
using Namespacedemo.Dhruvi;
using Namespacedemo1.Dhruvi1;
using Class;
using Vardecl;
using TypeConversionDemo;
using Boxingunboxing;
using IfElse;
using SwitchCase;

class Demo
{
    public static void Main(string[] args)
    {
        //HelloWorld Demo
        Console.WriteLine("Hello Word");

        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        //HelloWorld Demo over

        //Namespace Demo object created
        Console.WriteLine("Namespace Demo");
        Console.WriteLine();
        FirstModule.print();
        Program1 p1 = new Program1();
        p1.print1();

        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();


        //Class Demo object created
        Console.WriteLine("Class Demo");
        Console.WriteLine();
        Classdemo c = new Classdemo();
        c.display();

        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        //Variable and DataType Demo
        Console.WriteLine("Variable Demo");
        Console.WriteLine();
        Variabledemo.vardemo();

        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        //TypeConversion Demo
        Console.WriteLine("TypeConversion Demo");
        Console.WriteLine();
        TypeConversion.typeconversion();

        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        //BoxingUnBoxing Demo
        Console.WriteLine("BoxingUnBoxing Demo");
        Console.WriteLine();
        Boxing.BoxingUnBoxing();

        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        //ifelse Demo
        Console.WriteLine("ifelse Demo");
        Console.WriteLine();
        Ifelse i = new Ifelse();
        i.ifelse();

        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        //switchcase Demo
        Console.WriteLine("switchcase Demo");
        Console.WriteLine();
        Switch.switchcase1();
        Switch.switchcase2();

        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        Console.ReadKey();
    }
}

//Namespace Demo started
namespace Namespacedemo
{
    namespace Dhruvi
    {
         class FirstModule
         {
            public static void print()
            {
                Console.WriteLine("Hello World from namespacedemo.Dhruvi");
            }
         }
    }
}

namespace Namespacedemo1
{
    namespace Dhruvi1
    {
        public class Program1
        {
            public void print1()
            {
                Console.WriteLine("Hello World from namespacedemo1.Dhruvi1");
            }
        }
    }
}
//Namespace Demo Over

//Class Demo started
namespace Class
{
    public class Classdemo
    {
        public void display()
        {
            Console.WriteLine("Classdemo class called");
        }
    }
}
//Class Demo over

//Variable and DataType Demo started
namespace Vardecl
{
    public class Variabledemo
    {
        public static void vardemo()
        {
            Console.WriteLine("Minimum value of byte is {0} and Maximum value of byte is {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Minimum value of integer is {0} and Maximum value of integer is {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Minimum value of float is {0} and Maximum value of float is {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Minimum value of double is {0} and Maximum value of double is {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("Minimum value of long is {0} and Maximum value of long is {1}", long.MinValue, long.MaxValue);

            Console.WriteLine();
            Console.WriteLine("DataType demo");
            Console.WriteLine();

            var v = 10;
            var s = "aaa";
            int? i = null;
            string s1 = "\"abc\"";
            string s2 = "E:\\Csharp\\Demo";
            string s3 = @"E:\C++\Demo";
            Console.WriteLine(s1 + "\n" + s2 + "\n" + s3);
        }
    }
}
//Variable and DataType over

//TypeConversion Demo started
namespace TypeConversionDemo
{
    public class TypeConversion
    {
        public static void typeconversion()
        {
            float f1 = 7.3f;
            double d1 = f1;                 //implicit TypeConversion
            Console.WriteLine("float variable f1 = {0} and after implicit TypeConversion, double variable d1 = {1}",f1,d1);

            float f2 = 7.3f;
            int i1 = (int)f2;               //explicit TypeConversion
            int i2 = Convert.ToInt32(f2);   //explicit TypeConversion
            Console.WriteLine("float variable f2 = {0} and after explicit TypeConversion, int variable i1 = {1} and i2 = {2}", f2, i1,i2);

            string s = "100";
            int i = int.Parse(s);
            Console.WriteLine("string s = \"100\" and after TypeConversion, int i = {0}",i);
        }
    }
}
//TypeConversion Demo over

//Boxing,UnBoxing Demo Started
namespace Boxingunboxing
{
    public class Boxing
    {
        public static void BoxingUnBoxing()
        {
            int i1 = 10;
            object o1 = i1;                     //Boxing
            Console.WriteLine("object o1 = {0}(Boxing)",o1);

            object o2 = 10; 
            int i2 = Convert.ToInt32(o2);       //UnBoxing
            Console.WriteLine("int i2 = {0}(UnBoxing)",i2);
        }
    }
}
//Boxing,UnBoxing Demo over

//ifelse Demo started
namespace IfElse
{
    public class Ifelse
    {
        public void ifelse()
        {
            Console.WriteLine("Enter any string");
            string s = Console.ReadLine();
            
            if(s.Length > 5 || s.StartsWith('a'))
            {
                Console.WriteLine("Valid string");
            }
            else if(s.EndsWith('z') || s.StartsWith('x'))
            {
                Console.WriteLine("unvalid string");
            }
            else
            {
                Console.WriteLine("enter valid string");
            }
        }
    }
}
//ifelse Demo over

//switch case Demo started
namespace SwitchCase
{
    public class Switch
    {
        public static void switchcase1()
        {
            Console.WriteLine("Enter a number from this(100,200,300,400)");
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 100:
                    Console.WriteLine("Number = 100");
                    break;

                case 200:
                    Console.WriteLine("Number = 200");
                    break;

                case 300:
                    Console.WriteLine("Number = 300");
                    break;

                case 400:
                    Console.WriteLine("Number = 400");
                    break;

                default:
                    Console.WriteLine("InValid Number");
                    break;
            }
        }

        public static void switchcase2()
        {
            Console.WriteLine("Enter a number from this('aaa','bbb','ccc','ddd')");
            string s = Console.ReadLine();

            switch (s)
            {
                case "aaa":
                case "bbb":
                case "ccc":
                case "ddd":
                    Console.WriteLine("String = {0}",s);
                    break;

                default:
                    Console.WriteLine("InValid String");
                    break;
            }
        }
    }
}
//switch case Demo over