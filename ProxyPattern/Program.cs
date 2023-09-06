﻿// See https://aka.ms/new-console-template for more information
using ProxyPattern;
using System;
namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client passing employee with Role Developer to folderproxy");
            Employee employee1 = new Employee("Anurag", "Anurag123", "Developer");
            ProxyFolder folderProxy1 = new ProxyFolder(employee1);
            folderProxy1.PerformOperation();

            Console.WriteLine();

            Console.WriteLine("Client passing employee with Role Manager to folderproxy");
            Employee employee2 = new Employee("Pranaya", "Pranaya123", "Manager");
            ProxyFolder folderProxy2 = new ProxyFolder(employee2);
            folderProxy2.PerformOperation();

            Console.Read();
        }
    }
}
