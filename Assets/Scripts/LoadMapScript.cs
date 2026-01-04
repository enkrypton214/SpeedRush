
using UnityEngine;

public class LoadMapScript : MonoBehaviour
{
    public GameObject NextMap;
    private Vector3 myposition;

    void Start()
    {
        myposition = this.transform.position;
    }
    void OnTriggerEnter(Collider collider)
    {
        NextMap.transform.position= myposition + new Vector3(0,0,145);
        this.transform.position = this.transform.position + new Vector3(0,0,145);
        myposition = this.transform.position;
    }
}
