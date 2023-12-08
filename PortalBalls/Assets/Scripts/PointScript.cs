using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    public bool isSolved = false;


    private void OnTriggerEnter(Collider other)
    {
        GameObject colliderWith = other.gameObject;
        if(colliderWith.tag == gameObject.tag)
        {
            isSolved = true;
            print(colliderWith.name + " destroy");
            Destroy(colliderWith);
            var light = GetComponent<Light>();
            light.enabled = false;
        }
    }
}
