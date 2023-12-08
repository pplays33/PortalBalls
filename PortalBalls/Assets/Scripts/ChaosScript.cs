using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float StartSpeed;
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(StartSpeed, 0, StartSpeed);
        //rigidbody.velocity = transform.forward * StartSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        //rigidbody.velocity = transform.forward * StartSpeed;
        //rigidbody.velocity = new Vector3(StartSpeed, 0, StartSpeed);
    }
}
