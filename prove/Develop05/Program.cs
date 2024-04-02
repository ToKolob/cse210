using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        MenuSystem menuSystem = new MenuSystem();
        menuSystem.DisplayMenu();
    }
}

