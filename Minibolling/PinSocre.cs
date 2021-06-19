using System.Collections;
using UnityEngine;

    public class PinSocre : MonoBehaviour
    {

       
        void Update()
        {
        GameObject up = GameObject.Find("Score");
        ScoreModule point = up.GetComponent<ScoreModule>();

        point.Addcount();
        }
    }
