using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InstantiateCarre : MonoBehaviour {

    public List<GameObject> Prefabs;
    public List<GameObject> EnemyPrefabs;
    private List<float> Positions;
    public List<float> currentPositions;
    private List<string> States = new List<string>();

    // variable of kaddem
    float elapsedtime = 0;
    float timelimit = 3f;
    float speedlimit = 200f;
    float speed = 5f;
    float duration = 3.0F;


    public Vector2 currentPos;
    public bool G1;
    public bool G2;
    public bool G3;
    public bool G4;
    public bool BRight;
    public static BoxCollider2D gbLeft;
    public static BoxCollider2D gbRight;


    public float PosxRight;
    public float PosxLeft;
    public float circleDiameter;
    public float somme;
    public float marge;
    public float wallSizeWidth = 2;
    public float partie;

   
  
    public CircleCollider2D circle;
    //public GameObject Scorr;

    void Awake()
    {
        States.Add("no wall");
        States.Add("right wall");
        States.Add("left wall");
        States.Add("in the wall");

        gbRight = GameObject.FindGameObjectWithTag("RightWall").GetComponent<BoxCollider2D>();
        gbLeft = GameObject.FindGameObjectWithTag("LeftWall").GetComponent<BoxCollider2D>();
        circle = GameObject.FindGameObjectWithTag("Player").GetComponent<CircleCollider2D>();

        PosxRight = gbRight.transform.position.x - 1;
        Debug.Log("PosxRight: " + PosxRight.ToString());
        PosxLeft = gbLeft.transform.position.x + 1;
        Debug.Log("PosxLeft: " + PosxLeft.ToString());
        somme = PosxRight - PosxLeft;
        circleDiameter =1.442f;
        Debug.Log("circleDiameter: " + circleDiameter.ToString());
        marge = circleDiameter * 2 + 0.73f;
        partie = (somme / marge);
        print("marge: " + marge.ToString());

        Positions = new List<float>();
        currentPositions = new List<float>();
		print("before if statement" +(somme % marge));

        print("partie int: " + ((int)partie).ToString());
        if ((partie - (int)partie) == 0)
        { 
            int n = (int)partie - 1;
            print("n: " + n.ToString());

            float valeur = PosxLeft;
            for (int i = 0; i < n; i++)
            {
                valeur += marge;
                Debug.Log("n valeurs: " + (valeur - wallSizeWidth / 2).ToString());
                Positions.Add(valeur - wallSizeWidth / 2);
                print("Positions 1: " + Positions[i].ToString());
            }
        }
        else
        {
            if ((somme - ((int)partie * marge)) < circleDiameter * 2)
            {
                int n = (int)partie - 1;
                print("n: " + n.ToString());

                float valeur = PosxLeft;
                for (int i = 0; i < n; i++)
                {
                    valeur += marge;
                    Debug.Log("n valeurs: " + (valeur - wallSizeWidth / 2).ToString());
                    Positions.Add(valeur - wallSizeWidth / 2);
                    print("Positions 2: " + Positions[i].ToString());
                }
            }
            else
            {
                int n = (int)partie;
                print("n: " + n.ToString());

                float valeur = PosxLeft;
                for (int i = 0; i < n; i++)
                {
                    valeur += marge;
                    Debug.Log("n valeurs: " + (valeur - wallSizeWidth / 2).ToString());
                    Positions.Add(valeur - wallSizeWidth / 2);
                    print("Positions i: " + Positions[i].ToString());
                }
            }

        }

		
            print("after if statement");
            Debug.Log("Positions in the table: "+ Positions.Count.ToString());
        

        //try tochange this into fixed update
        InvokeRepeating("InsCar", 2, 1.5f);
    }
    void InsCar()
    {
        if (speed < speedlimit)
            speed += .5f;
        //instantiate the box collider of the score
        //Instantiate(Scorr, new Vector2(0, transform.position.y), Quaternion.identity);

        G1 = (Random.Range(0, 2) == 0);
        G2 = (Random.Range(0, 2) == 0);
        G3 = (Random.Range(0, 2) == 0);
        G4 = (Random.Range(0, 2) == 0);
        


        if (G1 )
        {

            int RandomIndex = Random.Range(0, Positions.Count);
            currentPos = new Vector2(Positions[RandomIndex], transform.position.y);
            currentPositions.Add(Positions[RandomIndex]);
            GameObject PrefabInstance = Instantiate(Prefabs[0], currentPos, Quaternion.identity) as GameObject;
            PrefabInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed); 
        }
        if (G2 )
        {
            int RandomIndex = Random.Range(0, Positions.Count);
            currentPos = new Vector2(Positions[RandomIndex], transform.position.y);
            currentPositions.Add(Positions[RandomIndex]);
            GameObject PrefabInstance = Instantiate(Prefabs[1], currentPos, Quaternion.identity) as GameObject;
            PrefabInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
        if (G3 )
        {
            int RandomIndex = Random.Range(0, Positions.Count);
            currentPos = new Vector2(Positions[RandomIndex], transform.position.y);
            currentPositions.Add(Positions[RandomIndex]);
            GameObject PrefabInstance = Instantiate(Prefabs[2], currentPos, Quaternion.identity) as GameObject;
            PrefabInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
        if (G4 )
        {
            int RandomIndex = Random.Range(0, Positions.Count);
            currentPos = new Vector2(Positions[RandomIndex], transform.position.y);
            currentPositions.Add(Positions[RandomIndex]);
            GameObject PrefabInstance = Instantiate(Prefabs[3], currentPos, Quaternion.identity) as GameObject;
            PrefabInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }

        string state = States[Random.Range(0, States.Count-1)];

        //the disatnce that i will add for the items
        float m = 0.8f;

        if (state == "in the wall")
        {
            for(int i = 0; i < currentPositions.Count; i++  ){
                BRight = (Random.Range(0, 2) == 0);
                if (BRight == true)
                {
                    // setup the current position of the enemy if i is on the right of the wall
                    currentPos = new Vector2(currentPositions[i] + m, transform.position.y);
                    //enemy prefabs is the list of anenmies and EnemyPrefabs[0] is the enemy that can be on the 
                    //right of the wall
                    int RandomI = Random.Range(0, EnemyPrefabs.Count);
                    GameObject PrefabInstance = Instantiate(EnemyPrefabs[RandomI], currentPos, Quaternion.identity) as GameObject;
                    PrefabInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);

                }
                else
                {
                    //same as above but for the left enemy
                    currentPos = new Vector2(currentPositions[i] - m, transform.position.y);
                    int RandomI = Random.Range(0, EnemyPrefabs.Count);
                    GameObject PrefabInstance = Instantiate(EnemyPrefabs[RandomI], currentPos, Quaternion.identity) as GameObject;
                    PrefabInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);

                }

            }
        } else if (state == "right wall")
        {
            currentPos = new Vector2(PosxRight-m, transform.position.y);
            int RandomI = Random.Range(0, EnemyPrefabs.Count);
            GameObject PrefabInstance = Instantiate(EnemyPrefabs[RandomI], currentPos, Quaternion.identity ) as GameObject;
            PrefabInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
        else if (state ==  "left wall")
        {
            currentPos = new Vector2(PosxLeft + m, transform.position.y);
            int RandomI = Random.Range(0, EnemyPrefabs.Count);
            GameObject PrefabInstance = Instantiate(EnemyPrefabs[RandomI], currentPos, Quaternion.identity) as GameObject;
            PrefabInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
        else if (state == "no wall")
        {
            Debug.Log("no wall");
            int RandomIndex = Random.Range(0, Positions.Count);
            BRight = (Random.Range(0, 2) == 0);
            float posOfEnemy;
            if (BRight == true)
            {
                float widthOfTheEnemy = Prefabs[1].GetComponent<BoxCollider2D>().size.x;
                posOfEnemy = Positions[RandomIndex] + m + (widthOfTheEnemy / 2);

                GameObject PrefabInstance = Instantiate(EnemyPrefabs[Random.Range(0, EnemyPrefabs.Count)],
                    new Vector2(posOfEnemy, transform.position.y), Quaternion.identity) as GameObject;

                PrefabInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
            }
            else
            {
                float widthOfTheEnemy = Prefabs[1].GetComponent<BoxCollider2D>().size.x;
                posOfEnemy = Positions[RandomIndex] - m - (widthOfTheEnemy / 2);
                GameObject PrefabInstance = Instantiate(EnemyPrefabs[Random.Range(0, EnemyPrefabs.Count)],
                    new Vector2(posOfEnemy, transform.position.y), Quaternion.identity) as GameObject;

                PrefabInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
            }             
        }
        currentPositions.Clear();
    }

    
}
