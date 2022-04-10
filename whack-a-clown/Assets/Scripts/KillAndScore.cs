using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillAndScore : MonoBehaviour
{
    public Text scoreText;
    public int scoreCount;
    public float newScore;

    // Start is called before the first frame update
    void Start()
    {
        scoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        Debug.Log("you clicked me");
        Score();
        Destroy(gameObject);

    }

    void Score()
    {
        Debug.Log("previous score: " + scoreCount);
        scoreCount++;
        newScore = scoreCount;

        Debug.Log("new score: " + newScore);

        scoreText.text = "Score: " + newScore.ToString();
    }
}

