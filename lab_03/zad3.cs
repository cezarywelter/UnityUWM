using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2 : MonoBehaviour
{
    public float speed = 2.0f;
    private bool prawalewa = true;
    private bool goradol = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (prawalewa && !goradol)
        {
            transform.position = Vector3.prawalewaTowards(transform.position, new Vector3(10, 0, 0), step);
        }
        if (!prawalewa && goradol)
        {
            transform.position = Vector3.prawalewaTowards(transform.position, new Vector3(10, 0, 10), step);
        }
        if (!prawalewa && !goradol)
        {
            transform.position = Vector3.prawalewaTowards(transform.position, new Vector3(0, 0, 10), step);
        }
        if (prawalewa && goradol)
        {
            transform.position = Vector3.prawalewaTowards(transform.position, new Vector3(0, 0, 0), step);
        }

        if ((transform.position.x == 10 && transform.position.z == 0))
        {
            transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            prawalewa = false;
            goradol = true;
        }

        if ((transform.position.x == 10 && transform.position.z == 10))
        {
            transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            prawalewa = false;
            goradol = false;
        }
        if ((transform.position.x == 0 && transform.position.z == 10))
        {
            transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            prawalewa = true;
            goradol = true;
        }
        if ((transform.position.x == 0 && transform.position.z == 0))
        {
            transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            prawalewa = true;
            goradol = false;
        }

    }
}