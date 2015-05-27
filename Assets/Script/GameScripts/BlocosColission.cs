using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// TODO : Múltiplas bolas
// TODO : Aumentar e Diminuir o Player
// TODO : Bola de fogo
// TODO : Bloco de tres tapinhas

public class BlocosColission : MonoBehaviour {

    public AudioClip kBum;
    private GameObject Prefab_pu;
    public static int powerup;
    public  Text pontos;
    public  int score;
	public GameObject ActiveScore;
	public GameObject DeleteText;

    void Start()
    {
        Prefab_pu = Resources.Load("Prefabs/PowerUp") as GameObject;
    }

    void scoreAdd() {
        score+=10;
        print(score + " Souza escroto ");
        pontos.text = score.ToString();
		PlayerPrefs.SetInt("score", score);
	
    }

	void Update(){

		
		if (Input.GetKey (KeyCode.Space)) {
			
			ActiveScore.SetActive (true);
			DeleteText.SetActive (false);
			
		}

	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Blocos"))
        {
            Destroy(col.gameObject);
            audio.PlayOneShot(kBum);
            powerup = Random.Range(0, 101);
            scoreAdd();
            if (powerup <= 10 && PU_Player.impedimento != true)
            {
                Instantiate(Prefab_pu, transform.position, transform.rotation);
            }

            Debug.Log(powerup);
        }
    }
}   