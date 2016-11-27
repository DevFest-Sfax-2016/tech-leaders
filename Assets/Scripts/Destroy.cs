using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag ==  "Respawn" || col.gameObject.tag == "Wall" ||  col.gameObject.tag == "scorr" || col.gameObject.tag == "good" || col.gameObject.tag == "bad" || col.gameObject.tag == "verybad")
            Destroy(col.gameObject);
    }
}
