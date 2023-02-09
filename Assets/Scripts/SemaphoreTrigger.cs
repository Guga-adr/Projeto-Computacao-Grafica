using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemaphoreTrigger : MonoBehaviour
{

  [SerializeField] private GameObject Semaforo;
  
    // Start is called before the first frame update
    void Start()
    {
      Semaforo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerExit(Collider col) {
      if(col.gameObject.name == "Arisa (1)") {
        Debug.Log("Saiu");
        Semaforo.SetActive(true);
      }
    }
}
