using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> AuthorList = new List<string>();
        string[] authors = { "Mike Gold", "Don Box",
                        "Sundar Lal", "Neel Beniwal" };
        AuthorList.AddRange(authors);
        Console.WriteLine(AuthorList);
    }
}