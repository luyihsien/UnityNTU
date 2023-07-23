using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetScore : MonoBehaviour
{
    int score =0;
    [SerializeField] float delayDestroy = 0.5f;
    [SerializeField] TextMeshProUGUI scroreText;
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision!");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("123443234321234321");
        if (other.tag=="Positive"){
            score+=1;
            scroreText.text=$"Score : {score}";
            Destroy(other.gameObject,delayDestroy);
        }
        else if (other.tag=="Negative"){
            score-=1;
            scroreText.text=$"Score : {score}";
            Destroy(other.gameObject,delayDestroy);
        }
    }
}
