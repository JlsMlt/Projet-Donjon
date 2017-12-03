using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiègeBoule : MonoBehaviour
{

    public GameObject Boule;
    public bool Chute = false;


    void Update()
    {
       if (Chute)
        {
            Boule.GetComponent<Rigidbody>().useGravity = true;
        }
        
    }


    void OnTriggerEnter()
    {

        Chute = true;
    }

    void OnTriggerExit()
    {

        Chute = false;
    }
}
