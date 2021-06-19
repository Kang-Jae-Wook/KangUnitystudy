using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float m_Speed = 10.0f;
    public Vector3 m_Axis = Vector3.zero;

    private void Update()
    {
        //  포지션과 축 기준으로 회전한다
        transform.RotateAround(transform.localPosition, m_Axis, m_Speed);
    }

    //  내가 트리거 상태일 경우 반드시 이 함수를 사용
    private void OnTriggerEnter(Collider collision)
    {
        //  Hierarchy 창에 있는 오브젝트 리스트에서 Score Text 라는 이름의 객체를 찾는다
        GameObject go = GameObject.Find("Score Text");

        //  찾은 객체 안에 ScoreModule 이라는 컴포넌트를 가지고 온다
        ScoreModule module = go.GetComponent<ScoreModule>();

        //  ScoreModule.AddCount() 함수 호출!
        module.AddCount();
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //Destroy(gameObject);
    //}

    //  내가 콜라이더 상태일 경우 이 함수 사용
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Destroy(gameObject);
    //}

}
