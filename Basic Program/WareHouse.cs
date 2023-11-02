﻿using System;
using System.Threading;

class Warehouse
{
    private int boxCount = 0;

    public void AddBox(int workerId)
    {
        for (int i = 1; i <= 5; i++)
        {
            Thread.Sleep(100); // Simulate the time it takes to add a box
            boxCount++;
            Console.WriteLine($"Worker {workerId} added a box. Total boxes: {boxCount}");
        }
    }
    public int GetTotalBoxes()
    {
       return boxCount;
    }
}