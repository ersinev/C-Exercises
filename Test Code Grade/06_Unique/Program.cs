using System;
using System.Collections.Generic;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some words : ");
            string sentence = Console.ReadLine();

            string sentence1 = " ";

            string resultwords = string.Empty;

            List<string> list = new List<string>();



            foreach (string WordA in sentence.Split(" "))
            {
                if (WordA.StartsWith('a'))
                {
                    list.Add(WordA);
                }
                else
                {
                    sentence1 = sentence1 + WordA + " ";
                }

            };

            foreach (string WordB in sentence1.Split(" "))
            {
                if (WordB.StartsWith('b'))
                {
                    list.Add(WordB);
                }
                else
                {
                    sentence1 = sentence1 + WordB + " ";
                }

            };

            foreach (string WordC in sentence1.Split(" "))
            {
                if (WordC.StartsWith('c'))
                {
                    list.Add(WordC);
                }
                else
                {
                    sentence1 = sentence1 + WordC + " ";
                }
            };

            foreach (string WordD in sentence1.Split(" "))
            {
                if (WordD.StartsWith('d'))
                {
                    list.Add(WordD);
                }
                else
                {
                    sentence1 = sentence1 + WordD + " ";
                }

            };

            foreach (string WordE in sentence1.Split(" "))
            {
                if (WordE.StartsWith('e'))
                {
                    list.Add(WordE);
                }
                else
                {
                    sentence1 = sentence1 + WordE + " ";
                }

            };



            foreach (string WordK in sentence1.Split(" "))
            {

                if (WordK.StartsWith('k'))
                {
                    list.Add(WordK);
                }
                else
                {
                    sentence1 = sentence1 + WordK + " ";
                }

            };


            foreach (string WordM in sentence1.Split(" "))
            {
                if (WordM.StartsWith('m'))
                {
                    list.Add(WordM);
                }
                else
                {
                    sentence1 = sentence1 + WordM + " ";
                }

            };


            foreach (string WordO in sentence1.Split(" "))
            {
                if (WordO.StartsWith('o'))
                {
                    list.Add(WordO);
                }
                else
                {
                    sentence1 = sentence1 + WordO + " ";
                }

            };

            foreach (string WordP in sentence1.Split(" "))
            {
                if (WordP.StartsWith('p'))
                {
                    list.Add(WordP);
                }
                else
                {
                    sentence1 = sentence1 + WordP + " ";
                }

            };



            foreach (string item in list)
            {
                if (!resultwords.Contains(item))
                {
                    resultwords += item + " ";
                }
            }

            Console.WriteLine(resultwords);
        }

    


         foreach (string item in list){

    if (!resultwords.Contains(item))
    {
        resultwords += item + " ";
    }


            Console.WriteLine(resultwords);
        }
}