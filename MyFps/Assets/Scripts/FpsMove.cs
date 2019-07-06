using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsMove : MonoBehaviour
{

    public GameObject a ;// Se crea un objeto publico;

    public float speed = 0.1f;//Se crea una variable de tipo flotante;

    void Update()
    {   
       if (Input.GetKey(KeyCode.W))//Se accede al input para detectar el ingreso del teclado
        {
            transform.position +=  transform.forward * speed;//Se accede a la posicion del objeto y se le dice que avance hacia adelante y esta se multiplica por la velocidad.      
        }

        if (Input.GetKey(KeyCode.S))//Se accede al input para detectar el ingreso del teclado
        {
            transform.position -= transform.forward * speed; //Se accede a la posicion del objeto y se le dice que avance hacia atras y esta se multiplica por la velocidad.
        }

        if (Input.GetKey(KeyCode.A))//Se accede al input para detectar el ingreso del teclado
        {
            transform.position -= transform.right * speed; //Se accede a la posicion del objeto y se le dice que avance hacia la izquierda y esta se multiplica por la velocidad.
        }

        if (Input.GetKey(KeyCode.D))//Se accede al input para detectar el ingreso del teclado
        {
            transform.position += transform.right * speed; //Se accede a la posicion del objeto y se le dice que avance hacia la Derecha y esta se multiplica por la velocidad.
        }

        float Rotar = a.transform.eulerAngles.y;//Se crea un flotante y se le agrega la posicion del eje Y del objeto;
        transform.rotation = Quaternion.Euler(0.0f, Rotar, 0.0f);//Se accede a la rotacion y se le cambia la rotacion del eje Y;

    }
}
