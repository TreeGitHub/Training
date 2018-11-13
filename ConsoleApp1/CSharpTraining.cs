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
            //NearestToTwenty();
            //Matrix();  
            //ReverseLetters();
            //CheckThirty();
            //AddIfString();
            //RemoveCharacter();
            SwapFirstLast();
        }

        private static void SwapFirstLast()
        {
            string sString = "Theresa";
            
            Console.WriteLine(sString.Substring(sString.Length - 1) + sString.Substring(1, sString.Length - 2) + sString.Substring(0, 1));
            Console.Read();
        }
        private static void RemoveCharacter()
        {
            string sString1 = "Theresa";
            int iLength = 7;

            Console.WriteLine(sString1);
            for (int iCounter = 0; iCounter < iLength; iCounter++)
            {
                Console.WriteLine(sString1.Remove(iCounter, 1));
            }
            Console.Read();
        }
        private static void AddIfString()
        {
            string sString1 = "else";
            string sString2 = "If not";
            string sAddIf = "If ";
          
            Console.WriteLine((sString1.Substring(0, 3).Equals(sAddIf) ? sString1 : sString1.Insert(0, sAddIf)));
            Console.WriteLine((sString2.Substring(0, 3).Equals(sAddIf) ? sString2 : sString2.Insert(0, sAddIf)));
            Console.Read();
        }
        private static void CheckThirty()
        {
            int iNumber1 = 30;
            int iNumber2 = 20;
            bool bThirty = false;

            bThirty = iNumber1 == 30 || iNumber2 == 30 || (iNumber1 + iNumber2 == 30);
            Console.WriteLine(bThirty);

            iNumber1 = 20;
            iNumber2 = 10;
            bThirty = false;

            bThirty = iNumber1 == 30 || iNumber2 == 30 || (iNumber1 + iNumber2 == 30);
            Console.WriteLine(bThirty);

            iNumber1 = 10;
            iNumber2 = 10;
            bThirty = false;

            bThirty = iNumber1 == 30 || iNumber2 == 30 || (iNumber1 + iNumber2 == 30);
            Console.WriteLine(bThirty);

            Console.Read();
        }
        private static void ReverseLetters()
        {
            char[] cCharacters;
            int iCharacters;

            Console.Write("How many letters would you like to enter?:");
            iCharacters = Convert.ToInt32(Console.ReadLine());
            cCharacters = new char[iCharacters];

            for (int iCounter =0;iCounter < iCharacters; iCounter++)
            {
                Console.Write("Enter character {0}: ", iCounter);
                cCharacters[iCounter] = Convert.ToChar( Console.ReadLine());
            }
            Console.Write("You entered: "); 
            for (int iCounter = 0; iCounter < iCharacters; iCounter++)
            {
                Console.Write(cCharacters[iCounter]);
            }
            Console.WriteLine();
            Console.Write("The reverse order is: ");
            for (int iCounter = iCharacters-1; iCounter > -1; iCounter--)
            {
                Console.Write(cCharacters[iCounter]);
            }
            
            Console.Read();
        }

        private static void Matrix()
        {
            int[][] myMatrix;

            myMatrix = new int[][]
            {
                new int[]{0,2,3,2},
                new int[]{0,6,0,1},
                new int[]{1,2,3,4}
            };
            DisplayMatrix(myMatrix);
            Console.WriteLine();
            Console.WriteLine(SumMatrix(myMatrix));
            Console.Read();
        }
        private static void DisplayMatrix(int[][] myMatrix)
        {
            for (int j = 0; j < myMatrix.Length; j++)
            {
                if (j > 0) { Console.WriteLine(); }
                for (int i = 0; i < myMatrix[0].Length; i++)
                    if (myMatrix[j][i] == 0)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(myMatrix[j][i] + " ");
                    }
            }
        }
        private static int SumMatrix(int[][] myMatrix)
        {
            int x = 0;
            for (int j = 0; j < myMatrix.Length; j++)
                for (int i = 0; i < myMatrix[0].Length; i++)
                    if (myMatrix[j][i] > 0) { x += myMatrix[j][i]; }
            return x;
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
