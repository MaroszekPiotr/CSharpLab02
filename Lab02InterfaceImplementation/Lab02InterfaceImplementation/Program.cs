﻿using System;

namespace Lab02InterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik jacek = new Pracownik("Nowak", new DateTime(2020, 11, 07), 5000);
            Pracownik wacek = new Pracownik();
            System.Console.WriteLine(jacek);
        }
    }
}
