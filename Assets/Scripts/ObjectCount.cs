using System.Collections;
using UnityEngine;




public class ObjectCount : MonoBehaviour

{
    public Transform m_plane;
    public Vector3 m_SavePosition;
    public Vector3 m_SaveRotation;
    public bool m_isCheck;

    private void Start()
    {
        m_SavePosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
        m_SaveRotation = new Vector3(transform.localRotation.x, transform.localRotation.y, transform.localRotation.z);
        m_isCheck = true;
    }

    private void Update()
    {
        Vector3 m_CheckPlane = new Vector3(m_plane.position.x, m_plane.position.y, m_plane.position.z);
        if(transform.localPosition.y <= -50)
        {
            CountScore point = FindObjectOfType<CountScore>();

            point.Addcount();

            m_isCheck = false;
            gameObject.SetActive(false);

            ObjectLifeCheck Life = FindObjectOfType<ObjectLifeCheck>();
            Life.LifeCount();

            if (Life.ObjectCount >= 12)
            {


                gameObject.transform.localPosition = new Vector3(m_SavePosition.x, m_SavePosition.y, m_SavePosition.z);
                gameObject.transform.localEulerAngles = new Vector3(m_SaveRotation.x, m_SaveRotation.y, m_SaveRotation.z);
                //                    (m_SaveRotation.x, m_SaveRotation.y, m_SaveRotation.z);
               
                Life.ObjectCount = 0;
            }

        }

    }




}
