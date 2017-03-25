using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int moveDirection;
    public float acceleration = 5f;
    bool isActive;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (isActive == true)
        {
            if (moveDirection == 1)
            {
                transform.Translate(new Vector3(acceleration, 0f, 0f));
            }
            else
            {
                transform.Translate(new Vector3(-acceleration, 0f, 0f));
            }
        }

    }

    public void OnPointerDown(int direction)
    {
        if (direction == 1)
        {
            moveDirection = 1;
        }
        else
        {
            moveDirection = -1;
        }
        isActive = true;
    }

    public void OnPointerUp()
    {
        isActive = false;
    }
}
