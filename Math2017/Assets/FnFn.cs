using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FnFn : MonoBehaviour
{

    void Start()
    {
        IEnumerable<float> number = GeneratorNum(5, 20);
        foreach (var item in number)
        {
            print(item);
        }
    }

    IEnumerable<float> GeneratorNum(int x, int y)
    {
        for (int i = x; i <= y; i++)
        {
            yield return i;
        }
    }
}