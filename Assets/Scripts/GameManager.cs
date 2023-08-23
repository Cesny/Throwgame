using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int hedefSayisi;
    public BaseRotateScript baseRotate;


    void Update()
    {
        if (hedefSayisi <= 0)
        {
            baseRotate.speed = 0f;
           
            
        }




    }




}
