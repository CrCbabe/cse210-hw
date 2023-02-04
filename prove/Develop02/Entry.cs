using System;
using System.Collections.Generic;

class Entry
{
    public int _index;
    public string _prompt;
    public string _response;
    public string _date;
    public string _entry;

    public Entry()
    {
        JournalEntry();
    }

    static string[] promptList = {
        "What was the strongest emotion I felt today?",
        "How did I see the hand of the Lord in my life today?",
        "How did I see the hand of the Lord in my life today?",
        "What did I do today that I am proud of?",
        "If I could have done something better today, what would it be?",
        "What can I be grateful for today?",
        "Who inspired me today?",
    };
    List<string> _prompts = new List<string>(promptList);


    public string JournalEntry()
    {
        Random rand = new Random();
        _index = rand.Next(_prompts.Count);
        _prompt = _prompts[_index];
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
        _date = DateTime.Now.ToString("mm/dd/yyyy");
        string _entry = ($"{_prompt}: {_response} ({_date})~");
        return _entry;
    }

    internal class ListEntries
    {
        private readonly string _entry;

        public List<string> EntriesList()
        {
            List<string> _entries = new List<string>();
            _entries.Add(_entry);
            return _entries;
        }
    }

    internal static ReadOnlySpan<char> Entries()
    {
        throw new NotImplementedException();
    }
}