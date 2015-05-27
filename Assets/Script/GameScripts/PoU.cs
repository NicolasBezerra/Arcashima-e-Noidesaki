using UnityEngine;
using System.Collections;

public class PoU : MonoBehaviour {

    public static bool teste = false;
    public static bool teste2 = false;
    public GameObject powerUp;

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.tag == "player")
        {
            Destroy(powerUp);

            if (BlocosColission.powerup <= 5)
            {
                teste = true;
                Debug.Log("1");
            }

            if (BlocosColission.powerup > 5 && BlocosColission.powerup < 11)
            {
                teste2 = true;
                Debug.Log("2");
            }
        }
        
    }

   
}
