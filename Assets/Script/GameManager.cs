using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {
    public GameObject Canvas;




    public static GameManager Instance;
    bool failed;

    public bool Failed {
        get { return failed; }
        set { failed = value; }
    }

	// Use this for initialization
	void Start () {
        Instance = this;
        Canvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnceAgain()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        Failed = false;
    }

    public void CallFailedUi() {
        Canvas.SetActive(true);
        failed= true;
    }

}
