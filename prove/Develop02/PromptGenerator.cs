using System;
using System.Collections.Generic;

namespace JournalProgram
{
    public class PromptGenerator
    {
        private readonly List<string> _prompts;

        public PromptGenerator()
        {
            _prompts = new List<string>
            {
                "What was one thing you are grateful for today",
                "What was one thing you learned today?",
                "Who did you interact with today? Elaborate on the interaction.",
                "Where did you go today and why?",
                "What was your most exciting thought today?"
            };
        }

        public string GetRandomPrompt()
        {
            var random = new Random();
            return _prompts[random.Next(_prompts.Count)];
        }
    }
}