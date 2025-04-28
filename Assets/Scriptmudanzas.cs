using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptmudanzas : MonoBehaviour
{
    public float peso;
    public float distancia;
    // Start is called before the first frame update
    void Start()
    {
        float horas = distancia / 25;



        if (peso < 100)
        {
            Debug.Log("Cantidad de kilos de carga muy baja");
            return;
        }
        if (peso > 10000)
        {
            Debug.Log("Cantidad de kilos de carga muy alta");
            return;
        }
        if (distancia < 1)
        {
            Debug.Log("La distancia no puede ser menor a 1km");
            return;
        }
        if (horas < 2)
        {
            horas = 2;
        }
        if (distancia > 50)
        {
            horas = horas + 1;
        }

        float unitarioprecio = horas * 3000;
        float pickupprecio = horas * 4500;
        float camionprecio = horas * 7000;


        if (peso < 2000)
        {
            Debug.Log("El vehiculo que necesitas es un unitario");
            Debug.Log("Tardara" + horas + "horas en llegar");
            Debug.Log("La mudanza costara" + unitarioprecio);
            return;
        }
        else if (peso > 2000)
        {
            Debug.Log("El vehiculo que necesitas es un pickup");
            Debug.Log("Tardara" + horas + "horas en llegar");
            Debug.Log("La mudanza costara" + pickupprecio);
            return;
        }
        else if (peso > 5000)
        {
            Debug.Log("El vehiculo que necesitas es un camion");
            Debug.Log("Tardara" + horas + "horas en llegar");
            Debug.Log("La mudanza costara" + camionprecio);
            return;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
