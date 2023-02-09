using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestInteractable : MonoBehaviour
{
    public static int[] placas;

    void Start() {
        placas[0] = 1; placas[1] = 1; placas[2] = 1;
    }

    public void Interact() {
        Debug.Log("Bau");
        Debug.Log(gameObject.name);
        string placa = gameObject.name;
        switch(placa) {
            case "Bau1Semaforo": {
                Debug.Log("Placa 1 adquirida");
                placas[0] = 1;
                break;
            }
            case "Bau2ProbParar": {
                Debug.Log("Placa 2 adquirida");
                placas[1] = 1;
                break;
            }
            case "Bau3Velocidade": {
                Debug.Log("Placa 3 adquirida");
                placas[3] = 1;
                break;
            }
            
        }
        SceneManager.LoadScene("Playground");
    }

}
