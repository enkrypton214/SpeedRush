
using UnityEngine;

public class LoadTunnelScript : MonoBehaviour
{
    public GameObject NextMap;
    private Vector3 myposition;

    
    void OnTriggerEnter(Collider collider)
    {
        myposition = this.transform.position;
        NextMap.transform.position = myposition+ new Vector3 (0,0,1795);
        Debug.Log(this.transform.position);
        Debug.Log(NextMap.transform.position);
        

    }
}
