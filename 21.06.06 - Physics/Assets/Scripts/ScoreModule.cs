using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class ScoreModule : MonoBehaviour
{
    public Text m_Text;

    private int m_Count = 0;

    void Start()
    {
        m_Text.text = "Score : 0";

    }

    public void AddCount()
    {
        m_Count++;

        m_Text.text = "Score : " + m_Count.ToString();
    }

}
