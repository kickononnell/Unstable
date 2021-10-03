using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class TimedClick : MonoBehaviour, IPointerDownHandler
{
    public Text timer;
    public float timeLeft;
 
    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timer.text = string.Format("{0:00.00}", timeLeft);
            timeLeft -= Time.deltaTime;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Destroy(this.gameObject);
    }
}
