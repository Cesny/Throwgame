using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HedefTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bicak")
        {
            //bicak yok olacak
           Destroy(other.gameObject);
            Destroy(gameObject);


        }
    }
}
