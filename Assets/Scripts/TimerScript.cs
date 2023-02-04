using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
  public float TimeLeft;
  public bool TimerOn = false;
    // Start is called before the first frame update
    void Start()
    {
      TimeLeft = 4;
    }

    // Update is called once per frame
    void Update()
    {
      if(TimerOn == false && Input.GetKeyDown(KeyCode.Space))
      {
        TimerOn = true;
      }
      if(TimerOn == true)
      {
        TimeLeft -= Time.deltaTime;
        Debug.Log(TimeLeft);
      }
      if(TimeLeft < 0)
      {
        TimerOn = false;

      }
    }
}
