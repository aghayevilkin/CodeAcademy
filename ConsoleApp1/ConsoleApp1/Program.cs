using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            //Person[] persons = new Person[5];

            //Person person1 = new Person
            //{
            //    name = "ilkin",
            //    surname = "Aghayev"

            //}; Person person2 = new Person
            //{
            //    name = "ilkin",
            //    surname = "Aghayev"

            //}; Person person3 = new Person
            //{
            //    name = "ilkin",
            //    surname = "Aghayev"

            //}; Person person4 = new Person
            //{
            //    name = "ilkin",
            //    surname = "Aghayev"

            //}; Person person5 = new Person
            //{
            //    name = "ilkin",
            //    surname = "Aghayev"

            //};



            //string[] names = new string[5];
            //names[0] = "Ilkin";
            //names[1] = "Murad";
            //names[2] = "Sultan";
            //names[3] = "Gultac";
            //names[4] = "Aygun";



            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}



            Console.Write("Enter Size: ");
            int size =Convert.ToInt32(Console.ReadLine());
          
            string[] name = new string[size];

            

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write("Enter Name:");
                name[i] = Console.ReadLine();
            }


            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }







        






        //public static Person[] ArryReverse(Person[] people)
        //{
        //    Person[] reversedPeople = new Person[people.Length];
        //    for (int i = 0; i < people.Length; i++)
        //    {

        //        reversedPeople[reversedPeople.Length - (i + 1)] = people[i];
        //    }
        //    return reversedPeople;
        //}



    }
}
