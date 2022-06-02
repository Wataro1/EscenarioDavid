using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinteration : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource indicador;
    public EsdJugador playerState;
    //public float force;
    public Transform cameraPlayer;
    public Transform objetoVacio;
    public LayerMask lm;
    public LayerMask Ml;
    private void OnTriggerEnter(Collider other)
    {
        // reproducción de la animación de la puerta 
        if (other.tag == "Door" && playerState.pastillasCount >= 2)
         other.GetComponentInParent<Door>().OnOpendoor();
        
        //reprodución del sonido al tocar las pastillas 
        if (other.tag == "Pastillas")
        {
           other.gameObject.SetActive(false);

            if  (gameObject.activeSelf == true)
            {
                Instantiate(indicador);
            }
            playerState.pastillasCount++;

        }
        
    }


    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Caja")
        {
            Debug.Log("Entra");
            foreach (ContactPoint cp in collision.contacts)
            {
                collision.transform.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * force, ForceMode.Impulse);
            }
        }


    }*/
    private void OnTriggerStay(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(cameraPlayer.position, cameraPlayer.forward, Color.black);
        RaycastHit hit;
        if (Physics.Raycast(cameraPlayer.position,cameraPlayer.forward, out hit,4f ,lm))
        {
            
            if (Input.GetButton("Fire2"))
            {
                bool coger = true;
                if (coger == true) 
                {
                    hit.transform.parent = objetoVacio;
                    hit.transform.localPosition = Vector3.zero;
                    Debug.Log(hit.transform.name);
                }
                if (Input.GetButton("Fire2"))
                {
                    coger = false ;
                    if (coger == false)
                    {
                        hit.transform.parent = null;
                    }
                    
                }
            }
        }
        if (Physics.Raycast(cameraPlayer.position, cameraPlayer.forward, out hit, 4f, Ml))
        {
            if(objetoVacio.childCount >0 && Input.GetButtonDown("Fire2"))
            {
                objetoVacio.GetComponentInChildren<Rigidbody>().isKinematic = false;
                objetoVacio.GetChild(0).transform.parent = null;
               // objetoVacio.GetComponentInChildren<Transform>().parent = null;
            }
            if(Input.GetButtonDown("Fire2"))
            {
                hit.transform.GetComponent<Rigidbody>().isKinematic = true;
                hit.transform.parent = objetoVacio;
                hit.transform.localPosition = Vector3.zero;

                Debug.Log(hit.transform.name);
            }
        }


    }
}
