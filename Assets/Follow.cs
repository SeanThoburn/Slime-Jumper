using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject target;

    private void FixedUpdate()
    {
        Vector3 targetPosition = target.transform.position;
            targetPosition.z = transform.position.z;
        targetPosition.x += target.GetComponent<Rigidbody2D>().velocity.x * 1f;

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }
}
