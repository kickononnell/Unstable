using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class ButtonMash : MonoBehaviour
{
    public Slider slider;

    public void onSpacebar(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            slider.value += 1;
        }
        if (slider.value >= slider.maxValue)
        {
            Destroy(this.gameObject);
        }
    }
}
