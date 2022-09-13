using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true; //자이로 활성화
    }

    // Update is called once per frame
    void Update()
    {
        //자이로 센서의 각도로 움직이기
        transform.rotation = Quaternion.Euler(Input.gyro.rotationRateUnbiased.x * speed, Input.gyro.rotationRateUnbiased.y *speed, Input.gyro.rotationRateUnbiased.z * speed);
    }
}
