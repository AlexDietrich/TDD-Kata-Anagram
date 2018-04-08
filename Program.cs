using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = BuildAnagram(Console.ReadLine());
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }

            Console.Read();
        }

        internal static List<string> BuildAnagram(string s)
        {
            if(s.Length <= 1) return new List<string> {s};
            var anagrams = new List<string>();
            for (var i = 0; i < s.Length; i++)
            {
                var droppedCharacter = s.Substring(i, 1);
                var anagramsOfRest = BuildAnagram(DropCharacter(s, i));
                foreach (var anagramOfRest in anagramsOfRest)
                    anagrams.Add(droppedCharacter + anagramOfRest);
            }
            return anagrams;
        }

        internal static string DropCharacter(string s, int index)
        {
            return s.Substring(0, index) + s.Substring(index + 1, s.Length - (index + 1));
        }
    }
}
