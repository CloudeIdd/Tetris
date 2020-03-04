using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Piezas;
    void Start()
    {
        NewPieza();
    }
    public void NewPieza()
    {
        Instantiate(Piezas[Random.Range(0, Piezas.Length)], transform.position, Quaternion.identity);
    }
}
