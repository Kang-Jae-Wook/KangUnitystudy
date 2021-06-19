using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//  직렬화 ?
//  System.Serializable
//  클래스 또는 구조체 (객체) 에서만 사용할 수 있다
//  명시 (내가 직접 코드 치는 작업) 하지 않아도 public 이면 자동으로 붙는다 (암묵적)
//  ? public class 이면 자동으로 붙어버림

//  유니티 기준
//  직렬화가 되면 유니티 안에 있는 씬과 동기화 된다

[System.Serializable]
public class BallMovement : MonoBehaviour
{
    //  C++
    //  public:
    //  float ...

    //  C#
    //  [접근 제한자] [자료형] [변수명] 값
    //  private Vector3 변수명 = 값
    //  public float 변수명 = 값
    
    //  직렬화 필드
    //  SerializeField ?
    //  변수를 직렬화 한다
    //  1. 유니티 Inspector 창에서 보여줄 수 있도록 한다
    //  2. 정보가 손실되어지지 않는다

    //  public 이 붙어있다면 자동으로 [SerializeField] 가 붙는다 (암묵적)
    [SerializeField]public float m_Speed;
    public Rigidbody m_Rigid;
    void Update()
    {

        //  패싱

        //  사용자 입력 컨트롤의 수평 각도를 받아온다
        float horizontal = Input.GetAxis("Horizontal");

        //  사용자 입력 컨트롤의 수직 각도를 받아온다
        float vertial = Input.GetAxis("Vertical");

        float jump = Input.GetAxis("Jump");
        //  X 는 수평, Z 는 수직을 기준오르 축을 만들어 준다 (Axis)
        Vector3 movement = new Vector3(horizontal, jump *2, vertial);

        //  C++ 에서 class 와 struct 차이점
        //  1. 접근 제한자의 차이
        
        //  C# 에서 class 와 struct 차이
        //  1. 할당
        //  -> class 를 new 하는거랑 struct 를 new 하는거랑 완전 다름
        //  class -> Heap, struct -> Stack
        //  엄청 간단히 말하면
        //  struct 를 new 하는데 큰 문제가 없음 ! (메모리에 안쌓임)

        //  만든 축에 스피드 값을 곱해준다
        m_Rigid.AddForce(movement * m_Speed);

    }
}
