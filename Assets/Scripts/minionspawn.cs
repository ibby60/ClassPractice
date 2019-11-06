using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minionspawn : MonoBehaviour
{
    public GameObject minion;
    public float timer = 3f;
   
    void Update()
    {
        //if timer hits zero spawn minion
        timer -= Time.deltaTime;
        if (timer < -0f)
        {
            //reset timer
            timer = 3f;
            //spawn minion
           GameObject newminion = Instantiate(minion, transform.position, transform.rotation);
        }
        
    }

}
