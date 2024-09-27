using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortFilter : MonoBehaviour
{
    public static int[] sort(int[] list)
    {
        int n = list.Length;

        //Traverse through all of the array elements
        for (int i = 0; i < n - 1; i++)
        {
            //Find the smallest element in the unsorted part of the array
            int smallest = i;
            for (int iter = i + 1; iter < n; iter++)
            {
                if (list[iter] < list[smallest])
                {
                    smallest = iter;
                }
            }

            //Swap the found smallest element with the first element
            int temp = list[smallest];
            list[smallest] = list[i];
            list[i] = temp;
        }

        return list;
    }
}