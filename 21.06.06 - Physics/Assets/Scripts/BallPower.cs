using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public class BallPower : MonoBehaviour
{

    public float m_Speed;
    public float m_Rotate;
    public Rigidbody m_rigid;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            m_Speed += 1000;
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_rigid.AddForce(0,0,m_Speed);
        }
    }
}
