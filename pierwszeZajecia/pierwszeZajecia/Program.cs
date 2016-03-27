using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwszeZajecia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dwa podstawowe typy:
            string imie; // zmienna typu string, przechowuje tekst. 
            int wiek; // zmienna typu int, przechowuje liczby calkowite.

            // Wczytywanie danych od uzytkownika:
            imie = Console.ReadLine();
            wiek = int.Parse(Console.ReadLine()); // Console.ReadLine() wczytuje dane typu string, dlatego nalezy zmienic ich typ na int przy pomocy "int.Parse()"

            // Wyswietlanie tekstu w konsoli:
            Console.WriteLine("Hello .NET World!");

            // Wyswietlanie zmiennych w konsoli:
            string world = "Hello .NET World!"; //naszym zmiennym mozemy przypisywac wartosc rowniez w momencie ich tworzenia
            Console.WriteLine(world);
            Console.WriteLine("Witaj, " + imie);
            Console.WriteLine("Masz " + wiek + " lat");

            // Do sterowania naszym programem potrzebujemy instrukcji warunkowych, oraz wartosci logicznch.
            // Operatory porównawcze, zwracają wartosci logiczne "true" lub "false":
            // a > b  -> zwraca "true", gdy a jest większe od b.
            // a >= b -> zwraca "true", gdy a jest większe lub równe b.
            // a < b  -> zwraca "true", gdy a jest mniejsze od b.
            // a <= b -> zwraca "true", gdy a jest mniejsze lub równe b.
            // a == b -> zwraca "true", gdy a jest rowne b. Nalezy zauwazyc, ze w przypadku operatora porownawczego nalezy uzywac dowch znakow rownosci.
            // a != b -> zwraca "true", gdy a jest rozne od b.
            // w innym przypadku operatory te zwracaja wartosc "false"
            int a = 5;
            int b = 3;

            // Podstawowa skladnia instrukcji warunkowej, wyglada nastepujaco:
            if (a > b)
            {
                // ten kod zostanie wykonany, gdyz wartosc logiczna warunku wynosi "true"
            }

            // Gdy chcemy wykonac inny kod w przypadku gdy warunek nie zostal spelniony, musimy uzyc "else"
            if (a == b)
            {
                // w tym przypadku ten kod nie zostanie wykonany
            }
            else
            {
                // poniewaz wartosc logiczna wyrazenia wyonosi "false", program zostanie przekierowany w to miejsce
            }

            // Istnieje mozliwosc uzycia kolejnej instrukcji warunkowej, w przypadku gdy pierwszy warunek nie zostal spelniony:
            if (a <= b)
            {
                // ten kod znow nie zostanie wykonany.
            }
            else if (a >= b)
            {
                // poniewaz drugi warunek jest prawdziwy, zostanie wykonany ten kod.
            }
            //else
            //{
            // po instrukcji else if, mozna dodac blok kodu "else", jest to jednak opcjonalne.
            //}

            // W przypadku gdybysmy chcieli sprawdzic duzo warunkow ze znanymi wczesniej wartosciami, mozna uzyc instrukcji "switch":
            switch (imie)
            {
                case "Pierwsze":
                    //gdy zmienna imie bedzie miala wartosc "Pierwsze", zostanie wykonany ten kod.
                    Console.WriteLine("Czesc pierwszy!");
                    break; // slowo "break" jest wymagane, oddziela on przypadki znajdujace sie w switchu.

                case "Drugie":
                    //w tym miejscu mozna oczywiscie dodawac dowolna ilosc kodu, np.:
                    Console.WriteLine("Czesc drugi! Jaka jest twoja ulubiona liczba?");
                    int liczba = int.Parse(Console.ReadLine());

                    if (liczba < 0)
                    {
                        Console.WriteLine("Widze, ze lubisz liczby ujemne");
                    }
                    else if (liczba >= 0)
                    {
                        Console.WriteLine("Liczby nieujemne nie sa ujemne! ;)");
                    }
                    break;

                default:
                    //ten kod zostanie wykonany gdy nasza zmienna nie przyjmie zadnej przewidzianej przez nas wartosci
                    //podobnie jak "else", slowo "default" jest opcjonalne.
                    break;
            }

            // Aby zapobiec wylaczeniu konsoli na koncu programu, mozemy uzyc nastepujacej linijki
            Console.ReadKey(); // lub Console.ReadLine();
            // nalezy jednak pamietac, aby znajdowala sie wewnatrz bloku kodu (oznaczonych klamrami {}) naszej funkcji Main
        }
    }
}
