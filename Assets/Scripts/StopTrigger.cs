using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTrigger : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private bool ativo = false;
    public float timer = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ativo) {
            if (timer > 0) {
                if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) timer = 1;
                timer -= Time.deltaTime;
            }
            else {
                ativo = false;
                player.transform.position = respawnPoint.transform.position;
            }
        }
    }

    void OnTriggerEnter(Collider player)
    {
        ativo = true;
    }
}
