using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject containerGameObject;
    public TMP_Text Contador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider player)
    {
        if(true) {
            Contador.text = CollectingCoins.corsas + " Corsinhas";
            Time.timeScale = 0f;
            containerGameObject.SetActive(true);
            Debug.Log("Ganhou");
        }
    }
}
