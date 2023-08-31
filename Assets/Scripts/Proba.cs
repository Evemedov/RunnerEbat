using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proba : MonoBehaviour
{
    // Start is called before the first frame update
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
            layers[i * 2].transform.position += new Vector3(-speed[i] * Time.deltaTime, 0, 0);

            if (layers[i * 2].transform.position.x < -37f)
                layers[i * 2].transform.position += new Vector3(40, 0, 0);
        }
    }
}
