using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.TryCatchThrow
{
    /*class TryCatchThrowEx
    {
        static void Main(string[] args)
        {
            *//*int a = 10, b = 0;
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*//*

            int a = 10, b = 2;
            try
            {
                int res = a / b;
                int[] arr = { 1, 3, 5, 7, 9 };
                arr[7] = 10;
                
                Console.WriteLine(res);
                Console.WriteLine(arr);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           *//* catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }*//*
            finally
            {
                Console.WriteLine("end code");
            }


           *//* try
            {
                int[] arr = new int[5];
                arr[7] = 20;
                Console.WriteLine(arr);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }*//*
        }
        }*/

    public class Book
    {
        private string bookname;
        private string author;
        private double price;
        private double dprice;

        public Book(string bookname, string author, double price)
        {
            this.bookname = bookname;
            this.author = author;
            this.price = price;
        }
        public void Cal()
        {
            dprice = price - (price * 0.10);
            Console.WriteLine(dprice);
        }
        public override string ToString()
        {
            return $"Name->{bookname} Author->{author} Price->{price}";
        }
        public static void Main(string[] args)
        {
            Book b1 = new Book("test", "test2", 400);
            b1.Cal();
            Console.WriteLine(b1);
        }
    }
}
