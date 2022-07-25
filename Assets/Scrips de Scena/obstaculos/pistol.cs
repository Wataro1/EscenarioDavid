using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistol : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform canon;
    public GameObject bala;
    
    //public Transform Gun;
    public int Magasai = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1") && Magasai >0)
        {
          
            GameObject go = Instantiate(bala, canon.transform.position, canon.transform.rotation);
            go.GetComponent<Rigidbody>().AddForce(go.transform.forward, ForceMode.Impulse);

            Destroy(go, 2f);
            Magasai--;
            
        }
        if(Input.GetButtonDown("Re"))
        {
            Magasai = 5;     
        }
       /* if (Input.GetKeyDown(KeyCode.Mouse0) &&  Gun.childCount >0)
        {
            Disparo();
        }*/
    }
    /*private void Disparo()
    {
       GameObject go = Instantiate(bala, canon.transform.position, canon.transform.rotation);
        go.GetComponent<Rigidbody>().AddForce(go.transform.forward, ForceMode.Impulse); 
    }*/


    
}
