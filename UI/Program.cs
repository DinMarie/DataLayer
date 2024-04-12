// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;
using DataLayer;
using BussinessLogic;

public class Program
{
    static void Main(string[] args)
    {
        GroupInfo groupList = new GroupInfo();

        Console.WriteLine("Enter a Group Name: ");
        Console.WriteLine();
        string Name = Console.ReadLine();

        GroupVerifty DataLayer = new GroupVerfiy();
        bool result = DataLayer.VerifyGroup(Name);

        if (result)
        {
            Console.WriteLine();
            Console.WriteLine("Group Profile Found");

        }
        else
        {
            Console.WriteLine() ;
            Console.WriteLine("Something Wrong!");

            return;
        }
        Console.WriteLine();
        Console.WriteLine("Welcome to WikiGroup Information Site");
        Console.WriteLine();
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Choice a Group: ");
            Console.WriteLine();
            Console.WriteLine("1. BTS");
            Console.WriteLine("2. TXT");
            Console.WriteLine("3. SEVENTEEN");
            Console.WriteLine("4. TWICE");
            Console.WriteLine("5. BLACKPINK");
            Console.WriteLine();
            Console.WriteLine("Enter Your Choice Group: ");

            string choices = Console.ReadLine();

            switch (choices)
            {
                case "1":
                    Console.WriteLine();
                    Profile.DisplayGroup(groupList.groupList[0]);
                    return;
                case "2":
                    Console.WriteLine();
                    Profile.DisplayGroup(groupList.groupList[1]);
                    return;
                case "3":
                    Console.WriteLine();
                    Profile.DisplayGroup(groupList.groupList[2]);
                    return;
                case "4":
                    Console.WriteLine();
                    Profile.DisplayGroup(groupList.groupList[3]);
                    return;
                case "5":
                    Console.WriteLine();
                    Profile.DisplayGroup(groupList.groupList[4]);
                    return;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
