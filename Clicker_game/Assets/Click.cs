using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

    // Use this for initialization

    public int i = 0; 
    
	void Start () {

        print(i);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
    {
        i++;
    }
    }
}
