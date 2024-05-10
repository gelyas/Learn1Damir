using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckStringNoRepeat.Service;

namespace CheckStringNoRepeat.Service
{
    public class RepeatDataService : IRepeatDataService
    {
        public string CheckRepeatSymbol(object input)
        {
            string result;
            string text = "abcqwertyuiopp";
            char[] textChar = text.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (textChar[i] == textChar[j] && i != j)
                    {
                        Console.WriteLine($"Символ {textChar[i]} - ДУБЛИКАТ!");
                        return $"Символ {textChar[i]} - ДУБЛИКАТ!";
                    }
                }
            }

            return "Строка без одинаковых символов"; ;
        }
    }
}
