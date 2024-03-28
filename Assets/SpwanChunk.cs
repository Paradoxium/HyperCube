using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanChunk : MonoBehaviour
{
    public GameObject levelChunk;
    public Transform levelSpawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(levelChunk,levelSpawnPoint);
        }
    }
}
