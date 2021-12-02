using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTanque : MonoBehaviour
{
    public float tiempoEntreDisparos;
    public float vel;
    public float velRot;
    public GameObject balaOriginal;
    public GameObject puntoDeDisparo;
    public GameObject referenciaCuentaAtras;
    public bool disparoPrep;

   
    void Update()
    {
        //Buscamos la referencia tiempo del script CuentaAtras
        int num = referenciaCuentaAtras.GetComponent<CuentaAtras>().tiempo;
       
        if (num > 0)
        {
            //Controlers del tanque, asignamos como va a moverse el tanque respecto a que tecla esta pulsada 

            if (Input.GetKey(KeyCode.W))
            {
                this.transform.Translate(0, 0, vel * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                this.transform.Translate(0, 0, -vel * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                this.transform.Rotate(0, velRot, 0);
            }

            if (Input.GetKey(KeyCode.A))
            {
                this.transform.Rotate(0, -velRot, 0);
            }


            //En esta parte he hecho lo que pide para la cadencia de disparo
            //primero contamos el tiempo entre disparo y disparo con deltaTime
            //Luego podemos disparar con la tecla space, pero si el tiempo a llegado a 1
            //Cuando el tiempo esta en 1 lo volvemos a poner a 0
            tiempoEntreDisparos += Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (tiempoEntreDisparos > 1)
                {
                    tiempoEntreDisparos = 0;
                    GameObject g = Instantiate(balaOriginal, puntoDeDisparo.transform.position, this.transform.rotation);

                    //Añadimos la fuerza a la bala
                    g.GetComponent<Rigidbody>().AddForce(g.transform.forward * 200);
                }
            }
        }
    }
}
