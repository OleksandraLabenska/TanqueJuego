using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentaAtras : MonoBehaviour
{
    public int tiempo;
    public TextMesh texto;

    void Update()
    {
        //Aqui he hecho lo que nos pide para el script en positivo
        //establesemos el tiempo en el inspector y luego si el tiempo es mas de 0, cada frame restamos 1 unidad y tambien lo muestro en la pantalla
        if (tiempo > 0)
        {
            tiempo--;
            string textPrint = tiempo.ToString();
            texto.text = textPrint;
        }
        //cuando el tiempo ha llegado a 0, el tanque no podra ni moverse, ni disparar
        //Mostramos por la pantalla y por la consola que el tanque se ha quedado sin gasolina
        else
        {
            Debug.Log("Te has quedado sin gasolina!");
            texto.text = "Te has quedado sin gasolina!";
        }
    }

}
