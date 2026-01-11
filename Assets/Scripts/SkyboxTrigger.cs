using System.Collections;
using UnityEngine;

public class SkyboxTrigger : MonoBehaviour
{
    public Material daySkybox;
    public Material nightSkybox;
    public GameObject Player;
    public Light Sun;
    public float daylightIntensityDay = 1.8f;
    public float daylightIntensityNight = .2f;
    
    private void OnTriggerEnter(Collider other)
    {

        Light light = Player.GetComponentInChildren<Light>();
        int x = Random.Range(0,2);
        if (other.CompareTag("Player") && x==0)
        {
            RenderSettings.skybox = nightSkybox;
            Sun.intensity = daylightIntensityNight;
            DynamicGI.UpdateEnvironment();
            light.enabled=true;
            Debug.Log("Night");
        }
        if (other.CompareTag("Player") && x==1)
        {
            RenderSettings.skybox = daySkybox;
            Sun.intensity = daylightIntensityDay;
            DynamicGI.UpdateEnvironment();
            light.enabled=false;
            Debug.Log("Day");
        }
    }

// to change the sky in a fading effect, use IEnumerator and make a fading script by changing light using Lerp on the intensity of sunlight.
}
