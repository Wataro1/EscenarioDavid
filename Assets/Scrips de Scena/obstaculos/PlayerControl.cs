using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Mv))]
public class PlayerControl : MonoBehaviour
{
    [Header("Movimiento Camara")]
    public Vector2 mouseMovement;
    public Camera playerCamera;
    public float yRotion, sensibilidad;
    public float xRotion;
    

    [Header("llamar el scrit")]
    public Mv Desplazo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Desplazo.Move(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
        Desplazo.Rotación(Input.GetAxis("Mouse X"));
        mouseMovement = new Vector2(Input.GetAxis("Mouse X") * sensibilidad, Input.GetAxisRaw("Mouse Y"));
        yRotion -= mouseMovement.y;
        
        xRotion = Mathf.Clamp(yRotion, -40, 40);

        playerCamera.transform.localRotation = Quaternion.Euler(xRotion, 0, 0);

    }
}
