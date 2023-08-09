using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    #region 변수
    //데이처를 저장 할 수 있는 메모리 공간을
    //생성하는 것입니다

    //자료형이란?
    //데이터를 저장해주기 위한 데이터의 형태를
    //정해주는 것입니다
 
    // 자료형   크기    내용
    // bool -> 1 byte '참', '거짓'을 저장할 수 있는 자료형
    // char -> 1 byte 하나의 문자를 저장하는 자료형
    // short -> 2 byte 정수를 저장하는 자료형
    // int -> 4 byte 정수를 저장하는 자료형
    // long -> 4 byte 정수를 저장하는 자료형
    // float -> 4 byte 실수를 저장하는 자료형
    // double -> 8 byte 실수를 저장하는 자료형

    //변수의 메모리 공간은 프로그램이 실행될 때마다 바뀌며
    //여러 개의 변수가 있을 때 서로 고유의 메모리 공간을 가진다
    char character = 'H';

    int num = 10000;

    float pi = 3.141592f;

    string name = "Sonata";

    //변수의 이름 규칙
    /*
    // 1. 변수의 이름으로 예약어를 사용할 수 없습니다
    // ex) int int = 1;

    // 2. 변수의 이름을 숫자로 시작할 수 없습니다
    // ex) int 1value = 2;

    // 3. 변수의 이름은 대소문자를 구분합니다
    // ex) int data = 3;
    // ex) int Data = 4;

    // 4. 변수의 이름으로 공백이 포함될 수 없습니다
    // ex) int count down = 5;

    // 5. 변수의 이름으로 특수문자를 _만 허용합니다
    // ex) int count_down = 6;
    */

    private void Start() {
        //변수는 프로그램이 실행되는 동안 값을 바꿀 수 있으며,
        //원래 저장되어 있는 값은 새로 저장되는 값에 의해 지워집니다.
        character = 'J';
        num = 102;
        pi = 6.675f;
        name = "Avante";

        Debug.Log("character 변수의 값: " + character);
        Debug.Log("num 변수의 값: " + num);
        Debug.Log("pyi 변수의 값: " + pi);
        Debug.Log("name 변수의 값: " + name);
    }


    #endregion


}
