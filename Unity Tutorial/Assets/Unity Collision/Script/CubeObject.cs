using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObject : MonoBehaviour
{
    // OnCollisionEnter: 충돌 했을때 호출되는 함수
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌");
    }

    // OnCollisionStay: 충돌 중일때 호출되는 함수
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("충돌중");
    }

    // OnCollisionExit: 충돌 벗어났을때 호출되는 함수
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("충돌종료");
    }

    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Main Cube"){
            Debug.Log("Trigger 충돌");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Main Cube"){
        Debug.Log("Trigger 충돌 중");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Main Cube"){
        Debug.Log("Trigger 충돌 종료");
        }
    }

}
