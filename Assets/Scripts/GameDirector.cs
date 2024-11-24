using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject arrow,hpGauge,ReplayButton, ArrowGenerator;
    [SerializeField] int Maxhp;
    public int difficulty = 0, count = 0;
    int hp;
    public bool over = false;
    void Start(){
        hp=Maxhp;
    }
    void Update(){
        if(hp == 0){
            over = true;
            ReplayButton.SetActive(true);
        }
    }
    // Update is called once per frame
    public void DecreaceHp(int value){
        hp -= 1;
        this.hpGauge.GetComponent<Image>().fillAmount -= 1.0f*value/Maxhp;
        this.ArrowGenerator.GetComponent<ArrowGenerator>().span = 1.0f;
    }

    public void onClick(){
        over = false;
        SceneManager.LoadScene("GameScene");
    }
}
