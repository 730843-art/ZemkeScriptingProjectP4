using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{

    int myInt = 36;s

    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);
    }
    int MultiplyByTwo(int number)
    {
        myInt result;
        result = number * 2;
        return result;
    }

// Update is called once per frame
void Update()
    {
        
    }

//thisis a function