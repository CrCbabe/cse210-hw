using System;

class Scripture
{
    static Reference chosenReference = new Reference();
    static string chosenScripture = chosenReference.ChooseScripture();
    static string[] _scripture = chosenScripture.Split("~");
    static string _reference = _scripture[0];
    static string _verse = _scripture[1];


    public void Memorize()
    {
        Console.WriteLine($"{_reference}: {_verse}");
        Console.WriteLine("Press Enter to continue, or type 'quit' to finish");
        string _input = Console.ReadLine();
        if (_input == "quit")
        {
            Environment.Exit(0);
        }
        else
        {
            HideWords();
        }
    }

    //fix private void later to appropriate
    private void HideWords()
    {
        Console.WriteLine("Test complete"); //delete this after successful test
        string[] _words = _verse.Split("");
        Word wordProcess = new Word();
        string[] _hide = wordProcess.GetRenderedText(_words);
    }

    private void RenderedText()
    {
        Word renderedText = new Word();
    }

    private void IsCompletelyHidden()
    {
        Environment.Exit(0);
    }
}