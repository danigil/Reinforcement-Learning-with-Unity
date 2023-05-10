using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingManager : MonoBehaviour
{
    public GameObject toSpawn;
    void Start()
    {
        Instantiate(toSpawn, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(toSpawn, new Vector3(10, 0, 0), Quaternion.identity);
        Instantiate(toSpawn, new Vector3(-10, 0, 0), Quaternion.identity);


        Instantiate(toSpawn, new Vector3(0, 0, 10), Quaternion.identity);
        Instantiate(toSpawn, new Vector3(10, 0, 10), Quaternion.identity);
        Instantiate(toSpawn, new Vector3(-10, 0, 10), Quaternion.identity);

        Instantiate(toSpawn, new Vector3(0, 0, -7), Quaternion.identity);
        Instantiate(toSpawn, new Vector3(10, 0, -7), Quaternion.identity);
        Instantiate(toSpawn, new Vector3(-10, 0, -7), Quaternion.identity);

    }

}
