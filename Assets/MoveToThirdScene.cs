﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveToThirdScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void play()
    {
        SceneManager.LoadScene("MainGame");
    }
}
