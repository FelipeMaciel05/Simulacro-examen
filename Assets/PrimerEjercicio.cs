using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerEjercicio : MonoBehaviour
{
    //1.Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.


    public int n1;
    public int n2;
    // Start is called before the first frame update
    void Start()
    {
        if (n1 == n2)
        {
            Debug.Log("tu numero es igual");
        }
        else
        {
            Debug.Log("tu numero no es igual, vuelve a ingresarlos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
