using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody PlayerRB;
    bool isGrounded=false;
    public float jumpForce = 7f;
    public float playerMovementSpeed = 5f;
    public float speed=5f;
    private float maxSpeed = 200f;
    private float maxHorizontalSpeed=20f;

    public float acceleration=0.01f;
    
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
    }
    void Update()
    {
        PlayerJump();
        Accelerate();
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
        // Include a rotation mechanism
        Vector3 movement = new Vector3(horizontal*playerMovementSpeed,PlayerRB.velocity.y,speed);
        // PlayerRB.AddForce(movement, ForceMode.Force);
        PlayerRB.velocity = movement;
        Vector3 pos = PlayerRB.position;
        pos.x = Mathf.Clamp(pos.x, -5f, 5f);
        PlayerRB.MovePosition(pos);
    }

    void PlayerJump()
    {
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            PlayerRB.AddForce(Vector3.up * jumpForce , ForceMode.Impulse);
            isGrounded=false;
        }


     }
     void Accelerate()
        {
            if (speed<maxSpeed){
            speed +=acceleration*Time.deltaTime;}
            if(playerMovementSpeed<maxHorizontalSpeed){
            playerMovementSpeed +=acceleration*Time.deltaTime;
            }
            Vector3 forwardMovement = transform.forward *speed;
           PlayerRB.velocity = new Vector3 (forwardMovement.x, PlayerRB.velocity.y,forwardMovement.z);  
        }   
}
