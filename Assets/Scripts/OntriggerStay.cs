using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntriggerStay : MonoBehaviour {

   
    private float Ypos = 1f;

    
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Vector3 FillPos = new Vector3(2.8f, Ypos, 0.0f);
            transform.position = FillPos;
        }
    }
}

