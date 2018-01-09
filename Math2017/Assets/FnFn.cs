using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FnFn : MonoBehaviour
{
    //フィボナッチ数列の近似を黄金比で出力
    void Start()
    {
        int length = 10;
        int number = 1;
        List<int> an = new List<int>();

        for (int i = 0; i < length; i++)
        {
            an.Add(number);
            number = Mathf.RoundToInt(number * 1.618f);
            //ここで重要なのは四捨五入された整数に対して黄金比が適用されている点（実数に対して黄金比を掛けるとズレる）
        }

        foreach (var item in an)
        {
            print(item);
        }
    }
}