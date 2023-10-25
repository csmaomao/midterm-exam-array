using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_Lab_Exam_Garcia
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] test = new string[5, 6];
            for (int x = 0; x < 5; x++)
            {
                string name;
                int mathscore = 0, readingscore = 0, historyscore = 0;
                float average = 0;
                Console.Write("Name: ");
                name = Console.ReadLine();
                test[x, 0] = name;

                Console.WriteLine("\nMultiple choice exam, good luck students!");

                Console.WriteLine("\n--------");
                Console.WriteLine("MATH TEST");
                Console.WriteLine("--------");
                Console.WriteLine("\nQuestion 1: What is the only number that has the same number of letters as it’s meaning?");
                Console.WriteLine("[1] Four");
                Console.WriteLine("[2] Six");
                Console.WriteLine("[3] One ");
                Console.WriteLine("[4] Nine");
                Console.Write("Answer: ");
                int mathOne = Int32.Parse(Console.ReadLine());
                if (mathOne == 1)
                {
                    mathscore++;
                }
                else
                {

                }
                Console.WriteLine("\nQuestion 2: What number doesn’t have its own Roman numeral?");
                Console.WriteLine("[1] 8");
                Console.WriteLine("[2] 1");
                Console.WriteLine("[3] 0");
                Console.WriteLine("[4] 76");
                Console.Write("Answer: ");
                int mathTwo = Int32.Parse(Console.ReadLine());
                if (mathTwo == 3)
                {
                    mathscore++;
                }
                else
                {

                }
                Console.WriteLine("\nQuestion 3: What is the only even prime number?");
                Console.WriteLine("[1] 6");
                Console.WriteLine("[2] 4");
                Console.WriteLine("[3] 8");
                Console.WriteLine("[4] 2");
                Console.Write("Answer: ");
                int mathThree = Int32.Parse(Console.ReadLine());

                if (mathThree == 4)
                {
                    mathscore++;
                }
                else
                {

                }
                Console.WriteLine("\nQuestion 4: What is the only even prime number?");
                Console.WriteLine("[1] 2");
                Console.WriteLine("[2] 6");
                Console.WriteLine("[3] 11");
                Console.WriteLine("[4] 9");
                Console.Write("Answer: ");
                int mathFour = Int32.Parse(Console.ReadLine());

                if (mathFour == 2)
                {
                    mathscore++;
                }
                else
                {

                }
                Console.WriteLine("\nQuestion 5: What is the most popular lucky number?");
                Console.WriteLine("[1] 7");
                Console.WriteLine("[2] 3");
                Console.WriteLine("[3] 777");
                Console.WriteLine("[4] 6");
                Console.Write("Answer: ");
                int mathFive = Int32.Parse(Console.ReadLine());

                if (mathFive == 1)
                {
                    mathscore++;
                }
                else
                {

                }

                test[x, 1] = mathscore.ToString();

                //-------------------------------------

                Console.WriteLine("\n------------");
                Console.WriteLine("READING TEST");
                Console.WriteLine("------------");
                Console.WriteLine("\nQuestion 1: I live in Amsterdam. What is the Noun?");
                Console.WriteLine("[1] Amsterdam");
                Console.WriteLine("[2] I");
                Console.WriteLine("[3] live ");
                Console.WriteLine("[4] in");
                Console.Write("Answer: ");
                int readingOne = Int32.Parse(Console.ReadLine());
                if (readingOne == 1)
                {
                    readingscore++;
                }
                else
                {

                }
                Console.WriteLine("\nQuestion 2: I visited the Eiffel Tower in Paris. Identify the noun.");
                Console.WriteLine("[1] visited");
                Console.WriteLine("[2] Paris");
                Console.WriteLine("[3] Eiffel Tower and Paris");
                Console.WriteLine("[4] Eiffel Tower");
                Console.Write("Answer: ");
                int readingTwo = Int32.Parse(Console.ReadLine());

                if (readingTwo == 3)
                {
                    readingscore++;
                }
                else
                {

                }
                Console.WriteLine("\nQuestion 3: Summer is very hot. What is the noun?");
                Console.WriteLine("[1] is");
                Console.WriteLine("[2] very");
                Console.WriteLine("[3] hot");
                Console.WriteLine("[4] Summer");
                Console.Write("Answer: ");
                int readingThree = Int32.Parse(Console.ReadLine());

                if (readingThree == 4)
                {
                    readingscore++;
                }
                else
                {

                }
                Console.WriteLine("\nQuestion 4: The moon looks so beautiful. What is the noun?");
                Console.WriteLine("[1] beautiful");
                Console.WriteLine("[2] moon");
                Console.WriteLine("[3] the");
                Console.WriteLine("[4] looks");
                Console.Write("Answer: ");
                int readingFour = Int32.Parse(Console.ReadLine());

                if (readingFour == 2)
                {
                    readingscore++;
                }
                else
                {

                }
                Console.WriteLine("\nQuestion 5: The mailman Mr. Joe was carrying postcards.");
                Console.WriteLine("[1] Mailman, Mr. Joe and postcards");
                Console.WriteLine("[2] Mailman");
                Console.WriteLine("[3] Mr. Joe");
                Console.WriteLine("[4] Postcards");
                Console.Write("Answer: ");
                int readingFive = Int32.Parse(Console.ReadLine());

                if (readingFive == 1)
                {
                    readingscore++;
                }
                else
                {

                }

                test[x, 2] = readingscore.ToString();

                //-------------------------------------
                Console.WriteLine("\n------------");
                Console.WriteLine("HISTORY TEST");
                Console.WriteLine("------------");
                Console.WriteLine("\nQuestion 1: Which axis country conquered the Philippines during World War II?");
                Console.WriteLine("[1] Japan");
                Console.WriteLine("[2] Spain");
                Console.WriteLine("[3] America ");
                Console.WriteLine("[4] South Korea");
                Console.Write("Answer: ");
                int historyOne = Int32.Parse(Console.ReadLine());
                if (historyOne == 1)
                {
                    historyscore++;
                }
                else
                {

                }
                Console.WriteLine("\nQuestion 2: What is the oldest Philippine city?");
                Console.WriteLine("[1] Quezon City");
                Console.WriteLine("[2] Antipolo");
                Console.WriteLine("[3] Cebu");
                Console.WriteLine("[4] Manila");
                Console.Write("Answer: ");
                int historyTwo = Int32.Parse(Console.ReadLine());

                if (historyTwo == 3)
                {
                    historyscore++;
                }
                else
                {

                }
                Console.WriteLine("\nQuestion 3: Who was the founder and supremo of the Katipunan?");
                Console.WriteLine("[1] Gen. Juan Luna");
                Console.WriteLine("[2] Gen Gregorio Del Pilar");
                Console.WriteLine("[3] Dr. Jose Rizal");
                Console.WriteLine("[4] Andres Bonifacio");
                Console.Write("Answer: ");
                int historyThree = Int32.Parse(Console.ReadLine());

                if (historyThree == 4)
                {
                    historyscore++;
                }
                else
                {

                }
                Console.WriteLine("\nQuestion 4: Which president-turned-dictator declared Martial Law in the Philippines in?");
                Console.WriteLine("[1] Bongbong Marcos");
                Console.WriteLine("[2] Ferdinand Marcos");
                Console.WriteLine("[3] Rodrigo Duterte");
                Console.WriteLine("[4] Corazon Aquino");
                Console.Write("Answer: ");
                int historyFour = Int32.Parse(Console.ReadLine());

                if (historyFour == 2)
                {
                    historyscore++;
                }
                else
                {

                }
                Console.WriteLine("\nQuestion 5: What is the oldest university in the Philippines and in Asia?");
                Console.WriteLine("[1] University of Sto. Tomas");
                Console.WriteLine("[2] University of the Philippines");
                Console.WriteLine("[3] Adamson University");
                Console.WriteLine("[4] De La Salle University");
                Console.Write("Answer: ");
                int historyFive = Int32.Parse(Console.ReadLine());

                if (historyFive == 1)
                {
                    historyscore++;
                }
                else
                {

                }

                test[x, 3] = historyscore.ToString();
                //----------------------------------
                average = ((float)mathscore + (float)readingscore + (float)historyscore) / 3;
                test[x, 4] = average.ToString();
                int finalscore = mathscore + readingscore + historyscore;
                if(finalscore >= 10)
                {
                    string pass = "Passed";
                    test[x, 5] = pass;
                }
                else
                {
                    string fail = "Failed";
                    test[x, 5] = fail;
                }

                Console.Clear();

            }

            Console.Write("Name:" + "\t" + "\t" + "\t");
            Console.Write("Math:" + "\t" + "\t" + "\t");
            Console.Write("Reading:" + "\t" + "\t");
            Console.Write("History:" + "\t" + "\t");
            Console.Write("Average:" + "\t" + "\t" + "\t");
            Console.Write("Remarks:" + "\t" + "\t" + "\n");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(test[i, j] + "\t" + "\t" + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
