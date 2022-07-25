using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Mv))]
public class Enemy : MonoBehaviour
{
    public Mv movement;
    public Transform jugador;
    public float rango = 30;
    private float distance;
    
    // Update is called once per frame
    void Update()
    {
       
        distance = Vector3.Distance(transform.position, jugador.position);
    
        if(distance<=rango)
        {
            if(Vector3.Dot((jugador.position- transform.position).normalized,transform.TransformDirection(Vector3.forward).normalized)<0.98f)
            {
                if (Vector3.Dot((jugador.position-transform.position).normalized,transform.TransformDirection(Vector3.right).normalized)> 0f)
                {
                    movement.Rotación(1f);
                }
                else
                {
                    movement.Rotación(-1f);
                }
            }
        movement.Move(1, 0);
        }
    }
    
        
}   
   
