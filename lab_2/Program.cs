using System;

namespace lab_2
{
    class Program
    {
        static void Main()
        {
            //1
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int x = a; x <= b; x += 1)
            {
                if (x % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            //2
            string text = Convert.ToString(Console.ReadLine());
            for (var i = 1; i < text.Length; i += 2)
            {
                Console.WriteLine(text[i]);
            }
            //3
            string drink = Console.ReadLine();
            switch (drink)
            {
                case "Кава":
                    Console.WriteLine("Кава 50 грн");
                    break;
                case "Чай":
                    Console.WriteLine("Чай 40 грн");
                    break;
                case "Вода":
                    Console.WriteLine("Вода 15 грн");
                    break;
                case "Сік":
                    Console.WriteLine("Сік 30 грн");
                    break;
            }
            //4
            int i = 0;
            int num;
            int sum = 0;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                i++;
            }
            while (num > 0);

            double res = (double)(sum - num) / (i - 1);
            Console.WriteLine(res);
            //5
            int year = Convert.ToInt32(Console.ReadLine());
            bool yearResult = (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
            string result = yearResult ? "Рік високосний" : "Рік не високосний";
            Console.WriteLine(result);
            //6
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine("Cума цифр введеного цілого числа: " + sum);
            //7
            string number = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int element = Convert.ToInt32(number[i]);
                if (element % 2 == 1)
                { count += 1; }
            }
            string result = count == number.Length ? "Містить лише непарні цифри" : "Містить парні цифри";
            Console.WriteLine(result);
            //8
            string str = Console.ReadLine();
            int elemA = 0;
            int elemO = 0;
            int elemI = 0;
            int elemE = 0;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a':
                        elemA += 1;
                        break;
                    case 'o':
                        elemO += 1;
                        break;
                    case 'i':
                        elemI += 1;
                        break;
                    case 'e':
                        elemE += 1;
                        break;
                }
            }
            Console.WriteLine($"A: {elemA}, O: {elemO}, I: {elemI}, E: {elemE}");
            //9
            Console.WriteLine("Enter number of month");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine(31);
                    break;
                case 2:
                    Console.WriteLine(28);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine(30);
                    break;
            }
            //10
            int tenNum;
            int count = 0;
            int sum = 0;
            int mult = 1;
            int result = 0;
            for (var i = 0; i < 10; i += 1)
            {
                tenNum = Convert.ToInt32(Console.ReadLine());
                if (tenNum > 0)
                {
                    count++;
                }
                if (i < 5) { sum += tenNum; }
                if (i > 4) { mult *= tenNum; }
            }
            if (count == 10)
            {
                result = sum;
            }
            else if (count != 10)
            {
                result = mult;
            }
            Console.WriteLine(result);
        }
    }
}
