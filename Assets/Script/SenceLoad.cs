using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SenceLoad : MonoBehaviour {


    private void Awake()
    {
    }
    // Use this for initialization
    void Start () {
		
	}

    public void LoadGame() {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
