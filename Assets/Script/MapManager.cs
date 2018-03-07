using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {

    public GameObject whiteMap;
    public GameObject redMap;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (true)
        {
            CreatMap();
        }
	}

    void CreatMap() {
        Debug.Log("生成map");
    }

    void DestroyMap() {
        Debug.Log("销毁map");
    }

    private void InstantiateMap(int mapType)
    {
        if (mapType==0)
        {

        }
        else
        {

        }
    }

    Vector2 GetPos() {
        return new Vector2(0,0);
    }
}
