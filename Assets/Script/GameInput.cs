using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour {

    float   gapTime=0.3f;
    int     clickTimes;
    bool    downMouse;

    bool responseMouseDown;
    // Use this for initialization

    public static GameInput Instance;


    void Start () {
        responseMouseDown = true;
        Instance = this;
    }



   
    private void Update()
    {
        if (GameManager.Instance.Failed)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (gapTime > 0)
            {
                clickTimes++;
                downMouse = true;
            }
        }
        if (downMouse)
        {
            gapTime -= Time.deltaTime;
        }

        if (gapTime <= 0)
        {
            if (clickTimes > 1)
            {
                //Debug.Log("双击");
                responseMouseDown = false;
                //跳
                Player.Instance.Jump(GetNextTwoJumpPos(), Player.Instance.jumpPower, Player.Instance.numJumps, Player.Instance.duration, Player.Instance.snapping);
            }
            else
            {
                //Debug.Log("单击");
                responseMouseDown = false;
                //跳
                Player.Instance.Jump(GetNextJumpPos(), Player.Instance.jumpPower, Player.Instance.numJumps, Player.Instance.duration, Player.Instance.snapping);
            }
            clickTimes = 0;
            downMouse = false;
            gapTime = 0.3f;
        }
    }

    public Vector3 GetNextJumpPos() {
        return Player.Instance.transform.position + new Vector3(1,1,0);
    }

    public Vector3 GetNextTwoJumpPos() {
        return Player.Instance.transform.position + new Vector3(2, 2, 0);
    }

    public void PlayerCanJump() {
        responseMouseDown = true;
    }
}
