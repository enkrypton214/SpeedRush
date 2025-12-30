using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody PlayerRB;
    bool isGrounded=false;
    public float jumpForce = 7f;
    public float playerMovementSpeed = 500f;
    public float speed=.005f;
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
    }
    void Update()
    {
        PlayerJump();
        MovePlayerLR();
        UpdateSpeed();
    }

//Check CollisionFunction
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded=true;
        }
    }
    void UpdateSpeed()
    {
        speed+= .00000001f;
    }

    void MovePlayerLR()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontal,0,speed)*playerMovementSpeed*Time.deltaTime;
        PlayerRB.AddForce(movement, ForceMode.Force);
    }

    void PlayerJump()
    {
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            PlayerRB.AddForce(Vector3.up * jumpForce , ForceMode.Impulse);
            isGrounded=false;
        }
    }
}
