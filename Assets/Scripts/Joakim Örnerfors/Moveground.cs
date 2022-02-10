using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveground : MonoBehaviour
{
    
    public float m_speed = 20f;
    private Rigidbody m_rigidbody;
 
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }
 
    void FixedUpdate()
    {
        // Makes this object move forward at X speed.
        m_rigidbody.velocity = m_speed * transform.forward;
    }
}
