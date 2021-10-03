using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ButtonHold : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Slider slider;
    private bool isHeld;

    void Start() 
    {
        isHeld = false;
    }

    void Update()
    {
        if (isHeld)
        {
            slider.value += Time.deltaTime;
        }
        if (slider.value >= slider.maxValue)
        {
            Destroy(this.gameObject);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isHeld = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isHeld = false;
    }
}
