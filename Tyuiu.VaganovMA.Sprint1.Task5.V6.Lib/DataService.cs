﻿namespace Tyuiu.VaganovMA.Sprint1.Task5.V6.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task5V6
{
    public int Calculate(int k)
    {
       return(k-1)%7+1;
    }
}

