using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCamera : MonoBehaviour
{
    public float rotateSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float hinput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, hinput * rotateSpeed * Time.deltaTime);
    }
}
