using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuverturePorte : MonoBehaviour {

    public GameObject Pivot, Porte;
    public int Angle = -90;
    private int AngleActu;
    public bool Ouverture = false;


    void Update()
    {
        if (Ouverture)
        {
            if (AngleActu<Angle)
            {
            AngleActu += 1;
            Porte.transform.RotateAround(Pivot.transform.position, Vector3.down, AngleActu * Time.deltaTime);
            }
            
        }
        else
        {
            if (AngleActu !=0)
            {
            AngleActu -= 1;
            Porte.transform.RotateAround(Pivot.transform.position, -Vector3.down, AngleActu * Time.deltaTime);
            }
            
        }

        if (AngleActu == 0)
        {
            Porte.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }


	void OnTriggerEnter()
    {

        Ouverture = true;
    }

    void OnTriggerExit()
    {

        Ouverture = false;
    }
}
