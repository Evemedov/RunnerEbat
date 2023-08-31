using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;

    private bool onGround = true;

    //Serialize Fields
    [SerializeField]
    private float jumpPower = 5;
    [SerializeField]
    private float gravityModifier = 5;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //Keyboard control
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            playerRB.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            onGround = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Floor")
            onGround = true;
    }
}
