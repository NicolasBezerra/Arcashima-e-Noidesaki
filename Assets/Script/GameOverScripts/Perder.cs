using UnityEngine;
using System.Collections;

public class Perder : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Perdeu"))
        {
            Application.LoadLevel(2);
        }
    }



}
