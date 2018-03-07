using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour {

    float   gapTime=0.3f;
    bool    doubleHit = false; 
    int     tapTimes;
    float   elapsedTimes;
    bool    countTimes;
    bool    quickClick;

    // Use this for initialization
    void Start () {
        quickClick = true;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)&& gapTime>0) {
            tapTimes++;
            countTimes = true;
        }
        
        if (countTimes&&gapTime > 0)
        {
            gapTime -= Time.deltaTime;
        }

        if (gapTime<=0)
        {
            countTimes = false;
        }

    }

    private void LateUpdate()
    {
        if (gapTime<=0)
        {
            Debug.Log(tapTimes);
            tapTimes = 0;
            gapTime = 0.3f;
        }
    }
}
