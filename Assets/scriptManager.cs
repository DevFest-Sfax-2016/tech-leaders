using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class scriptManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.Save();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
     public void play()
    {
        SceneManager.LoadScene("SecondScene");
    }
    public void quit()
    {
        Application.Quit();
    }
}
