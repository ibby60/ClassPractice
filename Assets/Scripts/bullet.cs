using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    //if bullet hits minion destroy both minoin and bullet
    private void OnCollisionEnter(Collision collision)
    {
        //the bullet has collided with something
        //lets check if its a minoin
        if(collision.gameObject.CompareTag ("Minion"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }



    }
}
