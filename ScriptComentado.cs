using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NewBehaviourScript : MonoBehaviour
{
   
   public TextMeshProUGUI texto;
   
   //Variables para el funcionamiento del codigo
   public int acelerador;

   public string freno;


    // Tipo de clase que sirve para dar comienzo a las instrucciones
    void Start()
    {
        texto.text="Acelera";
    }

    // Segundo tipo de clase que sirve como complemento de la primera, se utilizan mas condiciones para ver resultados
    void Update()
    {
        //Instruccion que sirve para acelerar si se presiona la tecla W
        if (Input.GetKey(KeyCode.W))
        {
            //La variable "acelarador" avanzara cada vez mas, de uno en uno
            acelerador++;
            //Condicion que permite solo acelerar hasta un conteo maximo de 200
            if(acelerador >= 200){
                acelerador=200;
                texto.text = acelerador.ToString();
            }
           
        }
//Instruccion que sirve para frenar si se suelta la tecla W
        if (Input.GetKeyUp(KeyCode.W))
        {
            //Cuando se frene, se mostrara el texto "frenaste"
            texto.text=freno;
        }
         
          //texto.text= acelerador.ToString();
    }
}
