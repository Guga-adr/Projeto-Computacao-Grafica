using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCInteractable1 : MonoBehaviour
{
    public void Interact() {
        string npcName = gameObject.name;
        switch(npcName) {
            case "Marry": {
                SceneManager.LoadScene("Fase1");
                break;
            }
            case "Kssiano": {
                SceneManager.LoadScene("Fase2");
                break;
            }
                
        }
    }
}
