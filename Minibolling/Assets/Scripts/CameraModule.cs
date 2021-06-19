using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class CameraModule : MonoBehaviour
    {
        public Transform m_Player;
        public Vector3 m_Offset;


        void Update()
        {
            transform.position = new Vector3(m_Player.position.x + m_Offset.x,
                m_Player.position.y + m_Offset.y, 
                m_Player.position.z + m_Offset.z);
        }
    }
}