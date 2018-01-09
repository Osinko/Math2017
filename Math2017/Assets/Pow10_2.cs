using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;

public class Pow10_2 : MonoBehaviour
{

    void Start()
    {
        IEnumerable<float> powNumber = GeneratorNumPow();

        foreach (var item in powNumber)
        {
            print(item);
        }

        string folder = Application.dataPath;    //これだけでunityの実行ファイルがあるフォルダがわかる
        ClassSaveText(folder, @"\PowList.txt", powNumber);
    }

    private IEnumerable<float> GeneratorNumPow()
    {
        int length = 10;
        for (float i = 0; i < length; i++)
        {
            yield return Mathf.Pow(10, Mathf.Pow(1f / 2f, i));  //10^(1/2)^n
        }
    }
    //資料：StreamWriter クラス (System.IO)
    //http://msdn.microsoft.com/ja-jp/library/system.io.streamwriter(v=vs.110).aspx

    //テキストファイルとしてセーブ
    public void SaveText(string fileFolder, string filename, string[] dataStr)
    {
        using (StreamWriter w = new StreamWriter(fileFolder + filename, false, System.Text.Encoding.GetEncoding("shift_jis")))
        {
            foreach (var item in dataStr)
            {
                w.WriteLine(item);
            }
        }
    }

    //Classセーバー
    private void ClassSaveText(string folder, string name, IEnumerable data)
    {
        List<string> strList = new List<string>();
        foreach (var item in data)
        {
            strList.Add(item.ToString());
        }
        SaveText(folder, name, strList.ToArray());
    }
}