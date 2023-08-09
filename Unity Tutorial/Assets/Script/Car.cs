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

    public int num = 10000;

    private float pi = 3.141592f;

    //접근 지정자를 선언하지 않으면 private로 선언    
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

    #region 함수
    //하나의 특별한 목적의 작업을 수행하기
    //위해 독립적으로 설계된 코드의 집합입니다

    private void Stop(){
        Debug.Log("정지");
    }

    private void Update(){
        //조건문이란?
        //어떤 조건이 주어질 때 해당 조건에 따라
        //동작을 수행하도록 실행하는 명령문입니다.

        //if문이란?
        //어떤 특정한 조건을 비교하여 조건이 맞다면
        //실행되는 명령문입니다
        
        // GetKeyDown : Key를 눌렀을때
        if(Input.GetKeyDown(KeyCode.Space)){
            Stop();
        }
        else if(Input.GetKeyDown(KeyCode.Q)){
            Debug.Log("핸들 조정");
        }
        else{
            Debug.Log("시동꺼짐");
        }
        // else if 문
        // if문의 조건이 틀릴 때 else if문의 조건이 맞다면
        // 실행되는 명령문

        //else문
        // if문과 else if문의 조건이 다 틀리면
        // 실행되는 명령문  
    }

    #endregion
}
