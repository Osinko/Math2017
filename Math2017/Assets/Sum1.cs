using UnityEngine;
using System.Collections;

public class Sum1 : MonoBehaviour
{
    public enum Function
    {
        Linear,
        Gravity,
    }

    public Function function;

    delegate float FunctionDelegate(float x);

    FunctionDelegate[] FunctionDelegates = {
        Linear,
        Gravity,
    };

    void Start()
    {
        FunctionDelegate f = FunctionDelegates[(int)function];
        print(f(2));
    }

    static float Linear(float dt)
    {
        return 1f * dt;
    }

    static float Gravity(float dt)
    {
        return 9.8f * dt;
    }
}