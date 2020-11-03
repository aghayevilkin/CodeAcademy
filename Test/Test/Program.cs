using System;
using System.Dynamic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            string[] cars = { "Volvo", "BMW", "Ford", "Lada" };
            int[] myNum = { 10, 20, 30, 40 };

            ////for (int i = 0; i < cars.Length; i++)
            ////{
            ////    Console.WriteLine(cars[i]);
            ////}
            ////Burda Forech For nan eyni isi goruru
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("_________________________________");

            Array.Sort(myNum);
            Array.Reverse(myNum);
            ////Array.ForEach(myNum, n => Console.WriteLine(n));
            ////Belede yazmaq olur elede  :)
            foreach (int i in myNum)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("__________________________________");
            #endregion



            #region Task2



            //    int mevcut;

            //    Console.Write("Sinifde nece usaq var:");
            //    mevcut = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine();
            //    string[] student = new string[mevcut];

            //    for (int i = 0; i < mevcut; i++)
            //    {
            //        Console.Write("Student adini girin:");
            //        student[i] = Console.ReadLine();
            //    }

            //    Console.WriteLine("_____________________");

            #endregion


            #region Task3

            ////-100,100 ededlerden 20 sin random secirik ve
            ////Musbet veya Menfi olmasini yoxlayiriq

            //int pozitif = 0;
            //int negatif = 0;
            //int notr = 0;
            //Random rnd = new Random();

            //int[] reqemler = new int[20];
            //for (int i = 0; i < 20; i++)
            //{
            //    reqemler[i] = rnd.Next(-100, 100);
            //}
            //foreach (int reqem in reqemler)
            //{
            //    Console.WriteLine(reqem);
            //    if (reqem>0)
            //    {
            //        pozitif++;
            //    }
            //    else if (reqem<0)
            //    {
            //        negatif++;
            //    }
            //    else
            //    {
            //        notr++;
            //    }

            //}
            //Console.WriteLine("Musbet:" + pozitif);
            //Console.WriteLine("Menfi:" + negatif);
            //Console.WriteLine("Notr:" + notr);

            #endregion

            #region Task4


            ////Studentin no gore adini telefonunu mailini tapmaq

            //string[] StudentNo = { "1", "2", "3", "4", "5" };
            //string[] name = { "Ilkin", "Sultan", "Murad", "Tapdiq", "Elburus" };
            //string[] telefon = { "111", "222", "333", "444", "555" };
            //string[] mail = { "ilkinga@code.edu.az", "sultam@gmail.com", "murad@gmail.com", "tapdiq@gmail.com", "elburus@gmail.com" };

            //Console.WriteLine("Studentin no girin:");
            //string search = Console.ReadLine();
            //int no = Array.IndexOf(StudentNo, search.ToString());
            //Console.WriteLine("______________________________________");
            //Console.WriteLine("Student: {0}\tTelefonu: {1}\tE-Mail: {2}", name[no], telefon[no], mail[no]);

            #endregion


            #region Task5
            //////İstifadəçinin daxil etdiyi nömrənin massivdə olub olmadığını öyrənən və 
            //////ekranda nə qədər olduğunu göstərən bir sıra nümunəsi:

            //int[] reqemler = { 10, 55, 18, 44, 25, 78, 55, 65, 62, 22, 48, 18, 36 };
            //int reqem, yoxlama = 0;
            //Console.WriteLine("Reqem daxil edin: ");
            //reqem = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < reqemler.Length; i++)
            //{
            //    if (reqem==reqemler[i])
            //    {
            //        yoxlama++;
            //    }
            //}

            //if (yoxlama == 0)
            //{
            //    Console.WriteLine("Reqem massiv de tapilmadi...");
            //}
            //else
            //{
            //    Console.WriteLine("Bu reqem massiv de {0} eded var",yoxlama);
            //}
            #endregion


            #region Task6

            //////1 - 100 - dən təsadüfi ədədləri for dongusu ilə 20 elementli bir sıra halına gətirən proqram:

            //int[] massiv = new int[20];
            //Random rnd = new Random();

            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    massiv[i] = rnd.Next(1, 100);
            //    Console.WriteLine("Massivin {0}. iscisi={1}",i,massiv[i]);
            //}

            //Console.ReadKey();

            #endregion

        }
    }
}