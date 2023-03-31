using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoScript : MonoBehaviour{
    public VideoPlayer video;
    
    void Awake() {
        video = GetComponent<VideoPlayer>(); //Variable que apunta al objeto video
        video.Play(); //Reproducir video
        video.loopPointReached += Finish; //Cuando el video acabe, llamar funcion "Finish"
    }
    //Al finalizar ir al panel frontal
    void Finish(VideoPlayer vp){
        SceneManager.LoadScene("Frontal");
    }
}
