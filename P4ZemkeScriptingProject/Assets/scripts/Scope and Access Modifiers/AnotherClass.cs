using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{


    public int apples = 5;

    public int bannanas = 10;

    private int stapler;

    private int sellotape;


    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

    }





    public void FriutMachine(int a, int b)
    {
        int answer;
        answer = a + b;

       Debug.Log("Friut total is:" + answer);
    }

    private void OfficeSort(int a, int b)
    {

        int answer;
        answer = a + b;

        Debug.Log("Office susplies total:" + answer);

    }



}





