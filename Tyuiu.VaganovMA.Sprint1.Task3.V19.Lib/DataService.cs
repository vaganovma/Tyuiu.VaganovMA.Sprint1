﻿namespace Tyuiu.VaganovMA.Sprint1.Task3.V19.Lib;

using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task3V19
{
    public bool ElephCanMove(double x1, double x2, double y1, double y2)
    {
        if (x1 != x2 && y1 != y2)
        {
            return true;
        }
        return false;
    }
}

