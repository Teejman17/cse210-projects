public class PromptGenerator
{
    public List<string> _promptList = new List<string>()
    {

        "Who was the most interesting person I interacted with today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing new I learned today?",
        "WHat is one thing that I like about myself from today?",
        "If I could travel anywhere in the world, where would I go? What would I do?",
        "Who is one person that influenced me today? How did they influence me?",
        "How am I coming along with my goals? Should I change any of my goals?",
    };

    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }
    // _promptList: List<string>
    // GetPrompt(): string
}