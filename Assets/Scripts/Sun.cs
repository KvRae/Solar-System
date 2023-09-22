using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public Transform sun;
    
    public float speed = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        sun.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        sun.Rotate(new Vector3(0,speed,0));
    }
}
