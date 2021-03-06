﻿using UnityEngine;
using System.Collections;

public class SwitchContinue : MonoBehaviour
{
    //優先順位の低い文字を検索する
    void Start()
    {
        //括弧で囲まれると優先順位は上がるとする
        string str = "B(AC(1A))CB(57A6)";
        int pos = 0;
        int nest = 0;
        int priority = 0;
        int lowPriority = 3;

        //for文に対してcontinue;はここに来る
        for (int i = 0; i < str.Length; i++)
        {
            switch (str[i])
            {
                case 'A': priority = 1; break;      //switch_case文に対してのbreak;
                case 'B': priority = 2; break;
                case 'C': priority = 3; break;
                case '(': nest++; continue;
                case ')': nest--; continue;
                default: continue;                  //for文に対してのcontinue;
            }

            //switch_case文に対してのbreak;はここに来る
            if (nest == 0 && priority <= lowPriority)
            {
                lowPriority = priority;
                pos = i;
            }
        }

        print(string.Format("配列位置：{0}　の文字：{1}", pos, str[pos]));
    }
}
