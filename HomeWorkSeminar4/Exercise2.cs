using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeminar4
{
    internal class Exercise2
    {
        private string ReverceSentence(string sentence)
        {
            Exercise1.SplinSetence(sentence);
            string result = "";
            string[] words = sentence.Split(' ');
            for(int i = words.Length - 1; i >= 0; i--)
                result += words[i] + " ";
            return result;
        }
        public void Execute()
        {
            Console.WriteLine("Задание 2. Перестановка слов в предложении\nВведите предложение разделяя слова одним пробелом");
            while (true)
            {
                var input = Console.ReadLine();
                if (input != null && input != "")
                {
                    var result = ReverceSentence(input);
                    Console.WriteLine("Переставленное предложение: "  + result);
                    break;
                }
                Console.WriteLine("Вы ничего не ввели. Попробуйте еще раз");
            }
        }
    }
}
