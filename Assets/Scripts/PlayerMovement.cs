using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody PlayerRB;
    public float PlayerSpeed=2f;
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
    }
    void Update()
    {

        PlayerRB.velocity= new Vector3(0,0,PlayerSpeed);
    }
}
