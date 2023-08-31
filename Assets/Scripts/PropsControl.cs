using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsControl : MonoBehaviour
{

    //Serialize Fields
    [SerializeField]
    private GameObject[] obj;
    [SerializeField]
    private float startDelay;
    [SerializeField]
    private float repeatRate;
    [SerializeField]
    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    //[SerializeField]
    //private GameObject obj2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObj", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObj()
    {
        //Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], spawnPosition);
    }
}
