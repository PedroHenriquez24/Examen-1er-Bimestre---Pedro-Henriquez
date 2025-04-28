using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilaVirtual : MonoBehaviour
{
    public string tipoEntrada ;
    public int cantEntrada;
    public bool premium;
    // Start is called before the first frame update
    void Start()
    {
        if (tipoEntrada == "b")
        {
            if (cantEntrada > 0 & cantEntrada < 5)
            {
                Debug.Log($"Tipo de entrada: Básico - Cantidad: {cantEntrada} - Precio total: ${cantEntrada * 800}");
            }
            else
            {
                Debug.LogError("ERROR: No se puede ingresar mas de 4 entradas para Básico, ni menos de 0");
            }
        }
        else if (tipoEntrada == "n")
        {
            if (cantEntrada > 0 & cantEntrada < 7)
            {
                Debug.Log($"Tipo de entrada: Normal - Cantidad: {cantEntrada} - Precio total: ${cantEntrada * 1200}");
            }
            else
            {
                Debug.LogError("ERROR: No se puede ingresar mas de 6 entradas para Normal, ni menos de 0");
            }
        }
        else if (tipoEntrada == "p")
        {
            if (cantEntrada > 0)
            {
                if (premium == true)
                {
                    Debug.Log($"Tipo de entrada: Premium - Cantidad: {cantEntrada} - Precio total: ${(cantEntrada * 2000)*1.5}");

                }
                else
                {
                    Debug.Log($"Tipo de entrada: Premium - Cantidad: {cantEntrada} - Precio total: ${cantEntrada * 2000}");
                }
            }
            else
            {
                Debug.LogError("ERROR: No se puede ingresar menos de 0 entradas");
            }
        }
        else
        {
            Debug.LogError("ERROR: Código ingresado no válido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
