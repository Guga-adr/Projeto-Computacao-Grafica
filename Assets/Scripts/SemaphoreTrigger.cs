using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemaphoreTrigger : MonoBehaviour
{

  [SerializeField] private GameObject Texto;
  [SerializeField] private GameObject Semaforo;
  
    // Start is called before the first frame update
    void Start()
    {
      Texto.SetActive(false);
      Semaforo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider col) {
      if(col.gameObject.name == "Arisa") {
        Texto.SetActive(true);
      }
    }

    void OnTriggerExit(Collider col) {
      if(col.gameObject.name == "Arisa") {
        Texto.SetActive(false);
        Semaforo.SetActive(true);
      }
    }
}
