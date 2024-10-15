using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //test_subtract();
        character_string_test();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void test()
    {
        {
            int x = 0;
            while (x < 10)
            {
                Debug.Log(x);
                x++;
            }
        }
    }

    public void test_add()
    {
        for(int x = 0; x < 10; x += 2)
        {
            Debug.Log(x);
        }
    }


    public void test_subtract()
    {
        for (int x = 10; x > 0; x -= 2)
        {
            Debug.Log(x);
        }
    }

    public void character_string_test()
    {
        char c = 'a'; 
        string str_0 = "poop";
        string str_1 = "boink";
        Debug.Log(str_0.Length);
        Debug.Log(str_0[0]);
        Debug.Log(str_0 + " " + str_1);
    }
}