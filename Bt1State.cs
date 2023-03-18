using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bt1State : MonoBehaviour{
    //Creacion de la "variable" pan
    private PanelAction pan;
    //Variable para indicar cual botón es. Se deja en public para asignar su valor en la interfaz de Unity
    public int val;

    void Start() {
        //Llamado del Script PanelAction vinculandolo a la "variable" pan
        pan = FindObjectOfType<PanelAction>();
    }

    //Función llamada cada vez que se oprime el botón
    public void B_Sw(){
        //Antes de ejecutar, se verifica que pan esté "apuntando" al Script PanelAction
        if(pan != null){
            pan.Sw_State(val);
        }else{
            Debug.Log("Error");
        }
    }
}
