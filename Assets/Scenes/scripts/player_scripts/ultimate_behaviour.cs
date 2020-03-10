using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ultimate_behaviour : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        this.transform.position += new Vector3(speed, 0);
    }

    void OnCollisionEnter(Collision other)
    {
        Destroy(this.gameObject);
    }
}
