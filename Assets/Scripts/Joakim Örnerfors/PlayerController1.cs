using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float moveSpeed = 5f;
    public float jumpForce = 500f;
    
    
    private void Update()
    {
        
        var moveInput = Input.GetAxis("Horizontal");

        
        myRigidbody.velocity = new Vector3(moveInput * moveSpeed, myRigidbody.velocity.y, 0 );
       
        
        var jumpInput = Input.GetKeyDown(KeyCode.Space);
      
        if (jumpInput)
            myRigidbody.AddForce(Vector3.up * jumpForce);
    }
    
   
    
}