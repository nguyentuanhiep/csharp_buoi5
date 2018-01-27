using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Buoi5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai1();
            //Bai2();
            //Bai3();
            //Bai4();
            //Bai5();
            Bai6();
            
        }

        static void Bai1()
        { 
            try
            {
                List<int> numbersList = new List<int>();
                Console.Write("Nhap so phan tu cua List");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Nhap so");
                    int input = Convert.ToInt32(Console.ReadLine());
                    numbersList.Add(input);
                }
                for (int i = 0; i < numbersList.Count; i++)
                {
                    if (numbersList[i] % 2 == 0)
                    {
                        System.Console.Write(numbersList[i] + " ");
                    }
                }
            }
            catch (System.FormatException)
            {
            
              System.Console.WriteLine("Ban phai nhap mot so");
            }
        }

        static void Bai2()
        {
            string pass = "techmaster";
            Console.WriteLine("Nhap vao ki tu dau tien");
            string first = Console.ReadLine();
            Console.WriteLine("Nhap vao ki tu cuoi cung");
            string last = Console.ReadLine();
            if (first == "t" && last =="r")
            {
                Console.WriteLine(pass);
            } else {
                Console.WriteLine("Khong co");
            }
        }

        static void Bai3()
        {
            try
            {
                
                List<int> value = new List<int>();
                Console.WriteLine("Nhap so phan tu cua chuoi");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap so");
                    int a = Convert.ToInt32(Console.ReadLine());
                    value.Add(a);
                }
                int temp;
                for(int i=1; i<n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (value[i] < value[j])
                        {
                            
                            temp = value[i];
                            value[i] = value[j];
                            value[j] = temp;
                        }
                    }
                }
                System.Console.WriteLine("Ban muon tim so lon thu may");
                int input = Convert.ToInt32(Console.ReadLine());
                int num = 0;
                for (int i = 0; i < value.Count; i++)
                {
                    num = value[input];
                }
                System.Console.WriteLine(num);
            }
            catch (System.ArgumentOutOfRangeException)
            {
            
                System.Console.WriteLine("So ban nhap qua lon");
            }
            catch (System.FormatException)
            {
              System.Console.WriteLine("Ban phai nhap vao mot so");
            }
        }


        static void Bai4()
        {
            try
            {
                List<string> sort = new List<string>();
                Console.Write("Nhap so phan tu cua mang");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Nhap phan tu");
                    string input = Convert.ToString(Console.ReadLine());
                    sort.Add(input);
                }
                sort.Sort();
                for (int i = 0; i < sort.Count; i++)
                {
                    for (int j = i + 1; j < sort.Count; j++)
                    {
                        if (sort[i] == sort[j])
                        {
                            sort.Remove(sort[j]);
                        }
                    }
                }
                for (int i = 0; i < sort.Count; i++)
                {
                    System.Console.Write(sort[i] + "-");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        static void Bai5()
        {

        }


        public class Student
        {
            public string Name { get; set; }
            public int Point { get; set; }
        }
        static void Bai6()
        {
            List<Student> list = new List<Student>(){
               new Student(){Name = "hiep" , Point=8},
               new Student(){Name= "thai",Point=6},
               new Student(){Name = "ducanh" , Point=9},
               new Student(){Name= "huy",Point=5},
               new Student(){Name = "duy" , Point=7},
               new Student(){Name= "thang",Point=8}
            };
            int num = 0;
            foreach (var student in list)
            {
               num += student.Point;
            }

            var set = from count in list
				where count.Point < num/6
				select count;
            foreach (var item in set)
            {
                 System.Console.WriteLine(item.Name);
            }
        }
    }
}
