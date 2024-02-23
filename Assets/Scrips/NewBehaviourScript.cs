using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool onGround;
    public float fuerza_x;
    public float fuerza_y;
    // Start is called before the first frame update
    void Start()
    {
       onGround = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.E))
        {
        print("Space key was released");
      if (GetComponent<Rigidbody>() != null)
      {
        GetComponent<Rigidbody>().useGravity = true;
      }
        }
      if(Input.GetKeyDown(KeyCode.Space))
      {
      if (onGround){
        Vector3 fuerza = new Vector3(fuerza_x, fuerza_y, 0);
        GetComponent<Rigidbody>().AddForce(fuerza);
      }
      }

    if (Input.GetKeyDown(KeyCode.A))
    {
      fuerza_x = fuerza_x - 10;
    }

    if (Input.GetKeyDown(KeyCode.D))
    {
      fuerza_x = fuerza_x + 10;
    }

    if (Input.GetKeyDown(KeyCode.W))
        {
            fuerza_y = fuerza_y - 100;
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            fuerza_y = fuerza_y + 100;
        }

    }
    private void OnCollisionEnter(Collision c){
        Debug.Log("colision");
        onGround = true;
    }
      private void OnCollisionStay(Collision c){
        onGround = true;
    }
      private void OnCollisionExit(Collision c){
        onGround = false;
        Debug.Log("Libre");
    }
}
