using UnityEngine;
using System.Collections;

public class detectCollisionsWithGoodDirtyItems : MonoBehaviour {

    public Color color1;
    Color color3;
    public Color color2;
    public float duration = 3.0F;
    float t;
    private int n;
    private bool doit;



    public Camera camera;

    //public Camera cam;
    //newCameraColor secondColor;
    // Use this for initialization
    //void Awake () {
    //    //secondColor = cam.GetComponent<newCameraColor>();
    //    //secondColor.enabled = false;

    //}
    

    void Start()
    {

        doit = false;
        camera.clearFlags = CameraClearFlags.SolidColor;
        t = 0;
        n = 0;

        

    }


    // Update is called once per frame
    void Update () {
        if (doit == true)
            switchColor();

            
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "good")
        {
            print("on collision with good: ");
            doit= true;
            DetectCollisionsWithEnemies.score += 10;
            Destroy(col.gameObject);
        }
        
    }

    void switchColor()
    {
        camera.backgroundColor = Color.Lerp(color1, color2, t);
        if (t < 1)
        {
            t += Time.deltaTime / duration;

        }
        else
        {
            n++;
            color3 = color1;
            color1 = color2;
            color2 = color3;
            t = 0;
            if (n >= 2)
            {
                n = 0;
                doit = false;

            }
            
        }
    }

}
