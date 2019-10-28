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
            int r = (int)(Random.value * 4 + 1);

            if (r == 5)
                r = 4;

            Debug.Log(r);

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
            
            
            needToSpawn = false;
        }
    }
}
