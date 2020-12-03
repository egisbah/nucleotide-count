using System;
using System.Collections.Generic;




public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {

        Dictionary<char, int> IDictionary = new Dictionary<char, int> { { 'A', 0 }, { 'C', 0 }, { 'G', 0 }, { 'T', 0 }, };
        for (int i = 0; i < sequence.Length; i++)
        {
            char Key = sequence[i];
            try
            {
                IDictionary[Key]++;
            }
            catch (System.ArgumentException e)
            {
                Console.WriteLine(e);
                continue;
            }


    }
        return IDictionary;
    }
}
