using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public UnityEngine.UI.Text killsDisplay;
    public float kills = 0.00f;
    public int killsperclick = 1;
    public UnityEngine.UI.Text dpc;

    void Update()
    {
        killsDisplay.text = "Teemos Decapitated: " + kills;
        dpc.text = "Decaps Per Click: " + killsperclick;
    }

    public void Clicked()
    {
        kills += killsperclick;
    }
    







}

   /* // Use this for initialization

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
*/
  