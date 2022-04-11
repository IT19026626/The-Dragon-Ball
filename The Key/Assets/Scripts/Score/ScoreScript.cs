using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    public int ScoreNum;
    [SerializeField] private AudioClip pickupsound;


    // Start is called before the first frame update
    void Start()
    {
        
        ScoreNum = 0;
        MyscoreText.text = "Score :  " + ScoreNum;

    }
    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "MyCoin")
        {
            SoundManager.instance.PlaySound(pickupsound);
            ScoreNum += 1;
            Destroy(Coin.gameObject);
            MyscoreText.text = "Score : " + ScoreNum;
        }
    }

}  
