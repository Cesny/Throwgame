using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicakTriggerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if ( other.tag == "border")
        {
            Destroy(gameObject);

        }
    }
}
