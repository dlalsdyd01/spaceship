using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private float moveSpeed = 3f;

    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        if (transform.position.y < -14.6) {
            transform.position += new Vector3(0, 28f, 0);
        }
    }
}
// 그림이 일정한 속도로 내려오다가 정해진 구간에서 다시 위로 올라가
// 무한대로 움직이는 배경완성!