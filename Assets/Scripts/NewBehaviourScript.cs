using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private int moveDirection;
    public float acceleration = 75f;
    private bool isActive = false;

    void Start()
    {
        this.rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(isActive)
        {
            if(moveDirection == 1)
            {
                this.rb.AddForce(new Vector3(acceleration, 0f));
            }
            else
            {

            }
        }
    }

    public void ObjectMove(int direction)
    {
        isActive = true;
        if (direction == 1)
        {
            moveDirection = 1;
        }
        else
        {
            moveDirection = -1;
        }
    }
}
