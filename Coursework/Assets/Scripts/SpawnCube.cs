using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject Prefab;
    GameObject nullCube;
        
    public void burnCube() // спавн куба 
    {

        if(Input.GetKeyUp(KeyCode.F))
        {
            nullCube = Instantiate(Prefab) as GameObject;
            nullCube.transform.position = new Vector3(Random.Range(-5f, 5f), 0.75f, Random.Range(-8f, 8f));
            nullCube.transform.Rotate(0, 0, 0);
        }
    }

    public void DestroyCube() // его удаление если пользователь захочет
    {
        if(Input.GetKey(KeyCode.P))
        {
            Destroy(nullCube);
        }
    }

    public void Update()
    {
        burnCube();
        DestroyCube();
    }
}
