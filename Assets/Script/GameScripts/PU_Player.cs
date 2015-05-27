using UnityEngine;
using System.Collections;

public class PU_Player : MonoBehaviour {

    public static bool impedimento = false;
    public float metade;
    public float dobro;
    private int count = 0;
    private int count2 = 0;

	// Use this for initialization
	void Start () {

        metade = 1.6f / 2;
        dobro = 1.6f * 2;

		PoU.teste2 = false;
		PU2(false);
		PU22(true);
		PoU.teste = false;
		PU1(false);
		PU12(true);
	}
	
	// Update is called once per frame
	void Update () {

        if (PoU.teste == true)
        {
            PU1(true);
        }

        
        if (PoU.teste == true && count >= 600)
        {
            PoU.teste = false;
            PU1(false);
            PU12(true);
        }

        if (PoU.teste2 == true)
        {
            PU2(true);
        }

        if (PoU.teste2 == true && count2 >= 600)
        {
            PoU.teste2 = false;
            PU2(false);
            PU22(true);
        }

        
	}

    //
    //// Voids ;)
    //

    public void PU1(bool valor)
    {


        transform.localScale = new Vector3(metade, 1.567858f, 1.567858f);
        impedimento = true;
        count++;
    }

    public void PU12(bool valor)
    {
        transform.localScale = new Vector3(1.6f, 1.567858f, 1.567858f);
        impedimento = false;
        count = 0;
    }

    public void PU2(bool valor)
    {
        transform.localScale = new Vector3(dobro, 1.567858f, 1.567858f);
        impedimento = true;
        count2++;
    }

    public void PU22(bool valor)
    {
        transform.localScale = new Vector3(1.6f, 1.567858f, 1.567858f);
        impedimento = false;
        count2 = 0;
    }
}
