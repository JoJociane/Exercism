using System;

public static class Leap
{
    /*
     em cada ano que é uniformemente divisível por 4

    exceto a cada ano que é igualmente divisível por 100

    a menos que o ano também seja igualmente divisível por 400
     
     */

    public static bool IsLeapYear(int year)
    {
        bool valida = false;
        if (year %4 == 0 && (year %100 != 0 || year % 400 ==0))
        {
            valida = true;
        }

        return valida;
    }
}