using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour{
    public Image play;

    public void inicio(){
        SceneManager.LoadScene("Intro");
    } 
}
