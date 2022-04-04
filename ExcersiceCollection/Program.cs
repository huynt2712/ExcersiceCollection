using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Documents;

namespace ExcersiceCollection
{
    class Program 
    { public static void Main(string[] args)
        {
            //Bài tập về Array
            int[] number = { 2, 34, 5, 67, 7, 8 };
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //bài 1:
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //bài 2:
            //Cách 1:
            //int max = 0;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] > max)
            //    {
            //        max = number[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Cách 2:
            //Console.WriteLine(number.Max());

            //bài 3:
            //int i = 0,temp;
            //int j = number.Length - i - 1;
            //while (i < j)
            //{
            //    temp = number[i];
            //    number[i] = number[j];
            //    number[j] = temp;
            //    i++;
            //    j--;
            //}
            //for (i = 0; i < number.Length; i++)
            //{
            //    Console.Write(number[i] + " ");
            //}

            //ArrayList Excercise
            //ArrayList arrProduct1 = new ArrayList();
            //arrProduct1.Add(new Product("123", "MESA1", "Phân phối a", 10001));
            //arrProduct1.Add(new Product("123", "MESA2", "Phân phối b", 10002));
            //arrProduct1.Add(new Product("123", "MESA3", "Phân phối c", 10003));
            //arrProduct1.Add(new Product("123", "MESA4", "Phân phối d", 10004));

            //ArrayList arrProduct2 = new ArrayList();
            //arrProduct2.Add(new Product("123", "MESA5", "Phân phối e", 10005));
            //arrProduct2.Add(new Product("123", "MESA6", "Phân phối f", 10006));
            //arrProduct2.Add(new Product("123", "MESA7", "Phân phối g", 10007));


            //arrProduct1.AddRange(arrProduct2);
            //Console.WriteLine(arrProduct2.Count);
            //arrProduct1.Insert(1, new Product("123", "MESA8", "Phân phối h", 10008));
            //Console.WriteLine(arrProduct1.Count);
            //foreach(Product product in arrProduct1)
            //{
            //    product.GetInforProduct();
            //}


            //Hashtable dictionary = new Hashtable();
            //dictionary.Add("Cat", "Con mèo");
            //dictionary.Add("Dog", "Con chó");
            //dictionary.Add("VIP", "Người rất quan trọng");
            //dictionary.Add("Hello", "Xin chào");
            //dictionary.Add("Chicken", "Con gà");
            //foreach(DictionaryEntry dic in dictionary)
            //{
            //    Console.WriteLine("English: {0}  VietNamese: {1}", dic.Key, dic.Value);
            //}


            //SortedList<int, string> numbersorted = new SortedList<int, string>();
            //numbersorted.Add(5, "Thứ năm");
            //numbersorted.Add(3, "Thứ ba");
            //numbersorted.Add(4, "Thứ tư");
            //numbersorted.Add(6, "Thứ sáu");
            //numbersorted.Add(2, "Thứ hai");
            //numbersorted.Add(7, "Thứ bảy");
            //numbersorted.Add(1, "Chủ nhật");
            //foreach(KeyValuePair<int,string> daily in numbersorted)
            //{
            //    Console.WriteLine("Số thứ tự: {0}  Thứ trong tuần: {1}", daily.Key, daily.Value);
            //}


            //Stack mystack = new Stack();
            //mystack.Push("Hello");
            //mystack.Push("CSharp");
            //mystack.Push(",");
            //mystack.Push(".Net Core");
            //foreach (Object obj in mystack)
            //{
            //    Console.WriteLine(obj);
            //}
            //foreach (Object obj in mystack)
            //{
            //    if (mystack.Contains("CSharp"))
            //    {
            //        Console.WriteLine("CSharp"); break;
            //    }else { Console.WriteLine("Not found CSharp");break; }

            //}


            //Queue<string> programLanguages = new Queue<string>();
            //programLanguages.Enqueue("C#");
            //programLanguages.Enqueue("Java");
            //programLanguages.Enqueue("JS");
            //programLanguages.Enqueue("PHP");
            //foreach(string program in programLanguages)
            //{
            //    Console.WriteLine(program);
            //}

        //Printer printer = new Printer();
        //printer.Print<int>(100);
        //printer.Print(200); // type infer from the specified value
        //printer.Print<string>("Hello");
        //printer.Print("World!");
        

            List<Product> ProductList = new List<Product>();
            ProductList.Add(new Product("12","GIGA","Report",2000));
            ProductList.Add(new Product("13", "GIGA", "Report1", 5000));
            ProductList.Add(new Product("14", "GIGA", "Report2", 7000));
            ProductList.Add(new Product("15", "GIGA", "Report3", 9000));
            foreach(Product p in ProductList)
            {
                p.GetInforProduct();
            }
        }

    }
    
}
