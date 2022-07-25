using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Mv : MonoBehaviour
{
    [Header("Movimiento del personaje")]
    public float spedMovement;
    public Vector3 direcion;
    public CharacterController controller;
    public float gravedad = -9.8f;

    [Header("Salto del personaje ")]
    public float JumpHeight;
    public Vector3 des;

    public float yRotation;



    void Update()
    {
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
    }

    public void Move(float Vertical, float Horizontal)
    {

        direcion.x = Horizontal;
        direcion.z = Vertical;

        direcion = transform.TransformDirection(direcion);
        controller.Move(direcion * Time.deltaTime * spedMovement);
    }

    public void Rotación(float Rotacionvalue)
    {
        yRotation += Rotacionvalue;
        controller.transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }

    
    
}
