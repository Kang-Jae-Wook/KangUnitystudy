using System.Collections;
using UnityEngine;
using UnityEngine.UI;

    public class ScoreModule : MonoBehaviour
    {
        public Text m_Text;
        public int m_Count = 0;
        
        void Start()
        {
            m_Text.text = "Score = 0";
        }

    // Update is called once per frame
        public void Addcount()
        {
            m_Count++;

            m_Text.text = "Score = " + m_Count.ToString();

        }
    }
