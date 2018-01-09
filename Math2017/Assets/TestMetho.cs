using UnityEngine;
using System.Collections;

public class TestMetho : MonoBehaviour
{

    void Start()
    {

        int val = 123;
        int[] valList = { 456, 789 };

        Method(val, valList);

        print(val);
        print(valList[0]);
        print(valList[1]);
    }

    void Method(int val, int[] valList)
    {
        val = 000;
        valList[0] = 000;
    }
}
