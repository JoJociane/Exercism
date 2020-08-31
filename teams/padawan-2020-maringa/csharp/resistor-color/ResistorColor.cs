using System;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        var list = Colors(); int cor = -1;
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] == color)
                cor = i;
        }
        return cor;
    }

    public static string[] Colors()
    {
         return new [] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        
    }
}