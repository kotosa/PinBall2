using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessRegulator : MonoBehaviour {

    Material myMaterial;
    private float minEmission = 0.3f;
    private float magEnission = 2.0f;
    private int degree = 0;
    private int speed = 10;
    Color defaultColor = Color.white;

	// Use this for initialization
	void Start () {
		if(tag == "SmallStarTag")
        {
            this.defaultColor = Color.white;
        }
        else if(tag == "LargeStarTag")
        {
            this.defaultColor = Color.yellow;
        }
        else if(tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            this.defaultColor = Color.blue;
        }
        this.myMaterial = GetComponent<Renderer>().material;
        this.myMaterial.SetColor("_EmissionColor", this.defaultColor * minEmission);
	}
	
	// Update is called once per frame
	void Update () {
		if(degree >= 0)
        {
            Color emissionColor = this.defaultColor * ( this.minEmission + Mathf.Sin(Mathf.Deg2Rad * degree) * this.magEnission);
            myMaterial.SetColor("_EmissionColor", emissionColor);
            this.degree -= this.speed;
        }
	}

    void OnCollisionEnter()
    {
        this.degree = 180;
    }
}
