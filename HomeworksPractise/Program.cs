using System;

namespace HomeworksPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homeworks-Tasks


            #region Task-1
            //1.Daxil edilmiş string dəyərinin içində rəqəm olub olmadığını tapan proqram
            //Console.WriteLine("Zehmet olmasa deyer daxil edin");
            //string word = Console.ReadLine();
            //char[] nums_arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //bool isNum = false;
            //for (int i = 0; i <word.Length; i++)
            //{
            //    for (int j = 0; j < nums_arr.Length; j++)
            //    {
            //        if (word[i] == nums_arr[j])
            //        {
            //            isNum = true;
            //            break;
            //        }
            //    }
            //}

            //if (isNum)
            //{
            //    Console.WriteLine("Bu sozde reqem var");
            //}
            //else
            //{
            //    Console.WriteLine("Bu sozde reqem yoxdur");
            //}
            #endregion

            #region Task-2
            //2.Daxil edilmiş string dəyərində  ardıcıl a ve l char-larının olub olmadığını
            //tapan proqram.Misalçün alma, salam və s. kimi sözlərdə "vardir" yazdırmalıdır geriyə.


            //string name = Console.ReadLine();
            //bool check = false;
            //for (int i = 1; i < name.Length; i++)
            //{
            //    if (name[i] == 'l' && name[i - 1] == 'a')
            //    {
            //        check = true;
            //        break;
            //    }


            //}
            //if (check) {
            //    Console.WriteLine("var");
            //}
            #endregion

            #region Task-4
            //4. Daxil edilmiş yazı siyahısında (string array) neçə sözdə rəqəm olduğunu tapan proqram
            //Console.WriteLine("Adlarin sayini daxil et:");
            //int namesCount = Convert.ToInt32(Console.ReadLine());

            //string[] names = new string[namesCount];

            //for (int i = 0; i < namesCount; i++)
            //{
            //    Console.WriteLine((i + 1) + "-ci adi daxil et:");
            //    names[i] = Console.ReadLine();
            //}
            //int count = 0;
            //for (int i = 0; i < namesCount; i++)
            //{
            //    for (int j = 0; j < names[i].Length; j++)
            //    {
            //        if (names[i][j] >= '0' && names[i][j] <= '9')
            //        {
            //            count++;
            //            break;
            //        }

            //    }
            //}
            //Console.WriteLine(count);
            #endregion


            #endregion

            #region Classworks-Tasks


            #region Task-1
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[size];
            //int max = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] >= max)
            //    {
            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine(max);

            #endregion


            #region Task-2
            //massivde en uzun sozu tapan alqoritm
            Console.WriteLine("Daxil edeceyiniz soz sayi: ");
            string strCount = Console.ReadLine();
            int strCounter = Convert.ToInt32(strCount);
            string[] str = new string[strCounter];
            int maxWordSize = 0;
            string maxWord = "";
            for (int i = 0; i < strCounter; i++)
            {
                str[i] = Console.ReadLine();
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxWordSize)
                {
                    maxWordSize = str[i].Length;
                    maxWord = str[i];
                }
            }
            Console.WriteLine(maxWord);
            #endregion

            #region Task-3
            Console.WriteLine("ededi daxil edin: ");
            string numberstr = Console.ReadLine();
            int number = Convert.ToInt32(numberstr);
            int count = 0;
            int master = 1;

            while (number > master)
            {
                master *= 2;
                count++;
            }
            if (number == master)
                Console.WriteLine($"{number} = 2^{count}");
            else
                Console.WriteLine("bu eded 2 ustu quvvet seklinde gosterile bilmez");



            #endregion



            #endregion

        }
    }
}