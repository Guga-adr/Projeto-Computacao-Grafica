using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;
    public AudioClip clipe;
    public float volume = 1.0F;

    public int corsas = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider Col) {
        if(Col.gameObject.tag == "Corsinha") {
            corsas = corsas + 1;
            Debug.Log("Corsas capotados: " + corsas);
            Col.gameObject.SetActive(false);
            //AudioSource.PlayClipAtPoint(audioClipArray[corsas-1], Camera.main.transform.position, volume);
            audioSource.PlayOneShot(audioClipArray[corsas-1], volume);
        }
    }
}
