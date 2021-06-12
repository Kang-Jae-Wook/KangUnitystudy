using System.Collections;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    public float RotateSpeed;

    private void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -RotateSpeed, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, RotateSpeed, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0, 0, RotateSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, 0, -RotateSpeed, Space.Self);
        }

        //  Euler();
        //  local ?
        //  local 붙으면 무조건 자기 자신 (own)
        //  Euler -> Quaternion 각도를 x,y,z 로 보이게 해준다
        //  Quaternion ? -> 단점 !
        //  1. 축이 4개임 (x,y,z,w) 각도가 다름 (0~1)
        //  오일러 각 보다 사원수(Quaternion) 계산이 더 빠름! 그리고 짐벌락이 없음


        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, transform.localEulerAngles.z);

    }

}
