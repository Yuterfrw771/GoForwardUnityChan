﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    AudioSource audioSource2D;
    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadline = -10;


    // Start is called before the first frame update
    void Start()
    {
        //AudioSourceによる再生
        this.audioSource2D = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);


        //画面外に出たら破棄する
        if(transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name != "UnityChan2D")
        {
            this.audioSource2D.Play();
        }
    }
}
