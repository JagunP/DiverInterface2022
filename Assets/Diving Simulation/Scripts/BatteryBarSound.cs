using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryBarSound : MonoBehaviour
{
    public InformationManager iM;
    bool ready=false;
    float delay=5f;
    AudioSource aud;
    bool audioplayed=false;
    // Start is called before the first frame update
    void Start()
    {
        aud=GetComponent<AudioSource>();
        StartCoroutine("Delaythis"); 
    }
    IEnumerator Delaythis()
    {
        yield return new WaitForSeconds(delay);
        ready=true;
    }

    // Update is called once per frame
    void Update(){
        if((iM.GetBatteryLevel() == 20f)||
            (iM.GetBatteryLevel() == 10f) || 
            (iM.GetBatteryLevel() == 3f)){
                aud.Play();
                audioplayed=true;
                // Debug.log("Audio Played");
        }   
    }
}