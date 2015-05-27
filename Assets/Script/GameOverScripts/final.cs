using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class final : MonoBehaviour
{

    public Text MelhorPonto;
    public int best = 0;
    public int ponto;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        best = PlayerPrefs.GetInt("best");
        ponto = PlayerPrefs.GetInt("score");

        if (ponto > best)
        {

            best = ponto;

        }

        PlayerPrefs.SetInt("best", best);
        PlayerPrefs.Save();

        MelhorPonto = GetComponent<Text>();
        MelhorPonto.text = "  " + best ;

        print(best);


    }
}
