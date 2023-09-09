// See https://aka.ms/new-console-template for more information

using System;
using System.Security.Claims;

namespace degiskenler 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            byte b=5;           //1 byte
            sbyte c=5;          //1 byte

            short s=5;          //2 byte
            ushort us=5;        //2 byte

            Int16 i16=2;        //2 byte
            int i=2;            //4 byte
            Int32 i32=2;        //4 byte
            Int64 i64=2;        //8 byte

            uint ui=2;          //4 byte
            long l=4;           //8 byte
            ulong ul=4;         //8 byte
            float f=5;          //4 byte
            double d=5;         //8 byte
            decimal de=5;       //16 byte

            char ch='2';        //2 byte
            string str="Meryem"; //sınırsız

            bool b1=true;
            bool b2=false;

            DateTime dt= DateTime.Now;
            Console.WriteLine(dt);

            object o1="x";
            object o2='y';
            object o3=5.7;

            string str1= string.Empty;
            str1="Meryem Talay";

            bool bool1=10>2;
            string str20="20";
            int int20=20;
            string yenideger=str20 + int20.ToString();
            Console.WriteLine(yenideger);

            
        }
    }
}