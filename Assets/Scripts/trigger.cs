using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger : MonoBehaviour
{
    private float Ypos;
    public GameObject Rainbow;
    private readonly object other;
    private bool colis = false;

    void FixedUpdate()
    {
        if (colis == true)
        {
            Ypos = 0.1f * Time.deltaTime;
            this.RiseUp(Ypos, colis, Rainbow);
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {

            colis = true;

        }


    }
    private void OnTriggerExit2D(Collider2D col) { colis = false; }

    public void RiseUp(float Ypos, bool colis, GameObject Rainbow)
    {
        if (Rainbow.transform.position.y > -0.1060129f)
        {
            colis = false;
            //End game win
            SceneManager.LoadScene("EndGame");
        }
        else
        {
            Vector3 FillPos = new Vector3(0f, Ypos, 0.0f);
            Rainbow.transform.position += FillPos;
        }
    }

}
