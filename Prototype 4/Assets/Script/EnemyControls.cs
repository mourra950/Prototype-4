using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControls : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody Rb;
    public float EnemySpeed;
    GameObject Player;
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 LookP = Player.transform.position - transform.position;
        Rb.AddForce(LookP.normalized * EnemySpeed);
    }
}
