using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string transcript = "in the code above, we've used Split to split the line of text and put the words into an array. we've then used Join to create a single line of text again. this time, though, the words are separated with hyphens and not commas";
            Console.WriteLine(Capitalize(transcript, '.'));
            Console.ReadLine();
        }

        public static string Capitalize(string transc, char delimiter)
        {
            var sentences = transc.Split(delimiter);
            List<string> list = new List<string>();
            string finalSent = "";

            for (int i = 0; i < sentences.Length; i++)
            {
                char[] tempArr = sentences[i].ToCharArray();
                if(!tempArr[0].Equals(' '))
                {
                    tempArr[0] = char.ToUpper(tempArr[0]);
                    string tempString = new string(tempArr);
                    list.Add(tempString);
                }
                else
                {
                    tempArr[1] = char.ToUpper(tempArr[1]);
                    string tempString = new string(tempArr);
                    list.Add(tempString);
                }
            }

            string s = delimiter.ToString();
            string[] completedArr = list.ToArray();
            finalSent = String.Join(s, completedArr);

            return finalSent;
        }
    }
}
