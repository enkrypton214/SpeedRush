
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    Vector3 offset;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        offset = player.transform.position-transform.position; //player's position - camera position gives offset
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=player.transform.position-offset;
    }
}
