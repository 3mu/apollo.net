﻿using System;
using System.Configuration;

namespace Apollo.NetCoreApp.Demo
{
    class Program
    {
        private static readonly string DEFAULT_VALUE = "undefined";
        private static void Main()
        {
            Console.WriteLine("Apollo Config Demo. Please input key to get the value. Input quit to exit.");
            while (true)
            {
                Console.Write("> ");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }
                input = input.Trim();
                if (input.Equals("quit", StringComparison.CurrentCultureIgnoreCase))
                {
                    Environment.Exit(0);
                }

                var value = ConfigurationManager.AppSettings[input] ?? DEFAULT_VALUE;
                var color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Loading key: {0} with value: {1}", input, value);
                Console.ForegroundColor = color;
            }
        }
    }
}