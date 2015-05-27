using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class pontos : MonoBehaviour {

     public Text score;
     public int numbers;

	// Use this for initialization
	void Start () {

        numbers = PlayerPrefs.GetInt("score");
	
	}
	
	// Update is called once per frame
	void Update () {

        score = GetComponent<Text>();
        score.text = "" + numbers + "\n " + "milhoes de mortos";
	}
}