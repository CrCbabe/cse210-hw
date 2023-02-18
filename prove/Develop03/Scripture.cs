using System;
using System.Text.RegularExpressions;

class Scripture
{
    static Reference chosenReference = new Reference();
    static string chosenScripture = chosenReference.ChooseScripture();
    static string[] _scripture = chosenScripture.Split("~");
    static string _reference = _scripture[0];
    static string _verse = _scripture[1];

    public Scripture()
    {
        Memorize();
    }

    public void Memorize()
    {
        Console.WriteLine($"{_reference}: {_verse}");
        bool isHidden = IsCompletelyHidden(_verse);
        if (isHidden == false)
        {
            Console.WriteLine("Press Enter to continue, or type 'quit' to finish");
            string _input = Console.ReadLine();
            if (_input == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                HideWords();
            }
        }
        else
        {
            Environment.Exit(0);
        }
    }

    //fix private void later to appropriate
    private void HideWords()
    {
        string[] _words = _verse.Split("");
        Word wordProcess = new Word();
        string[] _hide = wordProcess.GetRenderedText(_words);

    }

    // private void RenderedText()
    // {
    //     Word renderedText = new Word();
    // }

    private static bool IsCompletelyHidden(String verse)
    {
        return Regex.IsMatch(verse, @"^[a-zA-Z]+$");
    }
}