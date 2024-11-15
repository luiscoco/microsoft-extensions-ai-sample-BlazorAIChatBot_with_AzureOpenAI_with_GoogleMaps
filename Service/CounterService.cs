using System;

namespace BlazorAIChatBot_with_AzureOpenAI.Service
{
    public class CounterService
    {
        public int CurrentCount { get; private set; } = 0;

        // Event to notify when the count changes
        public event Action? OnCountChanged;

        public void IncrementCount()
        {
            CurrentCount++;
            OnCountChanged?.Invoke(); // Directly raise the event
        }
    }
}
