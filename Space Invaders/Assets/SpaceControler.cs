using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceControler : MonoBehaviour {

    private Vector2 targetpos;

	void Start () {
		
	}
	
	
	void Update () {


        this.transform.Translate(Input.GetAxis("Horizontal")*0.25f, 0, 0);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -6f, 6f), -3.8f);





    }
}
