using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //LongWord();
            //SumPrime();
            //ReverseSentence();
            //FileSize();
            //MultiplyArrays();
            //RemoveLetters();
            //LowestLargest();
            NearestToTwenty();
           
        }

        private static void NearestToTwenty()
        {
            Console.Write("Enter first number: ");
            int iFirst = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int iSecond = Convert.ToInt32(Console.ReadLine());

            int iTwenty = 20;
            var val1 = Math.Abs(iFirst - iTwenty);
            var val2 = Math.Abs(iSecond - iTwenty);

            Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? iFirst : iSecond));

            Console.Read();
        }
        private static void LowestLargest()
        {
            Console.Write("Enter first number: ");
            int iFirst = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int iSecond = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int iThird = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largest of the three: " + Math.Max(iFirst, Math.Max(iSecond, iThird)));
            Console.WriteLine("Lowest of the three: " + Math.Min(iFirst, Math.Min(iSecond, iThird)));
            Console.Read();
        }

        private static void RemoveLetters()
        {
            string sRemove = "HP";
            string sInput = "PHP Tutorial";

            Console.WriteLine((sInput.Substring(1, 2).Equals(sRemove) ? sInput.Remove(1, 2) : sInput));
            Console.Read();
        }
        private static void MultiplyArrays()
        {
            int[] iFirstArray = { 1, 3, -5, 4 };
            int[] iSecondArray = { 1, 4, -5, -2 };

            Console.WriteLine("Array1: [{0}]", string.Join(" ", iFirstArray));
            Console.WriteLine("Array2: [{0}]", string.Join(" ", iSecondArray));

            for (int iMultiply = 0; iMultiply < iFirstArray.Length; iMultiply++)
            {
                Console.Write(iFirstArray[iMultiply] * iSecondArray[iMultiply]+" ");
            }

            Console.Read();
        }
        private static void FileSize()
        {
            FileInfo f = new FileInfo("C:/Users/treej/Documents/Software Development/profile pic.jpg");
            Console.WriteLine("Size of file {0} is: " + f.Length.ToString(), f.Name);
            Console.Read();
        }
        public static void ReverseSentence()
        {
            string sInput;

            Console.Write("Enter a sentence: ");
            sInput = Console.ReadLine();

            string[] sWords = sInput.Split(new[] { " " }, StringSplitOptions.None);
            string sNew = "";

            foreach (string s in sWords)
            {
                sNew = s + " " + sNew; 
            }

            Console.WriteLine(sNew);
            Console.Read();
        }
        public static void SumPrime()
        {
            long sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr < 500)
            {
                if (IsPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }
            Console.WriteLine("Sum: {0}", sum.ToString());
            Console.Read();
        }
        public static bool IsPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
        public static void OddNumbers()
        {
            for (int iNumber = 0; iNumber < 101; iNumber++)
            {
                if (iNumber % 2 != 0)
                {
                    Console.WriteLine(iNumber);
                }
            }

            Console.Read();
        }
        public static void LongWord()
        {
            string sInput;

            Console.Write("Enter a string: ");
            sInput = Console.ReadLine();

            string[] sWords = sInput.Split(new[] { " " }, StringSplitOptions.None);
            string sWord = "";
            int iCounter = 0;

            foreach (string s in sWords)
            {
                if (s.Length > iCounter)
                {
                    sWord = s;
                    iCounter = s.Length;
                }
            }

            Console.WriteLine("The longest word at {0} characters is {1}", iCounter, sWord);


            Console.Read();
        }
    }
}
