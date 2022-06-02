using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    // Start is called before the first frame update

    public float vidaMaxima = 100;
    public float damage = 20;
    public float vidaActual;
    void Start()
    {
        vidaActual = vidaMaxima;
    }

    public void MakeDamage()
    {

        vidaActual = vidaActual - damage;
        if (vidaActual==0)
        {
            //Desativar enemigos 
            gameObject.SetActive(false);
        }
         



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
