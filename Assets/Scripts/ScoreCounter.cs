using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    DetectCollisions detectCollisions;
    private static int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        //detectCollisions = FindObjectOfType<DetectCollisions>();
    }

    // Update is called once per frame
    void Update()
    {
        score = DetectCollisions.scoreValue/2;
        scoreText.text = score.ToString();
        //scoreText.text = "this is working";
    }
}
