using Microsoft.AspNetCore.Components;

namespace BlazorServer.Models
{
    public class CounterBase : ComponentBase
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
