using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad4 : MonoBehaviour
{
    public float movementSpeed = 2.0f;
    GameObject gracz;

    void Start()
    {
        gracz = GameObject.FindGameObjectWithTag("Gracz");
    }
 
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0, zDirection);
        gracz.transform.position += moveDirection * Time.deltaTime * movementSpeed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
            Debug.Log("hitmarker");
    }
}