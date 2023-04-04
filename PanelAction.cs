using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelAction : MonoBehaviour{
    public Image modo;
    public Sprite ind,ser,par;

    public Text id_modo;
    
    //Declaracion de variables
    bool B2_State = false,B3_State = false;
/**************************************************************************************************/
    
    public void config(bool estado, int ID){
        //Actualizacion del estado de los botones
        if(ID == 1){
            B2_State = estado;
        }else if(ID == 2){
            B3_State = estado;
        }

        //"Cambio" de modo dependiendo de los botones
        if(B2_State){
            if(B3_State){
                modo.sprite = par;
                id_modo.text = "2";
            }else{
                modo.sprite = ser;
                id_modo.text = "1";
            }
        }else{
            modo.sprite = ind;
            id_modo.text = "0";
        }
    }

}
