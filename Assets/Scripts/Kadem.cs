using UnityEngine;
using System.Collections;

public class Kadem : MonoBehaviour {
    public float elapsedtime = 0; 
    public float timelimit  = 3f;
    public float speedlimit = 3f; 
    public float speed = 0.1f;
    
    public float duration = 3.0F;
    // Update is called once per frame

    
   void Awake()
    {
    }
	void FixedUpdate () {
        transform.position += new Vector3(0, speed, 0);

        elapsedtime += Time.deltaTime;
        if (speed < speedlimit)
            if (elapsedtime>= timelimit )
            {
                speed += 0.04f;
                elapsedtime = 0;
            }
        
 	}
}
