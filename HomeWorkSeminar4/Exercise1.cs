namespace HomeWorkSeminar4
{
    internal class Exercise1
    {
        static public string[] SplinSetence(string sentence)
        {
            return sentence.Split(' ');
        }
        private void ShowWords(string[] words)
        {
            Console.WriteLine("Слова в предложении:");
            foreach (string word in words)
                Console.WriteLine(word);
        }
        public void Execute()
        {
            Console.WriteLine("Задание 1, Метод разделения строки на слова\nВведите предложение разделяя слова одним пробелом");
            while (true)
            {
                var input = Console.ReadLine();
                if (input != null && input != "")
                {
                    var result = SplinSetence(input);
                    ShowWords(result);
                    break;
                }
                Console.WriteLine("Вы ничего не ввели. Попробуйте еще раз");
            }
        }
    }
}
