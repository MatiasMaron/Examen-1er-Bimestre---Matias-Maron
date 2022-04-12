using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TICapalooza2 : MonoBehaviour
{
    //Campo son 20.400 entradas a $1200 cada una y Platea son 16.200 entradas a $2000 cada una//

    public int EntradasCampo;
    public int EntradasPlatea;
    int EntradasTotal;

    int RecaudacionCampo;
    int RecaudacionPlatea;
    int RecaudacionTotal;

    int EntradasCampoVacantes;
    int EntradasPlateaVacantes;
    int EntradasVacantes;
    // Start is called before the first frame update
    void Start()
    {
        EntradasTotal = EntradasCampo + EntradasPlatea;
        if( ! (EntradasTotal == 0) || ! (EntradasTotal < 36600))
        {
            RecaudacionCampo = EntradasCampo * 1200;
            RecaudacionPlatea = EntradasPlatea * 2000;
            RecaudacionTotal = RecaudacionCampo * RecaudacionPlatea;

            Debug.Log("La recaudación total es de:");
            Debug.Log("Recaudación Campo: " + RecaudacionCampo);
            Debug.Log("Recaudación Platea: " + RecaudacionPlatea);
            Debug.Log("Recaudación Total: " + RecaudacionTotal);

            if(EntradasCampo == 20400 && EntradasPlatea == 16200)
            {
                Debug.Log("Sold Out!!!");
            }
            else
            {
                EntradasCampoVacantes = 20400 - EntradasCampo;
                EntradasPlateaVacantes = 16200 - EntradasPlatea;
                EntradasVacantes = EntradasCampoVacantes + EntradasCampoVacantes;
                Debug.Log("La cantidad que entradas vacantes son: " +EntradasVacantes );
            }
        
            if(EntradasCampo + EntradasPlatea > 36600 / 2)
            {
                Debug.Log("El festival fue un éxito!");
            }
            else
            {
                Debug.Log("Debemos mejorar la convocatoria");
            }
        }
        else
        {
            Debug.Log("Ingrese una cantidad de entradas valida, el minimo es 0 y el maximo 20.400 en Campo y 16.200 en Platea");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
