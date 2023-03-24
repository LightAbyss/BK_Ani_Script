using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelAction : MonoBehaviour{
    //Declaracion de objetos
    public Text text;

    //Declaracion de variables
    bool B1_State = false,B2_State = false,B3_State = false,B4_State = false,B5_State = false;
    string ind,ser,par;
    //Declaracion de sprites para imágenes
    public Sprite test, prueba;

    // Start is called before the first frame update
    void Start(){
        //Inicializacion de variables
        ind = "Modo: Independiente";
        ser = "Modo: Serie";
        par = "Modo: Paralelo";
    }
/*************************************************************************************************/
//Organizador de los estados
/*
NOTA: Este métod se utiliza ya que al vincular el Script Bt1State a cada uno de los botones, las varibles son relativas al objeto.
Gracias a esto, se deseñó un solo script que solo conozca cual botón es (si el 1, 2, 3...), y cada vez que se oprime el botón
se llama la función de abajo pasando como parámetro qué botón es
*/
    public void Sw_State(int n, Image B){
        switch(n){
            case 1: //Cambio de estados y actualización de sprites
                if(!B1_State){
                    B1_State = true;
                    B.sprite = test;
                }else if(B1_State){
                    B1_State = false;
                    B.sprite = prueba;
                }
                break;
            case 2:
                if(!B2_State){
                    B2_State = true;
                }else if(B2_State){
                    B2_State = false;
                }
                config();
                break;
            case 3:
                if(!B3_State){
                    B3_State = true;
                }else if(B3_State){
                    B3_State = false;
                }
                config();
                break;
            case 4:
                if(!B4_State){
                    B4_State = true;
                }else if(B4_State){
                    B4_State = false;
                }
                break;
            case 5:
                if(!B5_State){
                    B5_State = true;
                }else if(B5_State){
                    B5_State = false;
                }
                break;
        }
    }

    //"Cambio" de funcionalidad dependiendo de los botones
    void config(){
        if(B2_State){
            if(B3_State){
                text.text = par;
            }else{
                text.text = ser;
            }
        }else{
            text.text = ind;
        }
    }

}
