using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DetectCollisionsWithEnemies : MonoBehaviour
{


    public Color color1;
    Color color3;
    public Color color2;

    public Canvas canvas;
    public Image im1, im2, im3;
    public Text st;


    static public float gameSpeed;


    float startime;
    public Text text;
    public float duration = 3.0F;
    float t;
    private int n;
    private bool doit;
    int d;
    int health;
    public static int score;
    //private float reference = 0.06f;



    public Camera camera;

    //public Camera cam;
    //newCameraColor secondColor;
    // Use this for initialization
    //void Awake () {
    //    //secondColor = cam.GetComponent<newCameraColor>();
    //    //secondColor.enabled = false;

    //}



    void Awake()
    {

        doit = false;
        camera.clearFlags = CameraClearFlags.SolidColor;

        t = 0;
        d = 10;
        n = 0;
        health = 3;
        score = 0;
        im1.enabled = true;
        im2.enabled = true;
        im3.enabled = true;
        st.enabled = false;


    }
    //void start()
    //{
    //    startime = Time.time;
    //}

    ///* private float elapsedTime = 0f;
    // Update is called once per frame
    void Update()
    {
        //gameSpeed = Mathf.Clamp(2 * reference * Time.timeSinceLevelLoad, 3, 9.5f);
        //score = (int)(Time.timeSinceLevelLoad * gameSpeed / 5);
        //score = (int)Mathf.Round(score);
        score++;
        /*--------------*/
        //elapsedTime += Time.deltaTime;
        //score += (int)Mathf.Ceil((elapsedTime * 3) / d);
        //print("score");
        //d += 1000;
        text.text = score.ToString();
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.Save();










        if (doit == true)
        {

            //st.enabled = true;
            print("looser");
            switchColor();

            // 
        }

    }

    //int calculateScore()
    //{
    //    return (int)(Time.time - startime);
    //}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "bad")
        {
            Destroy(col.gameObject);
            doit = true;
            health--;
            if (health == 2)
            {
                im3.enabled = false;
            }
            else if (health == 1)
            {
                im2.enabled = false;
            }
            else
            {
                im1.enabled = false;
                print("we have to load scene!!");
                SceneManager.LoadScene("GameOver");
            }
            score -= 10;
        }
        //if (col.gameObject.tag == "good")
        //{
        //    Destroy(col.gameObject);
        //    doit = true;
        //    score += 100;
        //}

        if (col.gameObject.tag == "verybad")
        {
            Destroy(col.gameObject);
            im1.enabled = false;
            im2.enabled = false;
            im3.enabled = false;
            print("we have to load scene!!");
            SceneManager.LoadScene("GameOver");
            //doit = true;

            //health = 0;

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

