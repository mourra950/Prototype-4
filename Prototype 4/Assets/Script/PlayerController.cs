using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float inputVertical;
    [SerializeField] Rigidbody Rb;
    [SerializeField] GameObject focalP;
    public float PlayerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        focalP = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        inputVertical = Input.GetAxis("Vertical");
        Rb.AddForce(focalP.transform.forward * PlayerSpeed * inputVertical);
    }
}
