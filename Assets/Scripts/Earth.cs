using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Earth : MonoBehaviour
{
    public Transform sun;
    public Transform earth;
    
    public float rotationSpeed ;
    public float radiusSpeed ;
    public float radius ;

    private Vector3 axis;
    private Vector3 desiredPosition;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = (transform.position - sun.position).normalized * radius + sun.position;
        axis = Vector3.up;
        earth.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        earth.Rotate(new Vector3(0,radiusSpeed,0));
        transform.RotateAround(sun.position, axis, rotationSpeed * Time.deltaTime);
        desiredPosition = (transform.position - sun.position).normalized * radius + sun.position;
        transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
    }
}
