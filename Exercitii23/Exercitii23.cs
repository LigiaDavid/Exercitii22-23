using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii23
{
    class Exercitii23
    {
        static void Main(string[] args)
        {
            Ex1();

            Ex2();

            Ex3();

            Ex4();

            Ex5();

            Ex6();

            Ex7();

            Ex8();

            Ex9();

            Ex10();

            Ex11();

            Ex12();

            Ex13();

            Ex14();

            Ex15();

            Ex16();

            Ex17();

            Ex18();

            Ex19();

            Ex20();

            Ex21();

            Ex22();

            Ex23();

            Ex24();

            Ex25();

            Ex26();


            Console.ReadLine();
        }
        //1. Scrieti un program care sa afiseze primele 10 numere naturale.
        public static void Ex1()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{i}");
                i++;
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //2. Scrieti un program care sa afiseze suma primelor 10 numere naturale.
        public static void Ex2()
        {
            Console.WriteLine("The sum of the first 10 natural numbers is: ");
            int i = 0;
            int sum = 0;
            while (i <= 10)
            {
                sum = sum + i;
                i++;
            };
            Console.WriteLine("{0}", sum);
            Console.WriteLine("==========================================================================================\n");
        }

        //3. Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi.
        public static void Ex3()
        {
            int i = 1;
            int n;
            Console.WriteLine("Write a number:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"The numbers smaller than the number {n} are: ");
            while (i < n)
            {
                Console.WriteLine("{0}", i);
                i++;
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //4. Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi.
        public static void Ex4()
        {
            int i = 3;
            int n;
            Console.WriteLine("Write a number:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"The numbers from 3 to {n} are: ");
            while (i <= n)
            {
                Console.WriteLine("{0}", i);
                i++;
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //5. Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi.

        public static void Ex5()
        {
            int i = 1;
            int n;
            Console.WriteLine("Write a number:");
            n = int.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine($"The sum of the numbers smaller than the number {n} is: ");
            while (i < n)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine("{0}", sum);

            Console.WriteLine("==========================================================================================\n");
        }

        //6. Afisati cubul primelor 5 numere naturale.
        public static void Ex6()
        {
            Console.WriteLine("The cubes of the first 5 natural numbers are: ");
            int i = 1;
            int cube;
            while (i <= 5)
            {
                cube = i * i * i;
                Console.WriteLine("{0}", cube);
                i++;
            };
            Console.WriteLine("==========================================================================================\n");
        }

        //7. Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru.
        public static void Ex7()
        {
            int i = 1;
            int n;
            Console.WriteLine("Write a number:");
            n = int.Parse(Console.ReadLine());
            while (i < n)
            {
                i++;
                if (i % 2 != 1)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //8. Scrieti un program care sa afiseze primele 10 numere naturale.( do while)
        public static void Ex8()
        {
            Console.WriteLine("The first 10 natural numbers are: ");
            int i = 1;
            do
            {
                Console.WriteLine("{0}", i);
                i++;
            }
            while (i <= 10);

            Console.WriteLine("==========================================================================================\n");
        }

        //9. Scrieti un program care sa afiseze suma primelor 10 numere naturale. ( do while)
        public static void Ex9()
        {
            Console.WriteLine("The sum of the first 10 natural numbers is: ");
            int i = 1;
            int sum = 0;
            do
            {
                sum = sum + i;
                i++;
            }
            while (i <= 10);
            Console.WriteLine("{0}", sum);

            Console.WriteLine("==========================================================================================\n");
        }

        //10. Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi. ( do while)

        public static void Ex10()
        {
            int n;
            Console.WriteLine("Enter a number:");
            n = int.Parse(Console.ReadLine());
            int i = 1;
            do
            {
                Console.WriteLine("{0}", i);
                i++;
            }
            while (i < n);

            Console.WriteLine("==========================================================================================\n");
        }

        //11. Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi. ( do while)
        public static void Ex11()
        {
            int n;
            Console.WriteLine("Enter a number:");
            n = int.Parse(Console.ReadLine());
            int i = 3;
            do
            {
                Console.WriteLine("{0}", i);
                i++;
            }
            while (i < n);
            Console.WriteLine("==========================================================================================\n");
        }

        //12. Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi. ( do while)
        public static void Ex12()
        {
            int n;
            Console.WriteLine("Enter a number:");
            n = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;
            do
            {
                sum = sum + i;
                i++;
            }
            while (i < n);
            Console.WriteLine("{0}", sum);
            Console.WriteLine("==========================================================================================\n");
        }

        //13. Afisati cubul primelor 5 numere naturale. ( do while)

        public static void Ex13()
        {
            Console.WriteLine("The cubes of the first 5 natural numbers are: ");
            int i = 1;
            int cube;
            do
            {
                cube = i * i * i;
                Console.WriteLine("{0}", cube);
                i++;
            }
            while (i <= 5);

            Console.WriteLine("==========================================================================================\n");
        }

        //14. Scrieti un program care sa afiseze primele 10 numere naturale. (for)

        public static void Ex14()
        {
            Console.WriteLine("The first 10 natural numbers are: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}", i);
            };
            Console.WriteLine("==========================================================================================\n");
        }

        //15. Scrieti un program care sa afiseze suma primelor 10 numere naturale. (for)
        public static void Ex15()
        {
            Console.WriteLine("The sum of the first 10 natural numbers is: ");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            };
            Console.WriteLine("{0}", sum);
            Console.WriteLine("==========================================================================================\n");
        }

        //16. Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi. (for)
        public static void Ex16()
        {
            int n;
            Console.WriteLine("Write a number:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"The numbers smaller than the number {n} are: ");
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}", i);
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //17. Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi. (for)
        public static void Ex17()
        {
            int n;
            Console.WriteLine("Write a number:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"The numbers from 3 to {n} are: ");
            for (int i = 3; i <= n; i++)
            {
                Console.WriteLine("{0}", i);
            }
            Console.WriteLine("==========================================================================================\n");
        }


        //18. Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi. (for)
        public static void Ex18()
        {
            int n;
            Console.WriteLine("Write a number:");
            n = int.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine($"The sum of the numbers smaller than the number {n} is: ");
            for (int i = 1; i < n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("{0}", sum);

            Console.WriteLine("==========================================================================================\n");
        }

        //19. Afisati cubul primelor 5 numere naturale. (for)
        public static void Ex19()
        {
            Console.WriteLine("The cubes of the first 5 natural numbers are: ");
            int cube;
            for (int i = 1; i <= 5; i++)
            {
                cube = i * i * i;
                Console.WriteLine("{0}", cube);
            };
            Console.WriteLine("==========================================================================================\n");
        }

        //20. Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru. (for)
        public static void Ex20()
        {
            int n;
            Console.WriteLine("Write a number:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i % 2 != 1)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.WriteLine("==========================================================================================\n");
        }


        //21. Afisati al doilea element din urmatorul array: “sun”, “moon”, “clouds”.
        public static void Ex21()
        {
            string[] myStringArray = new string[] { "sun", "moon", "clouds" };

            Console.WriteLine(myStringArray[1]);
            Console.WriteLine("==========================================================================================\n");
        }

        //22. Afisati cherry din urmatorul array: “lemons”, “watermelon”, “cherry”
        public static void Ex22()
        {
            string[] myStringArray = new string[] { "lemons", "waterlemon", "cherry" };
            Console.WriteLine(myStringArray[2]);
            Console.WriteLine("==========================================================================================\n");
        }

        //23. Afisati array-ul in ordine inversa: “mom”, “dad”, “child”.
        public static void Ex23()
        {
            string[] myStringArray = new string[] { "mom", "dad", "child" };
            Array.Reverse(myStringArray);
            for (int i = 0; i < myStringArray.Length; i++)
            {
                Console.WriteLine(myStringArray[i]);
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //24. Afisati array-ul sortat: “mom”, “dad”, “child”.
        public static void Ex24()
        {
            string[] myStringArray = new string[] { "mom", "dad", "child" };
            Array.Sort(myStringArray);
            for (int i = 0; i < myStringArray.Length; i++)
            {
                Console.WriteLine(myStringArray[i]);
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //25. Cititi de la tastatura elementele unui array de marime 5. (string)
        public static void Ex25()
        {
            string[] myStringArray = new string[5];
            int i;

            Console.WriteLine("Scrieti 5 elemente de timp string:\n");
            for (i = 0; i < myStringArray.Length; i++)
            {
                Console.WriteLine("element - {0} :", i);
                myStringArray[i] = Console.ReadLine();
            }

            Console.WriteLine("\nElementele sunt: ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", myStringArray[i]);
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //25. Cititi de la tastatura elementele unui array de marime 5. (int)
        public static void Ex26()
        {
            int[] myIntArray = new int[5];
            int i;

            Console.WriteLine("Scrieti 5 elemente de timp int:\n");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("element - {0} :", i);
                myIntArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nElementele sunt: ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", myIntArray[i]);
            }
        }
    }
}
