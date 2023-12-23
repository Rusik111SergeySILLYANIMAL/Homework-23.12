using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public bool isColliderPlayer = false;
    public Vector3 direction;
    public float speed = 2.5f;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PlatformStop")
        {
            direction *= -1;
        }
        if(other.tag == "Player")
        {
            isColliderPlayer = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            isColliderPlayer = false;
        }
    }
    void Update()
    {
        if(isColliderPlayer)
        {
                transform.position += Time.deltaTime * speed * direction;
        }
    }
}
