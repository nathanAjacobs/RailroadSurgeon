using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackRotationScript : MonoBehaviour
{

    public int trackDirection;
    public int lastTrackDirection;
    public GameObject leftTrack;
    public GameObject rightTrack;
    public GameObject straightTrack;

    private Vector3 straightLocal = new Vector3(0.3614597f, -0.5000013f, -9.44f);
    private Vector3 turnedLocal = new Vector3(0f, -0.5f, -9.44f);

    // Start is called before the first frame update
    void Start()
    {
        lastTrackDirection = trackDirection;
    }

    void Awake()
    {
        lastTrackDirection = trackDirection;
        //Debug.Log(lastTrackDirection);
    }


    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {

        
        if (lastTrackDirection != -1 && trackDirection == -1)
        {
            //Debug.Log("lastTrack: " + lastTrackDirection);
            //Debug.Log("track: " + trackDirection);

            GameObject g = Instantiate(leftTrack, turnedLocal, transform.rotation, transform.parent);
            g.transform.localPosition = turnedLocal;
            //Debug.Log("heyyyyyyyyyyy");
            Destroy(transform.gameObject);

        }
        else if (lastTrackDirection != 0 && trackDirection == 0)
        {
            GameObject g = Instantiate(straightTrack, straightLocal, transform.rotation, transform.parent);
            g.transform.localPosition = straightLocal;
            Destroy(gameObject);
        }
        else if(lastTrackDirection != 1 && trackDirection == 1)
        {
            GameObject g = Instantiate(rightTrack, turnedLocal, transform.rotation, transform.parent);
            g.transform.localPosition = turnedLocal;
            Destroy(gameObject);
        }

        lastTrackDirection = trackDirection;
    }
}
