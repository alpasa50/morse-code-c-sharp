using System;
using System.Collections.Generic;

namespace beep
{
    class Program
    {
        public static Dictionary<char, string> morseAlphabetDictionary;
        static void Main(string[] args)
        {   
            const int dot = 250;
            const int dash = dot * 3;

            morseAlphabetDictionary = new Dictionary<char, string>()

                {
                    {'A', ".-"},
                    {'B', "-..."},
                    {'C', "-.-."},
                    {'D', "-.."},
                    {'E', "."},
                    {'F', "..-."},
                    {'G', "--."},
                    {'H', "...."},
                    {'I', ".."},
                    {'J', ".---"},
                    {'K', "-.-"},
                    {'L', ".-.."},
                    {'M', "--"},
                    {'N', "-."},
                    {'O', "---"},
                    {'P', ".--."},
                    {'Q', "--.-"},
                    {'R', ".-."},
                    {'S', "..."},
                    {'T', "-"},
                    {'U', "..-"},
                    {'V', "...-"},
                    {'W', ".--"},
                    {'X', "-..-"},
                    {'Y', "-.--"},
                    {'Z', "--.."},
                    {'0', "-----"},
                    {'1', ".----"},
                    {'2', "..---"},
                    {'3', "...--"},
                    {'4', "....-"},
                    {'5', "....."},
                    {'6', "-...."},
                    {'7', "--..."},
                    {'8', "---.."},
                    {'9', "----."}
                };  
                String Palabra;
                char letras;
              try
                {  
            for (int i = 0; i < args.Length; i++)
            {
                Palabra = args[i].ToUpper();
                Console.WriteLine(Palabra);
                for (int j = 0; j < Palabra.Length; j++)
                {
                    try {
                    letras = Palabra[j];
                    Console.WriteLine(morseAlphabetDictionary[letras]);
                    
                    foreach (var caracteres in morseAlphabetDictionary[letras])
                    {
                        if(caracteres == '.'){
                                Console.Beep(600,dot);
                            }else{
                                Console.Beep(600,dash);
                            }
                        System.Threading.Thread.Sleep(dot * 3);  
                    }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    }
                    System.Threading.Thread.Sleep(dot*7); 
                }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            //const int dot = 250;
            //dot 250
            //dash = dot * 3
            //space = dot * 7
            //Console.Beep(600,250);
        }
    }
}
