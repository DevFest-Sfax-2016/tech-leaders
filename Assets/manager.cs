using UnityEngine;
using System.Collections;

public class manager : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
    public void Replay()
    {
        Application.LoadLevel(1);
    }
    public void main()
    {
        Application.LoadLevel(0);
    }
}
