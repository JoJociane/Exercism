using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int diferenca = 0;

        if (firstStrand.Length == secondStrand.Length)
        {

            for (int i = 0; i < firstStrand.Length; i++)
            {
                if (firstStrand[i] != secondStrand[i])
                {
                    diferenca++;
                }
            }
        }
        else
        {
            throw new ArgumentException();
        }

        return diferenca;
    }
}