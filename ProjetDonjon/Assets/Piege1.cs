using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piege1 : MonoBehaviour {

    private Vector3 PosDepart;

	// Use this for initialization
	void Start () {
        PosDepart = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision Col)
    {
        if(Col.gameObject.tag=="Player")
        {
            GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine("Pause");
        }
    }
    IEnumerator Pause()
    {
        yield return new WaitForSeconds(2);
        GetComponent<Rigidbody>().isKinematic = false;
        StartCoroutine("Retour");
    }

    IEnumerator Retour()
    {
        yield return new WaitForSeconds(5);
        GetComponent<Rigidbody>().isKinematic = true;
        transform.position = PosDepart;
    }
}
