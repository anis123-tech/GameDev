﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    private float speed = 30;
    private playerController playerControllerscript;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerscript = GameObject.Find("player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerscript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Ground "))
        {
            Destroy(gameObject);
        }
    }
}
