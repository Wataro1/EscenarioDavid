using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update

    public void OnOpendoor()
    {
        anim.SetTrigger("Abre");
    }
    
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
