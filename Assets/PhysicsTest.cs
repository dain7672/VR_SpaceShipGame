using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    //Collision: 충돌로 인해 서로에게 힘이 가해지는 경우 (서로 반작용이 있는)
    //event 함수. 
    //충돌 시작지점에 실행됨
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter");
    }

    //충돌이 실행되는 중에 실행됨
    private void OnCollisionStay(Collision collision)
    {

    }

    //충돌 종료시점 실행됨
    private void OnCollisionExit(Collision collision)
    {

    }

    //충돌 이벤트만 발동시키고, 실제 힘이 가해지지 않게 하는 경우 (그냥 뚫고 간다던지.)
    //Collider 컴포넌트에서 isTrigger=true를 하면 된다.
    //-> Colllision Event와 동시에 발동되지는 않는 것.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter Trigger");
    }
    private void OnTriggerStay(Collider other)
    {

    }
    private void OnTriggerExit(Collider other)
    {

    }
}
