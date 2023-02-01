using System;
using System.Collections.Generic;

class Entry
{
    public List<string> prompts =
        [
            "What was the strongest emotion I felt today?",
            "How did I see the hand of the Lord in my life today?",
            "What did I do today that I am proud of?",
            "If I could have done something better today, what would it be?",
            "What can I be grateful for today?", "Who inspired me today?"
        ];
    var random = new Random();
    int index = random.Next(prompts.Count);
    public string prompt = Console.WriteLine(prompts[index]);
    public string response = Console.ReadLine();

}