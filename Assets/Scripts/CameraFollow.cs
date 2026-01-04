
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    Vector3 offset;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        offset = player.position-transform.position; //player's position - camera position gives offset
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position=player.position-offset;
    }
}
