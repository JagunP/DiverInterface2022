using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryBarBlinking : MonoBehaviour
{
    double rep  = 1f;
    public InformationManager iM;
    // Start is called before the first frame update
    void Start()
    {
        // invokeRepeating("SliderBlink", 0f, rep);
    }

    void invokeRepeating(){

    }
    // Update is called once per frame
    void Update(){   
        if(iM.GetBatteryLevel() == 20){
            rep = 1f;
        } 
        if(iM.GetBatteryLevel() == 10){
            rep = 0.5;
        }  
        if(iM.GetBatteryLevel() == 3){
            rep = 0.3f;
        }
        invokeRepeating("SliderBlink", 0f, rep);
    }
}
