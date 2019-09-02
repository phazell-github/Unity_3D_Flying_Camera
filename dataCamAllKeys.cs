using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataCamAllKeys : MonoBehaviour
{
    public float movementSpeed = 5f;    
    public float movementMaxSpeed = 100.0F;
    public float rotationSpeed = 2F;
    public float reset_x = 0.0f;
    public float reset_y = 0.0f;
    public float reset_z = 0.0f;
        
    private float acceleration = 10.0F;
    private float totalRun = 1.0f;
    private float yaw = 0f;
    private float pitch = 0f;
    private bool resetCheck = false;

    private Vector3 GetInputMovement() {
        Vector3 p_velocity = new Vector3();
        //Forwards
        if (Input.GetKey(KeyCode.W))
        {
            p_velocity += new Vector3(0, 0, 1f);
        }
        //Backwards
        if (Input.GetKey(KeyCode.S))
        {
            p_velocity += new Vector3(0, 0, -1F);
        }
        //Left
        if (Input.GetKey(KeyCode.A))
        {
            p_velocity += new Vector3(-1f, 0, 0);
        }
        //Right
        if (Input.GetKey(KeyCode.D))
        {
            p_velocity += new Vector3(1f, 0, 0);
        }
        //Up
        if (Input.GetKey(KeyCode.PageUp)) {
            p_velocity += new Vector3(0, 1f, 0);
        }
        //Down
        if (Input.GetKey(KeyCode.PageDown)) {
            p_velocity += new Vector3(0, -1f, 0);
        }        
        return p_velocity;
    }
    
    private Quaternion GetInputRotation() {
        float newYaw = yaw;
        float newPitch = pitch;
        //y axis rotation
        if (Input.GetKey(KeyCode.RightArrow)) {
            newYaw += rotationSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            newYaw -= rotationSpeed;
        }
        //x axis rotation
        if (Input.GetKey(KeyCode.UpArrow)) {
            newPitch -= rotationSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            newPitch += rotationSpeed;
        }
        //reset
        if (Input.GetKey(KeyCode.Z)) {
            newPitch = 0f;
            newYaw = 0f;
        }
        yaw = newYaw;
        pitch = newPitch;
        Quaternion output = Quaternion.Euler(pitch, yaw, 0f);
        return output;
    }
    
    // Update is called once per frame
    void Update()
    {
        //Movement
        if (Input.GetKey(KeyCode.X)) {
            Vector3 r = new Vector3(reset_x, reset_y, reset_z);
            transform.position = r;
        }
        else{ 
            Vector3 p = GetInputMovement();
            if (Input.GetKey(KeyCode.Space))
            {
                totalRun += Time.deltaTime;
                p *= totalRun* acceleration;
                p.x = Mathf.Clamp(p.x, -movementMaxSpeed, movementMaxSpeed);
                p.y = Mathf.Clamp(p.y, -movementMaxSpeed, movementMaxSpeed);
                p.z = Mathf.Clamp(p.z, -movementMaxSpeed, movementMaxSpeed);
            }
            else
            {
                totalRun = Mathf.Clamp(totalRun * 0.5f, 1f, 1000f);
                p *= movementSpeed;
            }
            p *= Time.deltaTime;
            Debug.Log(p);
            transform.Translate(p);
        }
        //Rotation
        transform.rotation = GetInputRotation();

    }
}
