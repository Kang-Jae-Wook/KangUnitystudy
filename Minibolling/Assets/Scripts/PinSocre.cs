using System.Collections;
using UnityEngine;

    public class PinSocre : MonoBehaviour
    {
    public Vector3 Pinsave;
    public bool isCheck = false;
    public Rigidbody m_plane;

    void Start()
    {
        Pinsave = transform.position;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
//      if(collision.rigidbody)

        if (collision.gameObject.GetComponent<PlayerOperation>())
        {
            GameObject up = GameObject.FindWithTag("Score");
            ScoreModule point = up.GetComponent<ScoreModule>();

            point.Addcount();
        }
    }

    //private void 
    //{
       

    //    if (Collision.)
    //    {
    //        isCheck = true;
    //    }

    //    if (isCheck)
    //    {
    //        GameObject up = GameObject.Find("Score");
    //        ScoreModule point = up.GetComponent<ScoreModule>();

    //        point.Addcount();
    //    }
}
    
