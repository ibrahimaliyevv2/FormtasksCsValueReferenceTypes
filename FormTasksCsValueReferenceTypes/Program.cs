using System;
//16.03.2022
namespace FormTasksCsValueReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Form-Task1
            //Massivde verilen en boyuk ededi tapan alqoritm

            //Console.WriteLine("Massivin olcusunu daxil edin:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int max = 0;
            //int[] numbers = new int[size];
            //Console.WriteLine("Massivin elementlerini daxil edin:");
            //for (int i = 0; i < size; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //    max = numbers[0];
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine("En boyuk element "+ max + "-dir.");
            #endregion

            #region Form-Task2
            // String massivinde verilen en uzun sozu tapan alqoritm

            //Console.WriteLine("Massivin olcusunu daxil edin:");
            //int size = Convert.ToInt32(Console.ReadLine());

            //string[] text = new string[size];
            //int maxSize = 0;
            //string max = "";
            //Console.WriteLine("Massivin elementlerini daxil edin:");
            //for (int i = 0; i < size; i++)
            //{

            //    text[i] = Console.ReadLine();

            //}

            //for (int i = 0; i < text.Length; i++) {
            //    maxSize = text[0].Length;
            //    if (text[i].Length > maxSize)
            //    {

            //        maxSize = text[i].Length;
            //        max = text[i];
            //}

            //}
            //Console.WriteLine("En uzun soz " + max + " sozudur.");
            #endregion

            #region Form-Task3
            //Ededin ikinin quvveti olub olmamasini ve necenci quvveti oldugunu tapan alqoritm

            //Console.WriteLine("Elementi daxil edin:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //bool isPowerOf2 = false;
            //for (int i = 2; i<=num; i*=2)
            //{
            //        count++;
            //    if(i == num)
            //    {
            //        isPowerOf2 = true;
            //    }
            //}
            //if (isPowerOf2)
            //{
            //    Console.WriteLine("2-nin "+count+"-ci quvvetidir.");
            //}
            //else
            //{
            //    Console.WriteLine("2-nin quvveti deyil!");
            //}
            #endregion

            #region Form-Task4
            //verilmis ededler siyahisindaki cut ededlerden ibaret yeni bir array duzelden proqram

            //Console.WriteLine("Ilkin massivin olcusunu daxil edin:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //int[] numbers = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine((i+1)+"-ci elementi daxil edin:");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        count++;
            //    }
            //}

            //int[] newNumbers = new int[count];
            //int j = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        newNumbers[j] = numbers[i];
            //        j++;
            //    }

            //}

            //Console.WriteLine("Yeni massivdeki elementler:");
            //foreach(int item in newNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Form-Task5-Addition


            //var result = IsEvenNumber(123714122);
            //Console.WriteLine(result);


            #endregion

            #region Form-Task6-Addition
            //int[] numArray = { 21, 22, 432, 123, 34452, 34311 };

            //int countAnswer = CountOfEvenNumbers(numArray);
            //Console.WriteLine(countAnswer);
            #endregion

            #region Form-Task7-Addition
            //int[] numArray = { 22, 33, 523, 4534, 15, 27, 39 };
            //int result = IndexOfNumber(numArray, 15);
            //Console.WriteLine(result);
            #endregion
        }


        //Gonderilmis integer deyerin cut olub-olmadigini qaytaran metod

        static bool IsEvenNumber(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        
        //Gonderilmis massivin icerisinde nece ededin cut oldugunu tapan metod

        static int CountOfEvenNumbers(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        

        
        //Massivden gonderilmis ededin indeksini tapan metod

        static int IndexOfNumber(int[] numbers, int num)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(num == numbers[i])
                { return i;
                } 
            }
            return -1;
        }
        
    }
}