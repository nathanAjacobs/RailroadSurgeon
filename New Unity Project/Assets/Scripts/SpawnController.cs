using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public static Vector3 spawnPos;
    public static bool needToSpawn;
    public static Quaternion rot;

    public GameObject track1;
    public GameObject track2;
    public GameObject track3;
    public GameObject track4;
    public GameObject track5;
    public GameObject track6;
    public GameObject track7;
    public GameObject track8;
    public GameObject track9;
    public GameObject track10;
    public GameObject track11;

    //public static int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPos = Vector3.zero;
        needToSpawn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(needToSpawn)
        {
            int r = (int)(Random.value * 11 + 1);

            if (r == 12)
                r = 4;

            //Debug.Log(r);

            if (r == 1)
            {
                Instantiate(track1, spawnPos, rot);
            }
            else if (r == 2)
            {
                Instantiate(track2, spawnPos, rot);
            }
            else if (r == 3)
            {
                Instantiate(track3, spawnPos, rot);
            }
            else if (r == 4)
            {
                Instantiate(track4, spawnPos, rot);
            }
            else if (r == 5)
            {
                Instantiate(track5, spawnPos, rot);
            }
            else if (r == 6)
            {
                Instantiate(track6, spawnPos, rot);
            }
            else if (r == 7)
            {
                Instantiate(track7, spawnPos, rot);
            }
            else if (r == 8)
            {
                Instantiate(track8, spawnPos, rot);
            }
            else if (r == 9)
            {
                Instantiate(track9, spawnPos, rot);
            }
            else if (r == 10)
            {
                Instantiate(track10, spawnPos, rot);
            }
            else if (r == 11)
            {
                Instantiate(track11, spawnPos, rot);
            }

            needToSpawn = false;
        }
    }
}
