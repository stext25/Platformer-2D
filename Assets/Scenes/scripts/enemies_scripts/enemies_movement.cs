using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies_movement : MonoBehaviour
{
    public float speed = 5f;
    public Transform init_pos,target_pos1, target_pos2;
    public Vector3 nextpos;

    public Animator animator;

    void Start()
    {
        nextpos = init_pos.position;
    }

    void Update()
    {
        movement();
    }

    public void movement()
    {
        if (transform.position.x == target_pos1.position.x)
        {
            nextpos = target_pos2.position;
        }
        if (transform.position.x == target_pos2.position.x)
        {
            nextpos = target_pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);
    }
}
