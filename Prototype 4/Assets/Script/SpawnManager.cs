using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Enemy;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 4, 6);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnEnemy()
    {
        float X = Random.Range(-8, 8);
        float Z = Random.Range(-8, 8);
        Vector3 position = new Vector3(X, 0, Z);
        Instantiate(Enemy, position, Enemy.transform.rotation);
    }
}
