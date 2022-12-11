using System;

namespace GeneratePassword_Example
{
    class Program
    {

        static void Main(string[] args)
        {
            int option;
            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("| PASSWORT-GENERATOR                 |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("| Wählen Sie eine Option             |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("| 1. 10 stellige passwort             |");
                Console.WriteLine("| 2. 20 stellige passwort            |");
                Console.WriteLine("| 3. 30 stellige passwort            |");
                Console.WriteLine("| 4. Verlassen                       |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("--------------------------------------");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Random rnd_1 = new Random();
                        string buchstaben_1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                        string zahl_1 = "1234567890";
                        string mach_1 = "";
                        for (int i = 0; i < 5; i++)
                        {
                            mach_1 += buchstaben_1[rnd_1.Next(buchstaben_1.Length)];
                            mach_1 += zahl_1[rnd_1.Next(zahl_1.Length)];
                        }
                        Console.WriteLine("\n Ihr 10 stellige Passwort wird generiert......");
                        Console.WriteLine("\n IHR 10 stellige passwort lautet: " + mach_1);
                        break;

                    case 2:
                        Random rnd_2 = new Random();
                        string buchstaben_2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                        string zahl_2 = "1234567890";
                        string mach_2 = "";
                        for (int i = 0; i < 10; i++)
                        {
                            mach_2 += buchstaben_2[rnd_2.Next(buchstaben_2.Length)];
                            mach_2 += zahl_2[rnd_2.Next(zahl_2.Length)];
                        }
                        Console.WriteLine("\n Ihr 20 stellige Passwort wird generiert......");
                        Console.WriteLine("\n IHR 20 stellige passwort lautet: " + mach_2);
                        break;

                    case 3:
                        Random rnd_3 = new Random();
                        string buchstaben_3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                        string zahl_3 = "1234567890";
                        string mach_3 = "";
                        for (int i = 0; i < 15; i++)
                        {
                            mach_3 += buchstaben_3[rnd_3.Next(buchstaben_3.Length)];
                            mach_3 += zahl_3[rnd_3.Next(zahl_3.Length)];
                        }
                        Console.WriteLine("\n Ihr 30 stellige Passwort wird generiert......");
                        Console.WriteLine("\n IHR 30 stellige passwort lautet: " + mach_3);
                        break;

                    case 4:
                        Console.WriteLine("Tschüss!");
                        break;

                    default:
                        Console.WriteLine("Bitte wählen Sie die richtige Option");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}