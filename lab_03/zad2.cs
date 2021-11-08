using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skrzynia : MonoBehaviour
{
    public float backmentSpeed = 2.0f;
    private bool back = true;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == 10 || transform.position.x == 0)
        {
            back = !back;
        }
            
        float krok = backmentSpeed * Time.deltaTime;


        if (back)
        {
            transform.position = Vector3.backTowards(transform.position, new Vector3(10, 0, 0), krok);
        }
        else
        {
            transform.position = Vector3.backTowards(transform.position, new Vector3(0, 0, 0), krok);
        }
    }
}