using System;

namespace Vigenere_Cipher
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("PLAIN TEXT: ");
            string plainText = Console.ReadLine();
            
            Console.Write("KEY: ");
            string key = Console.ReadLine();

            string encryptedText = Encrypt(plainText, key);
            Console.WriteLine("ENCRYPTED TEXT: " + encryptedText);
        }

        static string Encrypt(string plainText, string key)
        {
            string encryptedText = "";
            int keyLength = key.Length;

            for (int i = 0; i < plainText.Length; i++)
            {
                char plainChar = plainText[i];
                char keyChar = key[i % keyLength];
                Console.Write(plainChar);
                Console.Write(keyChar);
                
                int plainIndex = plainChar - 'A';
                int keyIndex = keyChar - 'A';

                char encryptedChar = (char)('A' + (plainIndex + keyIndex) % 26);
                encryptedText += encryptedChar;
            }
            return encryptedText;
        }
    }
}