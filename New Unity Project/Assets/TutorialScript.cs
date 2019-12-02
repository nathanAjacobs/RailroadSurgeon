using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (PlayerPrefs.GetInt("firstRun") == 1 && collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            if(gameObject.tag == "tut2")
            {
                text2.SetActive(true);
            }
            else
            {
                text1.SetActive(true);
            }
            TrainMovement.pauseTrain = true;
        }
    }
}
