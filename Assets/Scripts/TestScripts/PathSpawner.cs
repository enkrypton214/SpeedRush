
using UnityEngine;

public class PathSpawner : MonoBehaviour
{

    public Transform GroundHolder;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        
        {
            if (collision.transform.GetSiblingIndex() ==1){   
            GroundHolder.GetChild(0).transform.position= GroundHolder.gameObject.transform.position+ new Vector3(0,0,50);
            GroundHolder.GetChild(0).SetSiblingIndex(5);
        }}
    }
}
