using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mv : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Movimiento del personaje")]
    public float spedMovement;
    public Vector3 Direcion;
    public CharacterController controller;
    public float gravedad = -9.8f;
   
    [Header("Movimiento Camara")]
    public Vector2 mouseMovement;
    public Camera playerCamera;
    public float yRotion;
    public float xRotion;

    [Header("Salto del personaje ")]
    public float JumpHeight;
    public Vector3 des;
    
    
    

    // Update is called once per frame
    void Update()
    {

        
        Direcion.x = Input.GetAxis("Horizontal");
        Direcion.z = Input.GetAxis("Vertical");
        des.y+= gravedad * Time.deltaTime;

        if(controller.isGrounded && des.y<0)
        {
            des.y = -2f;
        }
        //controller.Move(Direcion);

        Direcion = transform.TransformDirection(Direcion);
        controller.Move(Direcion * Time.deltaTime * spedMovement);

        mouseMovement.x = Input.GetAxis("Mouse X");
        mouseMovement.y = Input.GetAxis("Mouse Y");
        xRotion -= mouseMovement.y;
        yRotion += mouseMovement.x;
        
        /*
        if(xRotion>40)
        {
            xRotion = 40;
        }
        if(xRotion<-40)
        {
            xRotion = -40;
        }*/
        /*if (yRotion>40)
        {
            yRotion = 40;
        }
        if (yRotion<-40)
        {
            yRotion = -40; 
        }*/
        xRotion = Mathf.Clamp(xRotion, -40, 40);

        playerCamera.transform.localRotation = Quaternion.Euler(xRotion, 0, 0);
        controller.transform.rotation = Quaternion.Euler(0, yRotion, 0);

        des.y += gravedad * Time.deltaTime;
        controller.Move(des * Time.deltaTime);
        if (controller.isGrounded && des.y < 0)
        {
            des.y = -2f;
        }
        if (controller.isGrounded && Input.GetButton("Jump"))
        {
            des.y = Mathf.Sqrt(JumpHeight * -2f * gravedad);
        }





        // cosas extras para la consola 

        /* if (Input.GetButtonDown("Fire1"))
         {
             Debug.Log("Se esta presionando el bonton del maus ");
         }

         Direcion.x = Input.GetAxis("Horizontal");
         if(Input.GetAxis("Horizontal")> 0.1f|| Input.GetAxis("Horizontal")<-0.1f)
         {
             Debug.Log("Direcion Positiva ");
         }  */
        Cursor.lockState = CursorLockMode.Locked;
        bool Scape = Input.GetKey(KeyCode.Escape);
        if (Scape == true)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        
    }
    
}
