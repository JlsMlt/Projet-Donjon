using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dialogue : MonoBehaviour
{

    public Text TxtDialogue1;


    void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag == "Player")
        {
            TxtDialogue1.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TxtDialogue1.enabled = false;
        }
    }

    // Use this for initialization
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {

        

    }
}
