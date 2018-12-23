using System;

namespace HvilkeDyrErDu
{
    class Program
    {
        static void Main(string[] args)
        {
            Magic();
        }

        private static void Magic()
        {
            Console.WriteLine("Skriv inn ditt navn: ");
            string value = Console.ReadLine();

            string lower = value.ToLower();
            Console.WriteLine(lower);
            char[] array = lower.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i];

                Console.Write("Letter: ");
                Console.WriteLine(letter);
            }

            int score = 0;

            foreach (var letter in array)
            {
                var lToS = letter.ToString();
                if (lToS == "a" || lToS == "c" || lToS == "e" ||
                    lToS == "g" || lToS == "i" || lToS == "k" ||
                    lToS == "m" || lToS == "o" || lToS == "q" ||
                    lToS == "s" || lToS == "u" || lToS == "w" ||
                    lToS == "y" || lToS == "æ" || lToS == "å")
                {
                    score++;
                }
            }


            //SCORE TABÈLL
            //SCORE TABÈLL =============================================================================
            //SCORE TABÈLL


            if (score == 0)
            {
                Console.WriteLine("Du er en meitemark!");
            }
            if (score == 1)
            {
                Console.WriteLine("Du er en mus!");
            }
            if (score == 2)
            {
                Console.WriteLine("Du er en rotte!");
            }
            if (score == 3)
            {
                Console.WriteLine("Du er en spurv!");
            }
            if (score == 4)
            {
                Console.WriteLine("Du er en hund!");
            }
            if (score == 5)
            {
                Console.WriteLine("Du er en katt!");
            }
            if (score == 6)
            {
                Console.WriteLine("Du er en ulv!");
            }
            if (score >= 7)
            {
                Console.WriteLine("Du er en ørn!");
            }


            Console.WriteLine();
            Console.WriteLine("Press a key to do another!");
            Console.ReadLine();
            Magic();
        }
    }
}

// a b c d e f g h i j k l m n o p q r s t u v w x y z æ ø å
// 7 bokstaver er gjennomsnitt