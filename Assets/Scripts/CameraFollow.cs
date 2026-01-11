
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    Vector3 offset;
    public Transform player;
    public CameraSpinScript CameraPivot;
    // Start is called before the first frame update
    void Start()
    {
        offset = player.position-transform.position; //player's position - camera position gives offset
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(CameraPivot.gameStarted == true){
        transform.position=player.position-offset+new Vector3 (0,3,-14);}
    }
}
