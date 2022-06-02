using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour
{
    public float damageArea;
    public Personaje[] enemigos;
    int indice = 0;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name);

        while (indice < enemigos.Length)
        {
            //Hacer Daño
            if (Vector3.Distance(enemigos[indice].transform.position,transform.position)< damageArea)
            {
                enemigos[indice].MakeDamage();

            }
           //enemigos[indice].MakeDamage();
                indice++;
        }
        indice = 0;
        

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
