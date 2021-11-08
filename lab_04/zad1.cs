using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class lab4zad1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 2.0f;
    public int objectCounter = 0;
    public GameObject block;
    Collider rend;
    public int randObiekt = 5;
    private UnityEngine.Object[] items;

    void Start()
    {
        rend = GetComponent<Collider>();
        items = Resources.LoadAll("items");

        int maxX = (int)rend.bounds.max.x;
        int minX = (int)rend.bounds.min.x;

        int maxZ = (int)rend.bounds.max.z;
        int minZ = (int)rend.bounds.min.z;

        List<int> x_position = new List<int>(Enumerable.Range(minX, maxX).OrderBy(x => Guid.NewGuid()).Take(randObiekt));
        List<int> z_position = new List<int>(Enumerable.Range(minZ, maxZ).OrderBy(x => Guid.NewGuid()).Take(randObiekt));

        for (int i = 0; i < randObiekt; i++)
        {
            this.positions.Add(new Vector3(x_position[i], 5, z_position[i]));
        }

        StartCoroutine(GenerujObiekt());

    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        foreach (Vector3 pos in positions)
        {
            var randomIndex = UnityEngine.Random.Range(0, items.Length);

            this.block.GetComponent<Renderer>().material = (Material)items[randomIndex];
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }

        StopCoroutine(GenerujObiekt());
    }

}