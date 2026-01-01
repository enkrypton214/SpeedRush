using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody PlayerRB;
    bool isGrounded=false;
    public float jumpForce = 7f;
    public float playerMovementSpeed = 5f;
    public float speed=5f;
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
    }
    void Update()
    {
        PlayerJump();
        MovePlayerLR();
    }

//Check CollisionFunction
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded=true;
        }
    }
    

    void MovePlayerLR()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontal*playerMovementSpeed,PlayerRB.velocity.y,speed);
        // PlayerRB.AddForce(movement, ForceMode.Force);
        PlayerRB.velocity = movement;
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
