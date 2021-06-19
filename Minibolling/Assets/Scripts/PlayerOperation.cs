using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOperation : MonoBehaviour
{
    public float m_Speed;
    public Rigidbody m_Move;

    void Update()
    {
 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Move.AddForce(0, 0, m_Speed);
        }
        
        
    }
}
