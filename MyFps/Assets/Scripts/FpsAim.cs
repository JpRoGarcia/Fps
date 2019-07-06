using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsAim : MonoBehaviour
{
    //Se crean dos variables de tipo flotante
    float mouseX;
    float mouseY;

    public bool InvertedMouse;// Se crea una variable de tipo booleano.

    void Update()
    {
       
        mouseX += Input.GetAxis("Mouse X");// Se accede al input para ver la posicion de X.  

        if (InvertedMouse)//Se creo para poder invertir la camara del eje Y.
        {
            mouseY += Input.GetAxis("Mouse Y");// Se accede al input para ver la posicion de Y.  
        } else
        {
            mouseY -= Input.GetAxis("Mouse Y");// Se accede al input para ver la posicion de Y.  
        }

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);//Se accede al eulerAngles y se le asigna un vector donde cambia X y Y.

    }
}
