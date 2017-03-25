using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fill : MonoBehaviour {

    public float Ypos;
   void Start()
    {
        Vector3 FillPos = new Vector3(2.8f, -1.58f, 0.0f);
    }
    // Update is called once per frame
    void Update () {
        Vector3 FillPos = new Vector3(2.8f, Ypos, 0.0f);
        transform.position = FillPos;
      
    }
}
