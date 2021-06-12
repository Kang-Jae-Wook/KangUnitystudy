using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class CountScore : MonoBehaviour
{
    public Text m_Score;
    public int m_Count;

    void Start()
    {
        m_Score.text = "Count : " + m_Count;
    }

    public void Addcount()
    {
        m_Count++;
        m_Score.text = "Count : " + m_Count.ToString();
    }
}
