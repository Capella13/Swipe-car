using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_controller : MonoBehaviour
{
    float speed = 0;
    Vector2 stratPos;
    GameObject flag;
    GameObject car;

    private void Start()
    {
        this.flag = GameObject.Find("flag");
        this.car = GameObject.Find("car");
    }


    void Update()
    {


        if (Input.GetMouseButtonDown(0))  
        {
            // 마우스를 클릭한 좌표
            this.stratPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // 마우스 버튼에서 손가락을 떼었을 때 좌표
            Vector2 endPos = Input.mousePosition;
            float swpieLenght = endPos.x - this.stratPos.x;

            // 스와이프 길이를 처음 속도로 변경한다.
            this.speed = swpieLenght / 500.0f;

            // 효과음을 재생한다.
            GetComponent<AudioSource>().Play();

            this.flag.transform.position = new Vector3(-9, -3.7f, 0);
        }

        transform.Translate(this.speed, 0, 0);  // 이동
        this.speed *= 0.98f;                     // 감속
      

    }
}
