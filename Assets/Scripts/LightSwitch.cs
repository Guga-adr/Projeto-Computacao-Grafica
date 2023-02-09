using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
  private GameObject redLight;
  private GameObject yellowLight;
  private GameObject greenLight;
  private GameObject semaphore;
  private GameObject off;
  private float counter = 0f;
  public float waitTime = 6f;
    // Start is called before the first frame update
    void Start()
    {
        redLight = GameObject.Find("Red Light");
        yellowLight = GameObject.Find("Yellow Light");
        greenLight = GameObject.Find("Green Light");
        off = GameObject.Find("Off");
        off.SetActive(true);
        redLight.SetActive(false);
        yellowLight.SetActive(false);
        greenLight.SetActive(false);

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
        }
        else if(counter >= waitTime*3) {
          redLight.SetActive(false);
          yellowLight.SetActive(true);
          greenLight.SetActive(false);
        }
        else if(counter >= 0) {
          redLight.SetActive(false);
          yellowLight.SetActive(false);
          greenLight.SetActive(true);
        }
    }
}
