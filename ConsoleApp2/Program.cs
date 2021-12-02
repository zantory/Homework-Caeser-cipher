using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch)) //checking if it alphabet
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a'; //sees if the Ascii is now less than the first letter in the alphabet
            return (char)((((ch + key) - d) % 26) + d); //ciphering each character, by adding the key and chinck if it doesnt goes beyond the letters 


        }


        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)                         // loop for ciphering data , one character ata time and will be added to output
                output += cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);                              //output according to the index for deciphered text(the original text)
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Type a string to encrypt:");
            string UserString = Console.ReadLine();                 //Taking input from user

            Console.WriteLine("\n");

            Console.Write("Enter your Key");
            int key = Convert.ToInt32(Console.ReadLine());      // taking key from user
            Console.WriteLine("\n");


            Console.WriteLine("Encrypted Data");

            string cipherText = Encipher(UserString, key);  //passing it to function
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.WriteLine("Decrypted Data:");

            string t = Decipher(cipherText, key);  // passing to function
            Console.WriteLine(t);
            Console.Write("\n");




            Console.ReadKey();

        }
    }
}
