using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Arrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] intArray = new int[10];
        //Debug.Log(intArray[10]);
        //Debug.Log(intArray[5]);
        foreach (int i in intArray)
        {
            intArray[i] = 2;
            //Debug.Log(intArray[i]);
        }

        //Debug.Log(intArray[0]);

        List<string> stringList = new List<string>();
        stringList.Add("john1");
        stringList.Add("john2");
        stringList.Add("john3");
        stringList.Add("john1");
        stringList.Add("john1");
        DisplayNames(stringList);
        RemoveName( "john1" ,stringList);
        DisplayNames(stringList);
    }
    public static void RemoveName(string name, List<string>inputList)
    {
     //inputList.Remove(name);
     while (inputList.IndexOf(name) != -1)
        {
            inputList.Remove(name);
        }
       
    }
    public static void DisplayNames(List<string> inputList)
    {
        foreach (string str in inputList)
        {

        Debug.Log(str); 
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
