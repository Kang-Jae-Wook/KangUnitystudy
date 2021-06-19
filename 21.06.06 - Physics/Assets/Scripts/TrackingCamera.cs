using System.Collections;
using UnityEngine;

public class TrackingCamera : MonoBehaviour
{
    public Transform m_Player;
    public Vector3 m_Offset;   

    void Update()
    {
        
        transform.position = new Vector3(m_Player.position.x + m_Offset.x,
            transform.position.y + m_Offset.y, m_Player.position.z + m_Offset.z);
    }
}