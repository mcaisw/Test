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

    float   jumpPower=1;
    int     numJumps=1;
    float   duration = 0.3f;
    bool    snapping=false;

    bool responseMouseDown;
    // Use this for initialization

    public static GameInput Instance;
    void Start () {
        quickClick = true;
        responseMouseDown = true;
        Instance = this;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)&& responseMouseDown)
        {
            responseMouseDown = false;
            Player.Instance.Jump(GetNextJumpPos(), jumpPower, numJumps, duration, snapping);
        }
    }

    public Vector3 GetNextJumpPos() {
        return Player.Instance.transform.position + new Vector3(1,1,0);
    }


    public void PlayerCanJump() {
        responseMouseDown = true;
    }
}
