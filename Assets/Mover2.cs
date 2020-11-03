using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2 : MonoBehaviour
{
    [Tooltip("Movement speed in meters per sec")] 
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed=6f;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.D)&&Input.GetKey(KeyCode.W)){
            transform.position+= new Vector3(speed*Time.deltaTime,speed*Time.deltaTime,0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -42f,22f),Mathf.Clamp(transform.position.y, -24f, -17f) ,transform.position.z);
        }
        else if(Input.GetKey(KeyCode.D)&&Input.GetKey(KeyCode.S)){
            transform.position+= new Vector3(speed*Time.deltaTime,-speed*Time.deltaTime,0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -42f,22f),Mathf.Clamp(transform.position.y, -24f, -17f) ,transform.position.z);
        }
        else if(Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.S)){
            transform.position+= new Vector3(-speed*Time.deltaTime,-speed*Time.deltaTime,0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -42f,22f),Mathf.Clamp(transform.position.y, -24f, -17f) ,transform.position.z);
        }
        else if(Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.W)){
            transform.position+= new Vector3(-speed*Time.deltaTime,speed*Time.deltaTime,0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -42f,22f),Mathf.Clamp(transform.position.y, -24f, -17f) ,transform.position.z);
        }
        else if(Input.GetKey(KeyCode.W)){
            transform.position+= new Vector3(0,speed*Time.deltaTime,0);
            transform.position = new Vector3(transform.position.x,Mathf.Clamp(transform.position.y, -24f, -17f) ,transform.position.z);
        }
        else if(Input.GetKey(KeyCode.S)){
            transform.position+= new Vector3(0,-speed*Time.deltaTime,0);
            transform.position = new Vector3(transform.position.x,Mathf.Clamp(transform.position.y, -24f, -17f) ,transform.position.z);
        }
        else if(Input.GetKey(KeyCode.A)){
            transform.position+= new Vector3(-speed*Time.deltaTime,0,0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -42.8f, 22f), transform.position.y,transform.position.z);
        }
        else if(Input.GetKey(KeyCode.D)){
            transform.position+= new Vector3(speed*Time.deltaTime,0,0);
             transform.position = new Vector3(Mathf.Clamp(transform.position.x, -42.8f, 22f), transform.position.y,transform.position.z);
        }
    }
}
