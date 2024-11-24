using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowController : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player, gameDirector, Score;
    Vector2 dir;
    float r1=0.5f,r2=1.0f,d;
    void Start(){
        this.player = GameObject.Find("player");
        this.gameDirector = GameObject.Find("GameDirector");
        this.Score = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update(){
        if(!this.gameDirector.GetComponent<GameDirector>().over){
            transform.Translate(0, -0.1f, 0);
        }
        if (transform.position.y < -5.0f){
            this.gameDirector.GetComponent<GameDirector>().difficulty += 1;
            this.gameDirector.GetComponent<GameDirector>().count += 1;

            Text S = this.Score.GetComponent<Text>();
            S.text = "分數:"+(this.gameDirector.GetComponent<GameDirector>().count*100).ToString();
            Destroy(gameObject);
        }
        dir = this.player.transform.position-transform.position;
        d=dir.magnitude;
        if(d<r1+r2){
            Destroy(gameObject);
            gameDirector.GetComponent<GameDirector>().DecreaceHp(1);
        }
    }
}
