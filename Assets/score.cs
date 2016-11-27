using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

    
    public GameObject ball;
    public BallController Sco;

    void Awake()
    {
        Sco = ball.GetComponent<BallController>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == ball)
        {
            print("score must  increment");
            Sco.score++;
        }
    }
}
