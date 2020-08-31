using System;

public static class Leap
{
    /*
     em cada ano que � uniformemente divis�vel por 4

    exceto a cada ano que � igualmente divis�vel por 100

    a menos que o ano tamb�m seja igualmente divis�vel por 400
     
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