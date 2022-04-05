using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy_Bar_Behavior : MonoBehaviour
{
    public Slider slider;
    
    public void SetMaxEnergy(int energy)
    {
        slider.maxValue = energy;
        slider.value = energy;
    }

    public void SetEnergy(int energy)
    {
        slider.value = energy;
    }
}
