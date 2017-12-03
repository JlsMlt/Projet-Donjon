using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiègePique : MonoBehaviour {
    public float Délais;

	// Use this for initialization
	void Start () {
        StartCoroutine(Go());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Go()
    {
        while(true)
        {
            gameObject.GetComponent<Animation>().Play();
            yield return new WaitForSeconds(2f);
        }
    }
}
