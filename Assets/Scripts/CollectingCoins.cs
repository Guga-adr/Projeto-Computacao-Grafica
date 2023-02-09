using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;
    public AudioClip apito;

    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject SpawnPoint;

    public float volume = 1.0F;

    public static int corsas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider Col) {
        //coleta de corsas
        if(Col.gameObject.tag == "Corsinha") {
            corsas = corsas + 1;
            int som = (corsas-1)%3;
            Debug.Log("Corsas capotados: " + corsas + "Som: " + som);
            Col.gameObject.SetActive(false);
            audioSource.PlayOneShot(audioClipArray[som], volume);
        }
        //interação com death planes
        else if (Col.gameObject.tag == "DP") {
            audioSource.PlayOneShot(apito, volume);
            Respawn();
        }
        
    }

    void Respawn() {
        Player.SetActive(false);
        Debug.Log("Posição: " + Player.transform.position);
        Player.transform.position = SpawnPoint.transform.position;
        Player.SetActive(true);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void OnBeforeSceneLoadRuntimeMethod()
    {
        corsas = 0;
    }
}
