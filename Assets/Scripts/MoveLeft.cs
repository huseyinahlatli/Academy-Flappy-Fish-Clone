using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float minOffset = -0.5f;
    [SerializeField] private float maxOffset = 2.5f;
    private void FixedUpdate()
    {
        transform.position += Time.deltaTime * speed * Vector3.left;
        if (transform.position.x <= -15f)
        {
            if (minOffset == 0 || maxOffset == 0)
            {
                transform.position = new Vector3(15,transform.position.y , transform.position.z);
            }
            else
            {
                float randomHeight = UnityEngine.Random.Range(minOffset, maxOffset);
                transform.position = new Vector3(15,randomHeight , transform.position.z);
            }
        }
    }
}
