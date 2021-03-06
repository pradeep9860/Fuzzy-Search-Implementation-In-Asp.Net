﻿using FuzzySearch.AspNetCore.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fuzzy_search_Demo
{
    class Program
	{
        static void Main(string[] args)
        {
            List<string> l = new List<string>
            {
                "ant",
                "aunt",
                "Sam",
                "Samantha" ,
                "clozapine",
                "olanzapine" ,
                "annt",
                "volmax" ,
                "toradol",
                "at" ,
                "kitten",
                "sitting",
                "Hello World"
            };

            Console.WriteLine("\n\n\n---------------------------------------------------------------");
            Console.WriteLine("All Items in List");
            foreach (string a in l)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine("\n\n\nEnter Search Term to search on the list");
            var searchTerm = Console.ReadLine();
             
            var searchedString = l.Where(x => searchTerm.IsFuzzySimilar(x, 2, FuzzySearch.AspNetCore.FuzzyAlgorithm.DamerauLevenshteinDistance));


            Console.WriteLine("\n\n\n---------------------------------------------------------------");

            if(searchedString.Count() > 0)
            {
                Console.WriteLine($"Fuzzy search result for '{searchTerm}' is : ");
                foreach (var item in searchedString)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine($"No result found for search term '{searchTerm}'.");
            }
           

            Console.WriteLine("\n\n\n==========Enter any key to exit============");
            Console.ReadKey();   
        }

	} 
}