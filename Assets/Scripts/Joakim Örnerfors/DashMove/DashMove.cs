using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DashMove : MonoBehaviour
{

    PlayerController moveScript;

    public float dashSpeed;

    public float dashTime;

    // Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine(DashOne());
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine(DashTwo()); 
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            StartCoroutine(DashThree()); 
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            StartCoroutine(DashFour()); 
        }
    }

    IEnumerator DashOne()
    {
        float startTime = Time.time;

        while (Time.time < startTime + dashTime)
        {
            transform.Translate(Vector3.left * dashSpeed);

            yield return null;
        }
    }

    IEnumerator DashTwo()
     
         {
             float startTime = Time.time;
     
             while (Time.time < startTime + dashTime)
             {
                 transform.Translate(Vector3.right * dashSpeed);
     
                 yield return null;
             }
     
         }
    IEnumerator DashThree()

    {
        float startTime = Time.time;

        while (Time.time < startTime + dashTime)
        {
            transform.Translate(Vector3.forward * dashSpeed);

            yield return null;
        }

    }
    
    IEnumerator DashFour()

    {
        float startTime = Time.time;

        while (Time.time < startTime + dashTime)
        {
            transform.Translate(Vector3.back * dashSpeed);

            yield return null;
        }

    }




}    