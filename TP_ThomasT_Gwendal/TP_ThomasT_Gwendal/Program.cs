using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TP_G_T
{
    class Program
    {
        static void Main(string[] args)
        {
            /*char separateur = ',';
            string str = "Hello";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("\"" + str[i] + "\"");
            }
            List<string> mots = Question1(separateur, str);*/


            //Q2
            Console.WriteLine("Question 2 : ");
            string phraseBonSens = "Voici ma phrase à l'envers question 2 ";
            Console.WriteLine("Voici ma phrase à l'envers question 2 :");
            Console.WriteLine(question2(phraseBonSens));

            //Q4
            Console.WriteLine("Question 4 : ");
            string phrase = "Voici ma phrase avec les mots inversés question 4 : ";
            Console.WriteLine("Voici ma phrase avec les mots inversés question 4 : ");
            Console.WriteLine(question4(phrase));

            question5();

            question6();

            int[] tableauQ7 = new int[] { 52, 25, 4, 89, 63, 74, 25, 44 };
            question7(tableauQ7);
        }



        static List<string> Question1(char c, string str)
        {
            List<string> maListe = new List<string>();
            
            for(int i = 0; i<= str.Length; i++)
            {
                
                if(str[i] == c)
                {
                    str += maListe[i];

                    str = +i == maListe.Count - 1 ? "" : " , ";
                    maListe.Add(" ");
                }
            }
            return maListe;
        }

        /*static List<string> question1(char separateur, List<string> chaine)
        {
           
            List<string> maListe = new List<string>();
            string str = "Hello";
            string cache = null;
            for (int i = 0; i <= chaine.Count; i++)
            {
                *//*if (i == separateur)
                {

                    chaine.Add(" ");
                    chaine.Clear();
                }

                if (i != separateur)
                {
                    chaine.Add(cache);
                }*//*
            }
            return chaine;
        }
*/
        public static String question2(String phraseBonSens)
        {

            
            string phraseEnvers = "";

            for (int counter = phraseBonSens.Length - 1; counter >= 0; counter--)
            {
                phraseEnvers += phraseBonSens[counter];
            }
            return phraseEnvers;
        }


        public static string question4(String phraseMotInversé)
        {
            string phrase = "";
            StringBuilder sb = new StringBuilder();
            string[] split = phraseMotInversé.Split(' ');
            for (int i = split.Length - 1; i > -1; i--)
            {
                sb.Append(split[i]);
                sb.Append(" ");
            }
            Console.WriteLine(sb);

            return phrase;
        }

        public static void question5()
        {
            int[] array = new int[5];
            Console.WriteLine("Question 5 : ");
            Console.WriteLine("Entrer 5 chiffres pour remplir la liste");
            for (int i = 0; i < 5; i++)
            {
                //Convert.ToInt32 permet de convertir tous les types en des entiers.
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int smallest = array[0];
            for (int i = 0; i < 5; i++)

            {
                //si la valeur de l'index récupéré est inférieure à smallest, alors smallest prend la valeur de cet index.
                if (array[i] < smallest)
                {
                    smallest = array[i];
                }
            }
            Console.WriteLine("Le plus petit chiffre est {0}", smallest);
        }

        public static void question6()
        {
            int[] tableau = new int[] { 3, 2, 6, 5, 8, 90, 86, 84, 53, 87, 81 };
            Console.WriteLine("Question 6 : ");
            Console.WriteLine(" Tableau non trié : [{0}]", string.Join(", ", tableau));
            //Array.Sort trie les éléments du tableau
            Array.Sort(tableau);
            Console.WriteLine(" Tableau trié : [{0}]", string.Join(", ", tableau));
        }

        public static void question7(int[]tableauQ7)
        {
            //int[] tableauQ7 = new int[] { 52, 25, 4, 89, 63, 74, 25, 44 };
            Console.WriteLine("Question 7");
            Console.WriteLine("Tableau non trié Question7 : [{0}]", string.Join(", ", tableauQ7));

            for (int i = 3; i < tableauQ7.Length; i++)
            {
                int x = tableauQ7[i];
                int j = i;
                while (tableauQ7[j - 1] > x)
                {

                    tableauQ7[j] = tableauQ7[j - 1];
                    j = j - 1;
                }
                tableauQ7[j] = x;
            }
                Console.WriteLine("Tableau trié : [{0}]", string.Join(", ", tableauQ7));
        }


        /* public static List<int> question8(List<int> liste1, List<int>liste2)
         {
             if(liste1 == null)
             {
                 return liste2;
             }
             if(liste2 == null)
             {
                 return liste1;
             }
             if (liste1[1] <= liste2[1])
             {
                 return liste1[1] + (liste1[], liste2);
             }
             else
             {
                 return liste2[1] + (liste1, liste2[]);
             }

         }*/

    }
}
