﻿using Microsoft.AspNetCore.Components;

namespace BlazorServer.Models
{
    public partial class Counter

    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
