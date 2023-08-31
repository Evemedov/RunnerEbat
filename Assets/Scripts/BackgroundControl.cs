using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Timeline;

public class BackgroundControl : MonoBehaviour
{
    [SerializeField]
    private GameObject[] layers;
    [SerializeField]
    private float[] speed;

    private int forLenght;
    // Start is called before the first frame update
    void Start()
    {
        forLenght = layers.Length < speed.Length ? layers.Length : speed.Length;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < forLenght; i++)
        {
            layers[i * 3].transform.position += new Vector3(-speed[i] * Time.deltaTime, 0, 0);

            GameObject minLayer = Min(layers[i * 3], Min(layers[i * 3 + 1], layers[i * 3 + 2]));
            Debug.Log(layers[i * 3 + 1].transform.position.x);

            if(minLayer.transform.position.x < -80)
            {
                minLayer.transform.position += new Vector3(120, 0, 0);
            }
        }
    }

    private GameObject Min(GameObject a, GameObject b)
    {
        return a.transform.position.x < b.transform.position.x ? a : b;
    }
}
