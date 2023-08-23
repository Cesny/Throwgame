using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HedefTrigger : MonoBehaviour
{
    private GameManager gameManager;


    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bicak")
        {
            gameManager.hedefSayisi--;

            //bicak yok olacak
           Destroy(other.gameObject);
            Destroy(gameObject);


        }
    }
}
