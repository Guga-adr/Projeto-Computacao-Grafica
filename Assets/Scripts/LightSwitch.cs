using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
  [SerializeField] private GameObject redLight;
  [SerializeField] private GameObject yellowLight;
  [SerializeField] private GameObject greenLight;
  [SerializeField] private GameObject Respawn;
  private float counter = 0f;
  public float waitTime = 6f;
  private bool lose = false;
    // Start is called before the first frame update
    void Start() {
        redLight.SetActive(false);
        yellowLight.SetActive(false);
        greenLight.SetActive(false);
        lose = false;
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if(counter >= waitTime*5f) {
          counter = 0f;
        }
        else if(counter >= waitTime*4) {
          redLight.SetActive(true);
          yellowLight.SetActive(false);
          greenLight.SetActive(false);
          if(counter >= waitTime*4.2) {
            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            lose = true;
          }
        }
        else if(counter >= waitTime*3) {
          redLight.SetActive(false);
          yellowLight.SetActive(true);
          greenLight.SetActive(false);
          if(counter >= waitTime*3.2) {
            if(Input.GetKey(KeyCode.LeftShift))
            lose = true;
          }
        }
        else if(counter >= 0) {
          redLight.SetActive(false);
          yellowLight.SetActive(false);
          greenLight.SetActive(true);
        }
        Debug.Log(lose);
        if(lose) {
          lose = false; 
        }
    }
}
