using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercice I - Conseil de classe
            Console.WriteLine("------------------------------");
            Console.WriteLine("Exercice I - Conseil de classe");
            Console.WriteLine("------------------------------");

            string path = Directory.GetCurrentDirectory();
            string input = path + @"\class.csv";
            string output = path + @"\result.csv";
            
            using (FileStream fs = File.Create(input))
            using (StreamWriter writer = new StreamWriter(fs))
            {

                /*
                string line2 = Console.ReadLine();
                string line3 = Console.ReadLine();
                string line4 = Console.ReadLine();
                string line5 = Console.ReadLine();
                */
               
                writer.WriteLine("Marc;Histoire;14.5") ;
                writer.WriteLine("Jean;Maths;13.5");
                writer.WriteLine("Alice;Maths;16.0");
                writer.WriteLine("Superman;Maths;19");
                writer.WriteLine("Eloise;Histoire;08.5");
                writer.WriteLine("Edouard;Francais;1.5");
                writer.WriteLine(" ;Francais;3.5");
                writer.WriteLine("-;Maths;12.00");
                writer.WriteLine("yeah;Histoire;75");
                writer.WriteLine("ok;Histoire;08.5");
                writer.WriteLine("Guik;SUPAASMASHUBORTHEEEEEEEEERRRRRRRRRRMEEELEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE!!!!;11");
            }



                ClassCouncil.SchoolMeans(input, output);
            #endregion

            #region Exercice II - Performances des tris
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Exercice II - Performances des tris");
            Console.WriteLine("-----------------------------------");

            int[] a = { 6, 4, 8, 2, 9, 3, 9, 4, 7, 6, 1 };
            Console.WriteLine(SortingPerformance.UseInsertionSort(a) + " ms");
            Console.WriteLine(SortingPerformance.UseQuickSort(a) + " ms");

            //List<int> sizes = new List<int> { 2000, 5000, 10000 };
            //int count = 10;
            List<int> sizes = new List<int> { 2000, 5000, 10000, 20000, 50000, 100000 };
            int count = 50;
            SortingPerformance.DisplayPerformances(sizes, count);
            #endregion


            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

namespace Serie_IV
{
    class Program
    {
        static void Main(string[] args)
        {

            #region E2S4 - bracket control
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Exercice II : Contrôle des parenthèses");
            Console.WriteLine("--------------------------------");

            string Phrase = "J'imagine qu'il faut faire une phrase bien complexe avec ( des parenthèse ) ouvertes (( et fermés) mais avec aussi des brack{ets}, des accolades {{)} et plein de bonnes choses {{([[]]]]]))}}[[";
            BracketsControl.BracketsControls(Phrase);
            #endregion
        }
    }
}
