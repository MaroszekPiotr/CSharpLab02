using System;

namespace Lab02InterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik jacek = new Pracownik("Nowak   ", new DateTime(2020, 11, 09), 5000m);
            Pracownik wacek = new Pracownik();
            wacek.DataZatrudnienia = new DateTime(2020, 11, 09);
            wacek.Wynagrodzenie = 8000m;
            System.Console.WriteLine(jacek);
        }
    }
}
