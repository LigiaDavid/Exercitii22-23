using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii22_23
{
    class Exercitii22
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

            Console.ReadLine();
        }

        //1. Cititi de la tastatura un numar. Verificati daca numarul este egal cu 20. In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!
        public static void Ex1()
        {
            Console.WriteLine("Introduceti un numar:");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int number);

            if (number == 20)
            {
                Console.WriteLine("Numarul tau este egal cu 20!");
            };
            Console.WriteLine("==========================================================================================\n");
        }

        //2. Cititi de la tastatura un cuvant. Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text :” Cuvantul pe care tu l-ai citit este “automation””.
        public static void Ex2()
        {
            Console.WriteLine("Introduceti un cuvant:");
            string i = Console.ReadLine();

            if (i == "automation")
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit este “automation”");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //3. Cititi de la tastatura un character si verificati daca acel character este cifra si in cazul in care este adevarat afisati :”Caracterul  *character* pe care l-ai introdus este cifra!”
        public static void Ex3()
        {
            Console.WriteLine("Introduceti un caracter:");
            string input = Console.ReadLine();
            Char.TryParse(input, out char caracter);

            if (caracter >= '0' && caracter <= '9')
            {
                Console.WriteLine($"Caracterul  {caracter} pe care l-ai introdus este cifra!");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //4. Cititi de la tastatura un numar. In cazul in care este mai mic decat 20, adunati acel numar cu 5 si afisati rezultatul final. Afisati fie noul rezultat, fie numarul.
        public static void Ex4()
        {
            Console.WriteLine("Introduceti un numar:");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int number);

            if (number < 20)
            {
                int sum = number += 5;
                Console.WriteLine($"Rezultatul final este: {sum}");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //5. Cititi de la tastatura un numar.Verificati daca numarul este pozitiv si afisati: “Numarul* numar* este pozitiv”.
        public static void Ex5()
        {
            Console.WriteLine("Introduceti un numar:");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int number);

            if (number > 0)
            {
                Console.WriteLine($"Numarul {number} este pozitiv");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //6. Cititi de la tastatura un numar.Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: “Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar nu afisati nimic.
        public static void Ex6()
        {
            Console.WriteLine("Intoduceti un numar:");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int number);

            if (number < 20 || number > 40)
            {
                Console.WriteLine($"Numarul este mai mic de 20 sau mai mare de 40!");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //7. Cititi de la tastaura un numar. Verificati daca numarul este par. Daca numarul este par afisati :”Numarul *numar* pe care l-ati introdus este par!”. In caz contrar nu afisati nimic
        public static void Ex7()
        {
            Console.WriteLine("Intoduceti un numar:");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int number);

            if (number % 2 != 1)
            {
                Console.WriteLine($"Numarul {number} pe care l-ati introdus este par!");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //8. Cititi de la tastatura un numar. Verificati daca numarul este egal cu 20. In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!”, in caz contrar: “Numarul tau este diferit de 20”.
        public static void Ex8()
        {
            Console.WriteLine("Intoduceti un numar:");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int number);

            if (number == 20)
            {
                Console.WriteLine("Numarul tau este egal cu 20!");
            }
            else
            {
                Console.WriteLine("Numarul tau este diferit de 20");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //9. Cititi de la tastatura un cuvant. Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text :” Cuvantul pe care tu l-ai citit este “automation””. In caz contrar afisati mesajul: “Cuvantul pe care l-ai citit nu este “automation””.
        public static void Ex9()
        {
            Console.WriteLine("Introduceti un cuvant:");
            string i = Console.ReadLine();

            if (i == "automation")
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit este “automation”");
            }
            else
            {
                Console.WriteLine("Cuvantul pe care l-ai citit nu este “automation”");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //10.	Cititi de la tastatura un character si verificati daca acel character este cifra si in cazul in care este adevarat afisati :”Caracterul  *character* pe care l-ai introdus este cifra!”, in caz contrat afisati “Caracterul *character* pe care l-ai introdus nu este cifra.

        public static void Ex10()
        {
            Console.WriteLine("Introduceti un caracter:");
            string input = Console.ReadLine();
            Char.TryParse(input, out char caracter);

            if (caracter >= '0' && caracter <= '9')
            {
                Console.WriteLine($"Caracterul  {caracter} pe care l-ai introdus este cifra!");
            }

            else
            {
                Console.WriteLine($"Caracterul  {caracter} pe care l-ai introdus nu este cifra!");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //11.	Cititi de la tastatura un numar. In cazul in care este mai mic decat 20, adunati acel numar cu 5 si afisati rezultatul final. In caz contrar scadeti numarul cu 5 si afisati rezultatul final.
        public static void Ex11()
        {
            Console.WriteLine("Introduceti un numar:");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int number);

            if (number < 20)
            {
                int sum = number += 5;
                Console.WriteLine($"Rezultatul final este: {sum}");
            }

            else
            {
                int substract = number -= 5;
                Console.WriteLine($"Rezultatul final este: {substract}");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //12.	Cititi de la tastatura un numar. Verificati daca numarul este pozitiv si afisati: “Numarul *numar* este pozitiv”. In caz contrar afisati “Numarul *numar* este negativ!.
        public static void Ex12()
        {
            Console.WriteLine("Introduceti un numar:");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int number);

            if (number >= 0)
            {
                Console.WriteLine($"Numarul {number} este pozitiv");
            }
            else
            {
                Console.WriteLine($"Numarul {number} este negativ");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //13.	Cititi de la tastatura un numar. Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: “Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar afisati: “Numarul este intre 20 si 40!”
        public static void Ex13()
        {
            Console.WriteLine("Intoduceti un numar:");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int number);

            if (number < 20 || number > 40)
            {
                Console.WriteLine($"Numarul este mai mic de 20 sau mai mare de 40!");
            }
            else
            {
                Console.WriteLine("Numarul este intre 20 si 40!");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //14.	Cititi de la tastaura un numar. Verificati daca numarul este par. Daca numarul este par afisati :”Numarul *numar* pe care l’ati introdus este par!”. In caz contrar afisati “Numarul *numar* pe care l’ati introdus este impar!”.
        public static void Ex14()
        {
            Console.WriteLine("Intoduceti un numar:");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int number);

            if (number % 2 != 1)
            {
                Console.WriteLine($"Numarul {number} pe care l-ati introdus este par!");
            }
            else
            {
                Console.WriteLine($" Numarul {number} pe care l-ati introdus este impar!");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //15.	Cititi de la tastatura un caracter. Daca acel caracter este litera afisati mesajul :”Caracterul *caracter* este litera!”. In cazul in care este o cifra afisati mesajul :”Caracterul *caracter* este o cifra!”. In cazul contrar afisati mesajul: “Caracterul *caracter* nu este nici cifra nici litera
        public static void Ex15()
        {
            Console.WriteLine("Introduceti un caracter:");
            string input = Console.ReadLine();
            Char.TryParse(input, out char caracter);

            if (caracter >= 'a' && caracter <= 'z')
            {
                Console.WriteLine($"Caracterul {caracter} este litera!");
            }

            else if (caracter >= '0' && caracter <= '9')
            {
                Console.WriteLine($"Caracterul {caracter} pe care l-ai introdus este o cifra!");
            }

            else
            {
                Console.WriteLine($"Caracterul {caracter} pe care l-ai introdus nu este nici cifra nici litera!");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //16.	Cititi de la tastatura o ora a zilei. In cazul in care ora respectiva este mai mica de 12 afisati: “Buna dimineata!”. Daca ora este mai mica decat 17 afisati mesajul: “Buna ziua!”. In caz contrar afisati mesajul :”Buna seara!”

        public static void Ex16()
        {
            Console.WriteLine("Introduceti o ora:");
            string input = Console.ReadLine();
            TimeSpan.TryParse(input, out TimeSpan time);
            //TimeSpan i = TimeSpan.Parse("12:00");
            TimeSpan i = new TimeSpan(12, 00, 00);
            TimeSpan j = TimeSpan.Parse("17:00");

            if (time < i)
            {
                Console.WriteLine("Buna dimineata!");
            }

            else if (time >= i && time < j)
            {
                Console.WriteLine("Buna ziua!");
            }

            else
            {
                Console.WriteLine("Buna seara!");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //17.	Cititi de la tastatura o inaltime a unei persoane in cm si afisati: daca inaltimea este <150 cm afisati: “Aceasta persoana este miniona”, daca inaltimea este intre 150 si 165, afisati mesajul: “Aceasta persoana este mica de statura”. Daca inaltimea este intre 165 si <195 afisati mesajul:”Aceasta persoana este inalta”. In caz contrar afisati :”Aceasta persoana este foarte inalta”.
        public static void Ex17()
        {
            Console.WriteLine("Inaltimea persoanei este:");
            float inaltimea;
            inaltimea = int.Parse(Console.ReadLine());

            if (inaltimea < 150.0)
            {
                Console.WriteLine("Aceasta persoana este miniona.");
            }
            else if ((inaltimea >= 150.0) && (inaltimea <= 165.0))
            {
                Console.WriteLine("Aceasta persoana este mica de statura.");
            }
            else if ((inaltimea > 165.0) && (inaltimea <= 195))
            {
                Console.WriteLine("Aceasta persoana este inalta.");
            }
            else
            {
                Console.WriteLine("Aceasta persoana este foarte inalta.");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //18. Cititi 3 numere de la tastatura si afisati cel mai mare numar.
        public static void Ex18()
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Scrieti primul numar:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Scrieti al 2-lea numar:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Scrieti al 3-lea numar:");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine($"{a} este numarul cel mai mare");
                }
                else
                {
                    Console.WriteLine($"{c} este numarul cel mai mare");
                }
            }
            else if (b > c)
            {
                Console.WriteLine($"{b} este numarul cel mai mare");
            }
            else
            {
                Console.WriteLine($"{c} este numarul cel mai mare");
            }
            Console.WriteLine("==========================================================================================\n");
        }

        //19. Cititi de la tastatura 2 numere. Faceti un calculator care sa accepte operatiile +,-,*,/ si sa afiseze rezultatul: 

        public static void Ex19()
        {
            int a;
            int b;
            Console.WriteLine("Scrieti primul numar:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Scrieti al 2-lea numar:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Scrieti un operator (+, -, *, /):");
            string op = Console.ReadLine();
            if (op == "+")
            {
                int sum = a + b;
                Console.WriteLine($"{a} + {b} = {sum}");
            }
            else if (op == "-")
            {
                int subtract = a - b;
                Console.WriteLine($"{a} - {b} = {subtract}");
            }
            else if (op == "*")
            {
                int multiply = a * b;
                Console.WriteLine($"{a} * {b} = {multiply}");
            }
            else
            {
                int divide = a / b;
                Console.WriteLine($"{a} / {b} = {divide}");
            }

        }
    }
}
