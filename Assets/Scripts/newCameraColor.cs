using UnityEngine;
using System.Collections;

public class newCameraColor : MonoBehaviour
{
    public Color color1;
    Color color3;
    public Color color2;
    public float duration = 3.0F;
    float t;
    private int n;
    
    

    Camera camera;
    

    void Start()
    {
        
        camera = GetComponent<Camera>();
        camera.clearFlags = CameraClearFlags.SolidColor;
        t = 0;
        n = 0;

        print("i am in start!!!");

    }

    void Update()
    {
        print(" i am in update!!!");
        camera.backgroundColor = Color.Lerp(color1, color2, t);
        if (t < 1)
        {
            t += Time.deltaTime / duration;

        }
        else
        {
            n++;
            if (n < 2)
            {
                color3 = color1;
                color1 = color2;
                color2 = color3;
                t = 0;

            }
            else
            {
                GetComponent<newCameraColor>().enabled = false;
                
            }
                

        }

    }
}