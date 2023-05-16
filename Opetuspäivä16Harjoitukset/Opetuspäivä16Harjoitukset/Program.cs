using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä16Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {




        }
        public static int[] BubbleSortOnce(int[] input)
        {
            // Code the Bubblesort Algorithm here :D

            // reference type
            // input <- ei ole taulukon data, vaan osoite taulukon dataan.
            int[] newArray = new int[input.Length]; // Nyt newArray osoittaa input taulukkoon.

            // Array.Copy(input, newArray, input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                newArray[i] = input[i];
            }

            for (int i = 0; i < newArray.Length - 1; i++)
            {
                // Verrataan vierekkäiset indeksit
                if (newArray[i] > newArray[i+1])   // 9 1
                {
                    int temp = newArray[i + 1];    // 1
                    newArray[i + 1] = newArray[i]; // 9 9
                    newArray[i] = temp;            // 1 9
                }
            }

            return newArray;
        }

        public static string Compare(int a, int b)
        {
            string numberA = a.ToString();
            string numberB = b.ToString();
            
            if (numberA == numberB ||
                numberA[0] == numberB[1] && numberA[1] == numberB[0]) // 100%
            {
                return "100%";
            }
            else if (numberA[0] == numberB[0] ||  // 50%
                numberA[1] == numberB[1] ||
                numberA[0] == numberB[1] ||
                numberA[1] == numberB[1]) 
            {
                // 12 13
                // 21 13
                // 12 31
                // 21 31
                return "50%";
            }
            else
            {
                return "0%";
            }
        }
    }
}
