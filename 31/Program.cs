﻿// This program generates email addresses for corporate and external contacts, using a default domain for corporate emails and a specified domain for external contacts.
using System;

class Program
{
    static void Main()
    {
        string[,] corporate = 
        {
            {"Robert", "Bavin"}, {"Simon", "Bright"},
            {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
            {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
        };

        string[,] external = 
        {
            {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
            {"Shay", "Lawrence"}, {"Daren", "Valdes"}
        };

        string externalDomain = "hayworth.com";

        for (int i = 0; i < corporate.GetLength(0); i++) 
        {
            DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);
        }

        for (int i = 0; i < external.GetLength(0); i++) 
        {
            DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
        }
    }

    static void DisplayEmail(string first, string last, string domain = "contoso.com") 
    {
        string email = first.Substring(0, 2) + last;
        email = email.ToLower();
        Console.WriteLine($"{email}@{domain}");
    }
}
