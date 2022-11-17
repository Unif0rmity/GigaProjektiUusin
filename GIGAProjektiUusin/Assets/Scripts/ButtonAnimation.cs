using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimation : MonoBehaviour
{
    public GameObject Button;

    private void ExecuteTrigger(string trigger)
    {
        if (Button != null)
        {
            var animator = Button.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger(trigger);
            }
        }
    }

    public void ButtonPress()
    {
        if (Input.GetMouseButton(0))
        {

            ExecuteTrigger("Pressed");
        }
    }


}