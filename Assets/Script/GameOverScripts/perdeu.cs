using UnityEngine;
using System.Collections;

public class perdeu : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll) 
    {

        if (coll.gameObject.tag.Equals("Perdeu")) {

            Application.LoadLevel(2);   
        }
    
    }
}
