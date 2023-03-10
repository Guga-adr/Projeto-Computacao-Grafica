using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider player)
    {
        player.transform.position = respawnPoint.transform.position;
        
    }
    public void Kill(Collider player)
    {
        player.transform.position = respawnPoint.transform.position;  
    }
}

