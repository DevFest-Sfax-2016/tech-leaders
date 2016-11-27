using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {

    public Transform gbRight;
    public Transform gbLeft;
    private bool hitWall;

    public float speed = 100f;
    public int score; 

   
    Rigidbody2D rgb;
    // Use this for initialization
    void Awake() {
        
        rgb = GetComponent<Rigidbody2D>();
        hitWall = false;
        score = 0;

    }

    void Update()
    {



        if (Input.GetKey(KeyCode.RightArrow) /*&& !hitWall*/ )
        {

            rgb.velocity = (Vector2.right * speed * Time.deltaTime);
            Debug.Log("GetKey(KeyCode.RightArrow)");
        }

        if (Input.GetKey(KeyCode.LeftArrow) /*&& !hitWall*/ )
        {

            rgb.velocity = (-Vector2.right * speed * Time.deltaTime);
            Debug.Log("GetKey(KeyCode.LeftArrow)");
        }

        //if (Input.touchCount > 0)
        //{

        //    if (Input.GetTouch(0).position.x > 0)
        //    {

        //        rgb.velocity = (Vector2.right * speed * Time.deltaTime);
        //        Debug.Log("GetKey(KeyCode.RightArrow)");
        //    }
        //    else if (Input.GetTouch(0).position.x < 0)
        //    {

        //        rgb.velocity = (Vector2.right * speed * Time.deltaTime);
        //        Debug.Log("GetKey(KeyCode.RightArrow)");
        //    }

        //}

        //    if (Input.GetKeyDown(KeyCode.RightArrow))
        //    {

        //        rgb.velocity = (-Vector2.right * speed * Time.deltaTime);

        //        Debug.Log("GetKeyDown KeyCode.RightArrow  !!!");
        //    }
        //    if (Input.GetKeyDown(KeyCode.LeftArrow) && !hitWall)
        //    {
        //        //rgb.AddForce()
        //        rgb.velocity = (Vector2.right * speed * Time.deltaTime);
        //        Debug.Log("GetKeyDown(KeyCode.LeftArrow) !!!");
        //    }

        //}
    }

   
}
