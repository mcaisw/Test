using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {

    public GameObject whiteMap;
    public GameObject redMap;

	private Vector2 startPos;
	private Vector2 offSetPos;
	private Vector2 nextPos;
	//map 容器
	List<Map> mapList;
    // Use this for initialization
    void Start () {
		startPos = new Vector2 (-3,-3);
		nextPos = startPos;
		offSetPos = new Vector2 (1,1);
		mapList = new List<Map> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (mapList.Count<10)
        {
            CreatMap();
        }
	}

    void CreatMap() {
        Debug.Log("生成map");
		InstantiateMap (0,GetNextPos());
    }

    void DestroyMap() {
        Debug.Log("销毁map");
    }

    private void InstantiateMap(int mapType,Vector2 pos)
    {
        if (mapType==0)
        {
			GameObject newMap = Instantiate (whiteMap,this.transform);
			newMap.transform.position = pos;
			mapList.Add (newMap.GetComponent<Map>());
			AddPos(ref nextPos);
        }
        else
        {

        }
    }

    Vector2 GetNextPos() {
		return nextPos;
    }

	void AddPos(ref Vector2 currentPos){
		currentPos += offSetPos;
	}
}
