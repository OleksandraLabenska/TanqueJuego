using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDeBala : MonoBehaviour
{
    public float vel;

    void Update()
    {
        this.transform.Translate(0, 0, vel * Time.deltaTime);
    }
}
