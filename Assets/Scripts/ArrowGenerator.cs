using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject arrowPrefab, gameDirector;
    public float span = 1.0f;
    float delta = 0;


    // Update is called once per frame
    void Update(){
        this.delta += Time.deltaTime;
        if(this.gameDirector.GetComponent<GameDirector>().difficulty > 5){
            Debug.Log("Lv Up");
            span *= 0.90f;
            this.gameDirector.GetComponent<GameDirector>().difficulty = 0;
        }
        if((this.delta > this.span) & !this.gameDirector.GetComponent<GameDirector>().over){
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6, 7);
            go.transform.Translate(px, 7, 0);
        }
    }
}
