using System;

namespace Datatypes
{ // ctrl-alt-7 
    class Program
    {
        static void Main(string[] args)
        {
            // Koodi tulee tänne
            // Syntax - syntaksi
            // syntax error
            // Tämä on kommentti
            // Kommentit eivät suorita mitään

            // Datatypes - datatyypit
            // Numeroita
            // 35 - kokonaisluku - integer
            // 13.5 - liukuluku - floating point
            // Merkkejä - char / Merkkijono - string
            // 't'   / "word"
            // Bool 
            // true/false 1/0
            // Literals
            // data on tallessa muuttujissa - variable
            // <data_type> <variable name>
            //
            // int
            int apu = 5;
            int integerValue = 10; // puolipiste rivin loppuun
            integerValue = 15;
            // double - liukuluku
            double doubleValue;
            doubleValue = 3.14;
            // char
            char characterValue = 'r';
            // string
            string stringValue = "Word";
            // bool
            bool boolValue = false;

            // kommunikointi sovelluksen kanssa
            // käyttäjänä

            // luokaa muuttuja nimeltä message
            // ja antakaa sille arvoksi "Hello"
            string message = "Hello";
            Console.WriteLine(message);
            string input;
            input = Console.ReadLine();
            // "Vastasit x", jossa x on käyttäjän syöte(input).
            Console.WriteLine("Vastasit {0}", input);
            Console.WriteLine($"Interpolating {input} voi jatkaa tekstiä");
            Console.WriteLine("Vastasit " + input);

            #region 3 C# Perus: Ikä-tehtävä 
            //Koodi
            Console.Write("Anna ikäsi: ");
            string userInput = Console.ReadLine();
            int age = int.Parse(userInput);
            Console.WriteLine($"Olet {age} vuotta!");

            // Ilmoita käyttäjän ikä kuukausina
            // +, -, *, /, %
            int sum = 5 + 4;
            sum = 7 - age;
            sum = sum * age;
            sum /= age;
            // sum = 9
            #endregion

            #region 4 C# Perus: Palkan lasku
            // Pyydä käyttäjältä 4 eri arvoa ja suorita lasku
            #endregion




        }
    }
}
