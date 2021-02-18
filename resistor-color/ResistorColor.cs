﻿using System;

public static class ResistorColor
{
    private static readonly string[] _colors =
        {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
    
    public static int ColorCode(string color)
    {
        return Array.FindIndex(_colors, s => s == color);
    }

    public static string[] Colors()
    {
        return _colors;
    }
}