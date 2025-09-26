using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private  float speed = 0f;
    
   
    private void Update()
   
    {
        float xvalue = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        float zvalue = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(xvalue,0,zvalue);
    }
}
