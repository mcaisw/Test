using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {
    public int mapType;
    bool removed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (DistanceToPlayer_X()>8&& !removed)
        {
            RemoveThisMap();
        }
	}

	public Vector2 GetPos(){
		return new Vector2(this.transform.position.x,this.transform.position.y);
	}


    float DistanceToPlayer_X() {
        return Player.Instance.transform.position.x - transform.position.x;
    }

    void RemoveThisMap() {
        removed = true;
        Destroy(this.gameObject);
        MapManager.Instance.RemoveTheMap(this);
    }
}
