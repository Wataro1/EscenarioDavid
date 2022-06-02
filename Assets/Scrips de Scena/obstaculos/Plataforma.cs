using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public GameObject platform;
    public GameObject button;
    public float velocity;
    public Transform minPosition;
    public Transform maxPositon;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        if(other !=null)
        {
            MovePlatform();
        }
    }
    private void MovePlatform()
    {
        platform.transform.Translate(Vector3.up * Time.deltaTime * velocity);
        if(platform.transform.position.y >=16)
        {
            velocity = -5;

        }
        if(platform.transform.position.y <=3)
        {
            velocity = 5;
        }
    }
    


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
