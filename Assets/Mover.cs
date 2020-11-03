using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("Movement speed in meters per sec")] [SerializeField] float speed ;
    // Start is called before the first frame update
    void Start()
    {
        speed= 6f;
    }
  //  transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.8f, 2.8f), transform.position.y, transform.position.z);
 //Vector3 input = new Vector3(Mathf.Clamp((inputLeft + inputRight) * velocidade * Time.deltaTime, -2.8f, 2.8f), 0, 0);
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)&&Input.GetKey(KeyCode.UpArrow)){
            transform.position+= new Vector3(speed*Time.deltaTime,speed*Time.deltaTime,0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -42f,22f),Mathf.Clamp(transform.position.y, -2.8f, 3.8f) ,transform.position.z);
        }
        else if(Input.GetKey(KeyCode.RightArrow)&&Input.GetKey(KeyCode.DownArrow)){
            transform.position+= new Vector3(speed*Time.deltaTime,-speed*Time.deltaTime,0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -42f,22f),Mathf.Clamp(transform.position.y, -2.8f, 2.8f) ,transform.position.z);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)&&Input.GetKey(KeyCode.DownArrow)){
            transform.position+= new Vector3(-speed*Time.deltaTime,-speed*Time.deltaTime,0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -42f,22f),Mathf.Clamp(transform.position.y, -2.8f, 2.8f) ,transform.position.z);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)&&Input.GetKey(KeyCode.UpArrow)){
            transform.position+= new Vector3(-speed*Time.deltaTime,speed*Time.deltaTime,0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -42f,22f),Mathf.Clamp(transform.position.y, -2.8f, 3.8f) ,transform.position.z);
        }
        else if(Input.GetKey(KeyCode.UpArrow)){
            transform.position+= new Vector3(0,speed*Time.deltaTime,0);
            transform.position = new Vector3(transform.position.x,Mathf.Clamp(transform.position.y, -2.8f, 3.8f) ,transform.position.z);
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            transform.position+= new Vector3(0,-speed*Time.deltaTime,0);
            transform.position = new Vector3(transform.position.x,Mathf.Clamp(transform.position.y, -2.8f, 2.8f) ,transform.position.z);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position+= new Vector3(-speed*Time.deltaTime,0,0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -42.8f, 22f), transform.position.y,transform.position.z);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            transform.position+= new Vector3(speed*Time.deltaTime,0,0);
             transform.position = new Vector3(Mathf.Clamp(transform.position.x, -42.8f, 22f), transform.position.y,transform.position.z);
        }
    }
}
