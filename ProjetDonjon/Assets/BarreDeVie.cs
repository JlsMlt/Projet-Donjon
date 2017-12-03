using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarreDeVie : MonoBehaviour {

    static Image Barre;
    public float max { get; set; }
    private float Valeur;
    public float valeur
    {
        get { return Valeur; }

        set
        {
            Valeur = Mathf.Clamp(value, 0, max);
            Barre.fillAmount = (1 / max) * Valeur;
        }
    }

	// Use this for initialization
	void Start () {
        Barre = GetComponent<Image>();	
	}
	
	
}
