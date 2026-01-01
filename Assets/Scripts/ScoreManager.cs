using System.Collections;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameObject player;

    public TextMeshProUGUI displayText;
    private int score;
    public float interval = 1f;
    void Start()
    {
        StartCoroutine(UpdateScore());
    }

    void Update()
    {
        displayText.text = "Score:" + score.ToString();
    }

    IEnumerator UpdateScore()
    {   while(true){
            score++;
            Debug.Log(score);
        yield return new WaitForSeconds(interval);}
    }

    public void StopUpdatingScore()
    {
        StopCoroutine(UpdateScore());
        Debug.Log("Score update stopped.");
    }
}

