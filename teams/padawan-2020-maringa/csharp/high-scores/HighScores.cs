using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public List<int> lista;
    public HighScores(List<int> list)
    {
        lista = list;
    }

    public List<int> Scores()
    {
        return lista;
    }

    public int Latest()
    {
       return lista.Last();
    }

    public int PersonalBest()
    {
        return lista.Max();
    }

    public List<int> PersonalTopThree()
    {
        return lista.OrderByDescending( q=> q).Take(3).ToList();
    }
}