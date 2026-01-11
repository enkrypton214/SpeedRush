using System.Collections;
using UnityEngine;

public class CameraSpinScript : MonoBehaviour
{
    public Transform pivot;
    public Transform mainCamera;

    public Vector3 startRotation = Vector3.zero;          // (0,0,0)
    public Vector3 endRotation = new Vector3(-25, 180, 0);

    public float duration = 2f;

    public GameObject menuUI;
    public MonoBehaviour playerMovement;   // your runner script
    public Rigidbody playerGravity;

    public bool gameStarted=false;

    void Start()
    {
        pivot.eulerAngles = startRotation;
        playerMovement.enabled = false;
        playerGravity.useGravity = false;
    }

    // THIS gets called by the Play button
    public void OnPlayPressed()
    {
        StartCoroutine(RotatePivot());
    }

    IEnumerator RotatePivot()
    {
        float t = 0f;
        Quaternion from = Quaternion.Euler(startRotation);
        Quaternion to = Quaternion.Euler(endRotation); 


        while (t < duration)
        {
            
            float blend = Mathf.SmoothStep(0f, 1f, t / duration);
            pivot.rotation = Quaternion.Slerp(from, to, blend);
            t += Time.deltaTime;
            yield return null;
        }

        pivot.rotation = to;

        // Game starts here
        menuUI.SetActive(false);
        playerMovement.enabled = true;
        playerGravity.useGravity = true;
        gameStarted = true;

    }
}