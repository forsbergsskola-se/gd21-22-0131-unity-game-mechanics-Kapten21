using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashJump : MonoBehaviour
{
    PlayerController moveScript;

    public float dashSpeed;
    public float maxDashTime;
    public float dashTime;
    public float MaxDashLenght;

    float WaitForSeconds;
    // Start is called before the first frame update
    void Start()
    
        {
            moveScript = GetComponent<PlayerController>();
        }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            StartCoroutine(DashOne());
            
        }
    }
    
    IEnumerator DashOne()
    {
        float startTime = Time.time;

        while (Time.time < startTime + dashTime)
        {
            transform.Translate(Vector3.up * dashSpeed * maxDashTime * MaxDashLenght);

            yield return new WaitForSeconds(5);
        }
    }
    
}
