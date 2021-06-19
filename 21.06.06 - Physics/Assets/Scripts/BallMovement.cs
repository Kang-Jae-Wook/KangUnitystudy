using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//  ����ȭ ?
//  System.Serializable
//  Ŭ���� �Ǵ� ����ü (��ü) ������ ����� �� �ִ�
//  ��� (���� ���� �ڵ� ġ�� �۾�) ���� �ʾƵ� public �̸� �ڵ����� �ٴ´� (�Ϲ���)
//  ? public class �̸� �ڵ����� �پ����

//  ����Ƽ ����
//  ����ȭ�� �Ǹ� ����Ƽ �ȿ� �ִ� ���� ����ȭ �ȴ�

[System.Serializable]
public class BallMovement : MonoBehaviour
{
    //  C++
    //  public:
    //  float ...

    //  C#
    //  [���� ������] [�ڷ���] [������] ��
    //  private Vector3 ������ = ��
    //  public float ������ = ��
    
    //  ����ȭ �ʵ�
    //  SerializeField ?
    //  ������ ����ȭ �Ѵ�
    //  1. ����Ƽ Inspector â���� ������ �� �ֵ��� �Ѵ�
    //  2. ������ �սǵǾ����� �ʴ´�

    //  public �� �پ��ִٸ� �ڵ����� [SerializeField] �� �ٴ´� (�Ϲ���)
    [SerializeField]public float m_Speed;
    public Rigidbody m_Rigid;
    void Update()
    {

        //  �н�

        //  ����� �Է� ��Ʈ���� ���� ������ �޾ƿ´�
        float horizontal = Input.GetAxis("Horizontal");

        //  ����� �Է� ��Ʈ���� ���� ������ �޾ƿ´�
        float vertial = Input.GetAxis("Vertical");

        float jump = Input.GetAxis("Jump");
        //  X �� ����, Z �� ������ ���ؿ��� ���� ����� �ش� (Axis)
        Vector3 movement = new Vector3(horizontal, jump *2, vertial);

        //  C++ ���� class �� struct ������
        //  1. ���� �������� ����
        
        //  C# ���� class �� struct ����
        //  1. �Ҵ�
        //  -> class �� new �ϴ°Ŷ� struct �� new �ϴ°Ŷ� ���� �ٸ�
        //  class -> Heap, struct -> Stack
        //  ��û ������ ���ϸ�
        //  struct �� new �ϴµ� ū ������ ���� ! (�޸𸮿� �Ƚ���)

        //  ���� �࿡ ���ǵ� ���� �����ش�
        m_Rigid.AddForce(movement * m_Speed);

    }
}
