using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtSwitch : MonoBehaviour{
    private PanelAction pan;

   //Identificador para el estado del boton
   bool estado = false;
   //Identifica si el boton es para los modos de operacion, o no
   public int ID_Bt;
   //"Apuntador" a la imagen/boton
   public Image disp;
   //Variables que guardan los sprites
   public Sprite push, notpush;

    void Start() {
        //Llamado del Script PanelAction vinculandolo a la "variable" pan
        pan = FindObjectOfType<PanelAction>();
    }

    //Metodo para el cambio de estado del boton
    public void Cambio(){
        if(!estado){
            estado = true;
            disp.sprite = push;
        }else if(estado){
            estado = false;
            disp.sprite = notpush;
        }

        if(ID_Bt != 0){
            pan.config(estado,ID_Bt);
        }
    }

}
