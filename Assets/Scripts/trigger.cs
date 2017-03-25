using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {
    private float Ypos = -1.58f;
    public GameObject koce;
    private readonly object other;
    private bool colis = false;
    void FixedUpdate()
    {
        if (colis==true)
        {
            Vector3 FillPos = new Vector3(2.8f, Ypos, 0.0f);
            koce.transform.position = FillPos;
            Ypos = Ypos + 0.1f *Time.deltaTime;
            if(Ypos> -0.3173597f) { colis=false; }
           
            //Pottentioal GameOver implamentation
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
}
