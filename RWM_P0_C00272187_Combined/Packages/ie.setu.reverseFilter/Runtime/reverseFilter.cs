using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ReverseFilter
{
    public static int[] reverse(int[] xs)
    {
        for (int i = 0; i < xs.Length / 2; i++)
        {
            int temp = xs[i];
            xs[i] = xs[xs.Length - 1 - i];
            xs[xs.Length - 1 - i] = temp;
        }
        return xs;
    }
}