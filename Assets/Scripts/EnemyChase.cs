using UnityEngine;

public class EnemyChase : MonoBehaviour
{

    public GameObject Player;
    public float speed = 3f;


    void Update()
    {
        this.transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
    }
}