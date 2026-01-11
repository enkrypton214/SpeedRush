using System.Collections;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameObject player;
    public CameraSpinScript CameraPivot;

    public TextMeshProUGUI displayText;
    private int score;
    public float interval = .1f;
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
        if(CameraPivot.gameStarted == true){
            score++;}
        yield return new WaitForSeconds(interval/100);}
    }

    public void StopUpdatingScore()
    {
        StopCoroutine(UpdateScore());
        Debug.Log("Score update stopped.");
    }
}

