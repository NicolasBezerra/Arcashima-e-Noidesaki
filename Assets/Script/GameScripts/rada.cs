using UnityEngine;
using System.Collections;

public class rada : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col_PU) 
    {
        if (col_PU.gameObject.tag.Equals("player"))
        {
            Debug.Log("bateu");
            Destroy(col_PU.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
