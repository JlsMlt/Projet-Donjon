using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuverturePorte3 : MonoBehaviour
{

    public GameObject Pivot3, Porte3;
    public int Angle = 10;
    private int AngleActu;
    public bool Ouverture = false;


    void Update()
    {
        if (Ouverture)
        {
            if (AngleActu < Angle)
            {
                AngleActu += 1;
                Porte3.transform.RotateAround(Pivot3.transform.position, Vector3.down, AngleActu * Time.deltaTime);
            }

        }
        else
        {
            if (AngleActu != 0)
            {
                AngleActu -= 1;
                Porte3.transform.RotateAround(Pivot3.transform.position, -Vector3.down, AngleActu * Time.deltaTime);
            }

        }

        if (AngleActu == 0)
        {
            Porte3.transform.rotation = Quaternion.Euler(0, 90, 0);
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
