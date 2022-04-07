using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundoEjercicio : MonoBehaviour
{
    //2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.

    public int precio1;
    public int precio2;
    public int precio3;
    public int montototal;
    // Start is called before the first frame update
    void Start()
    {
        int sumadeprecios;
        int sobra;
        int falta;
        sumadeprecios = precio1 + precio2 + precio3;
        if (sumadeprecios < montototal)
        {
            Debug.Log("No supera el limite establecido");
            sobra = montototal - sumadeprecios;
            Debug.Log("Sobran " + sobra);
        }
        else
        {
            Debug.Log("supera el limite establecido");
            falta = sumadeprecios - montototal;
            Debug.Log("Faltan " + falta);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
