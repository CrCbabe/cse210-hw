using System;

class Scripture
{
    static Reference refer = new Reference();
    static string chosenScripture = refer.ChooseScripture();
    static string[] _scripture = chosenScripture.Split("~");
    static string _reference = _scripture[0];
    static string _verse = _scripture[1];
    Verse verse = new Verse(_verse);


    public void DisplayScripture()
    {
        Console.WriteLine($"\n{_reference}");
        verse.DisplayVerse();
    }

    public void HideWords()
    {
        verse.HideWords();
    }
}