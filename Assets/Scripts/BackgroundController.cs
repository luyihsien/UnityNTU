using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BackgroundController : MonoBehaviour
{
    public Sprite dayBackground;
    public Sprite nightBackgroud;
    DateTime currentTime =DateTime.Now;
    // Start is called before the first frame update
    void Start()
    {
        if (currentTime.Hour>=6 && currentTime.Hour < 18){
            SetBackground(dayBackground);
        }
        else
        {
            SetBackground(nightBackgroud);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetBackground(Sprite background){
        SpriteRenderer spriteRenderer=GetComponent<SpriteRenderer>();
        spriteRenderer.sprite=background;
    }
}
