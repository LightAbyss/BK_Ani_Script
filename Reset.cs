using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reset : MonoBehaviour{
   public Image restart;

    public void reiniciar(){
        SceneManager.LoadScene("Main");
    } 
}
