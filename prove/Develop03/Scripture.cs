using System;

class Scripture
{
    static Reference chosenReference = new Reference();
    static string chosenScripture = chosenReference.ChooseScripture();
    static string[] _scripture = chosenScripture.Split("~");
    static string _reference = _scripture[0];
    static string _verse = _scripture[1];

    public void MemorizeScripture()
    {
        Console.WriteLine("");
    }

    //fix private void later to appropriate
    private void HideWords()
    {

    }

    private void GetRenderedText()
    {
        string renderedText = new Word.();
    }

    private void IsCompletelyHidden()
    {
        Environment.Exit(0);
    }
}