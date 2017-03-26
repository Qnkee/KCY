using UnityEngine;

public class JumpController : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isGrounded;
    public string groundName;
    public string buttonName;
    public float jumpHeight = 2000f;
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == groundName || collision.gameObject.name == buttonName)
        {
            isGrounded = true;
        }
    }

    public void OnJump()
    {
        if (isGrounded)
        {
            this.rb.AddForce(new Vector2(0f, jumpHeight));
        }
        isGrounded = false;
    }
}
