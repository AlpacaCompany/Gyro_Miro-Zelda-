using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform Pos;
    public GameObject Ball;
    GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        b = Instantiate(Ball);
        b.transform.position = Pos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(b.transform.position.y < -10) {
            Destroy(b);
            b = Instantiate(Ball);
            b.transform.position = Pos.position;
        }
    }
}
