﻿using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());
        
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Equals('p'))
            {
                hasMatch = true;

                int endIndex = jump;

                if (endIndex + i >= text.Length)
                {
                    endIndex = text.Length - i - 1;
                }

                string matchedString = text.Substring(i, endIndex + 1);
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
