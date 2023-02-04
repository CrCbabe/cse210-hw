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
    }

    public List<string> _prompts = new List<string>();
    [
        _prompts.Add("What was the strongest emotion I felt today?"),
        _prompts.Add("How did I see the hand of the Lord in my life today?"),
        _prompts.Add("What did I do today that I am proud of?"),
        _prompts.Add("If I could have done something better today, what would it be?"),
        _prompts.Add("What can I be grateful for today?"),
        _prompts.Add("Who inspired me today?"),
    ];
//place these in constructor
    public Entry(int _index, string _prompt, string _response, string _date)
    {
        Random rand = new Random();
        _index = rand.Next(_prompts.Count);
        _prompt = Console.WriteLine(_prompts[_index]);
        _response = Console.ReadLine();
        _date = DateTime.Now.ToString("mm/dd/yyyy");
        string _entry = ($"{_prompt}: {_response} ({_date})~");
        ListEntries();
    }

    internal class ListEntries
    {
        private readonly string _entry;

        public List<string> Entries()
        {
            List<string> _entries = new List<string>();
            _entries.Add(_entry);
            return _entries;
        }
    }

    internal static ReadOnlySpan<char> ListEntries()
    {
        throw new NotImplementedException();
    }
}