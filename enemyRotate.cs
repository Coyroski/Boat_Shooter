﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform[] target;
    public float speed;

    private int current;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);   
            //print("WOrking");
           // print("working02");
        }
        else
            nexttarget();

        transform.LookAt(target[current].position);
    }

     void nexttarget()
    {
        current = (current + 1) % target.Length;
        Debug.Log(current);
    }

}
