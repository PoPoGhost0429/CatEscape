using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject gameDirector;
    void Start(){
        Application.targetFrameRate = 60;
        this.gameDirector = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update(){
        if(!this.gameDirector.GetComponent<GameDirector>().over){
            if(Input.GetKeyDown(KeyCode.LeftArrow)){
                transform.Translate(-3,0,0);
            }

            if(Input.GetKeyDown(KeyCode.RightArrow)){
                transform.Translate(3,0,0);
            }
        } 
    }
    public void LButton(){
        if(!this.gameDirector.GetComponent<GameDirector>().over){
            transform.Translate(-3,0,0);
        }
    }
    public void RButton(){
        if(!this.gameDirector.GetComponent<GameDirector>().over){
            transform.Translate(3,0,0);
        }
    }
    
}
