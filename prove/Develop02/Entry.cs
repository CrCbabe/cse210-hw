using System;
using System.Collections.Generic;

class Entry
{
    public int index;
    public string prompt;
    public string response;
    public string date;

    public List<string> prompts = new List<string>();
    [
        prompts.Add("What was the strongest emotion I felt today?"),
        prompts.Add("How did I see the hand of the Lord in my life today?"),
        prompts.Add("What did I do today that I am proud of?"),
        prompts.Add("If I could have done something better today, what would it be?"),
        prompts.Add("What can I be grateful for today?"),
        prompts.Add("Who inspired me today?"),
    ];

    index = Random.Next(prompts.Count);
    prompt = Console.WriteLine(prompts[index]);
    response = Console.ReadLine();
    date = DateTime.Now.ToString("mm/dd/yyyy");
    string entry = ($"{prompt}: {response} ({date})~");
    public void ListEntries()
    {
        List<string> entries = new List<string>();
        entries.Add(entry);
        return entries;
    }
}