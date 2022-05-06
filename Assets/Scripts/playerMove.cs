using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    Vector3 moveX = new Vector3(2.5f, 0, 0);

    void Start()
    {
        
    }

    void Update()
    {
        // 왼쪽 이동
        if (transform.position.x >-6 && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveX*Time.deltaTime);
        }
        // 오른쪽 이동
        if (transform.position.x <6 && Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveX * Time.deltaTime);
        }
    }
}
