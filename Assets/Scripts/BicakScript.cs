using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicakScript : MonoBehaviour
{
    public GameObject Bicak;
    public float Speed;



    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            GameObject b = Instantiate(Bicak, transform.position, transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.up) * Speed, ForceMode.Impulse);
        } 



    }


}
