using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
   public Transform Spawnpoint;
   public Transform Spawnpoint1;
    public Transform Spawnpoint2;
    public Transform Spawnpoint3;
    public Transform Spawnpoint4;
    public Transform Spawnpoint5;
    public Transform Spawnpoint6;

    public GameObject Prefab;
    public GameObject Prefab1;
    public GameObject Prefab2;


    void OnTriggerEnter()
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        Instantiate(Prefab, Spawnpoint1.position, Spawnpoint1.rotation);
        Instantiate(Prefab, Spawnpoint1.position, Spawnpoint2.rotation);
        Instantiate(Prefab, Spawnpoint1.position, Spawnpoint3.rotation);
        Instantiate(Prefab, Spawnpoint1.position, Spawnpoint4.rotation);
        Instantiate(Prefab, Spawnpoint1.position, Spawnpoint5.rotation);
        Instantiate(Prefab, Spawnpoint1.position, Spawnpoint6.rotation);
        Instantiate(Prefab1, Spawnpoint.position, Spawnpoint.rotation);
        Instantiate(Prefab1, Spawnpoint1.position, Spawnpoint1.rotation);
        Instantiate(Prefab1, Spawnpoint1.position, Spawnpoint2.rotation);
        Instantiate(Prefab1, Spawnpoint1.position, Spawnpoint3.rotation);
        Instantiate(Prefab1, Spawnpoint1.position, Spawnpoint4.rotation);
        Instantiate(Prefab1, Spawnpoint1.position, Spawnpoint5.rotation);
        Instantiate(Prefab1, Spawnpoint1.position, Spawnpoint6.rotation);
        Instantiate(Prefab2, Spawnpoint.position, Spawnpoint.rotation);
        Instantiate(Prefab2, Spawnpoint1.position, Spawnpoint1.rotation);
        Instantiate(Prefab2, Spawnpoint1.position, Spawnpoint2.rotation);
        Instantiate(Prefab2, Spawnpoint1.position, Spawnpoint3.rotation);
        Instantiate(Prefab2, Spawnpoint1.position, Spawnpoint4.rotation);
        Instantiate(Prefab2, Spawnpoint1.position, Spawnpoint5.rotation);
        Instantiate(Prefab2, Spawnpoint1.position, Spawnpoint6.rotation);

    }
}
