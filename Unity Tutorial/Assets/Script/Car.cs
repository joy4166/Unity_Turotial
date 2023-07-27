using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    #region 변수
    //데이처를 저장 할 수 있는 메모리

    char character = 'H';

    int num = 10000;

    float pi = 3.141592f;

    private void Start() {
        Debug.Log(character);
        Debug.Log(num);
        Debug.Log(pi);
    }


    #endregion


}
