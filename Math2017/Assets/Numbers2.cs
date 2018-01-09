using UnityEngine;
using System.Collections;
using System.Linq;

public class Numbers2 : MonoBehaviour
{
    void Start()
    {
        float[] quary = SequenceDiff(1, 2, 5);
        //float[] quary = SequenceRatio (1, 2, 5);
        foreach (var item in quary)
        {
            print(item);
        }
    }

    //等差数列
    float[] SequenceDiff(float a, float d, int count)
    {
        float[] quary = Enumerable.Range(1, count).Select(n => a + (n - 1) * d).ToArray();
        return quary;
    }

    //等比数列
    float[] SequenceRatio(float a, float r, int count)
    {
        float[] quary = Enumerable.Range(1, count).Select(n => a * Mathf.Pow(r, n)).ToArray();
        return quary;
    }
}