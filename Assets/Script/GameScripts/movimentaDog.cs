using UnityEngine;
using System.Collections;

public class movimentaDog : MonoBehaviour {

    private int velo;
    private float xminimo, xmaximo;
	public GameObject setaCima;
	public GameObject setaDireita;
	public GameObject setaEsquerda;
	private int control;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(0, -4.41f, 0);
        velo = 7;

		transform.localScale = new Vector3 (1.6f,transform.localScale.y,0);

        xminimo = -6.5f;
        xmaximo = 6.5f;
		control = 0;

	}

	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) 
        {
            transform.position -= new Vector3(velo*Time.deltaTime, 0, 0); 
        }

		if (Input.GetKey (KeyCode.LeftArrow) && control == 0 || Input.GetKey (KeyCode.A) && control == 0) {
			setaEsquerda.SetActive (true);
			setaDireita.SetActive (false);
			setaCima.SetActive(false);

					
		} 

		else if (control == 0)
		{
			setaCima.SetActive(true);
			setaEsquerda.SetActive(false);

		}

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) 
        {
            transform.position += new Vector3(velo*Time.deltaTime, 0, 0);
        }

		
		 if (Input.GetKey(KeyCode.RightArrow) && control == 0 || Input.GetKey(KeyCode.D) && control == 0) 
		{
			setaDireita.SetActive(true);
			setaEsquerda.SetActive(false);
			setaCima.SetActive(false);
		}

		else if (control == 0)
		{
			//setaCima.SetActive(true);
			setaDireita.SetActive(false);
			
		}

		if (Input.GetKey (KeyCode.Space)) {

			control+= 1;
			setaCima.SetActive(false);
			setaDireita.SetActive(false);
			setaEsquerda.SetActive(false);
		}

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, xminimo, xmaximo),
            transform.position.y
            );

	}
}
