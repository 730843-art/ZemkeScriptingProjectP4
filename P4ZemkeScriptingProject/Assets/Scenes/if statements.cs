using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifstatements : MonoBehaviour
{

    // creating variables 4 script
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0F;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();

        }
        coffeeTemperature -= Time.deltaTime * 5f;
    }
    void TemperatureTest()
    {
        //if cof tep is > than hot temp 
        if (coffeeTemperature >= hotLimitTemperature)
        {
            print("coffee is to hot.");
        }
        else if (coffeeTemperature <= coldLimitTemperature)
        {
            print("coffee is to cold.");

        }

        else
        {

            print("coffee is just right.");



        }
    }




}
   

