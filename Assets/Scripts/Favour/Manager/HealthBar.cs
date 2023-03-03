using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [Tooltip("Value to use as the current ")]
    public FloatReference currentHealth;

    [Tooltip("Min value that Variable to have no fill on Image.")]
    public FloatReference Min;

    [Tooltip("Max value that Variable can be to fill Image.")]
    public FloatReference Max;

    [Tooltip("Image to set the fill amount on.")]
    public Image Image;

    private void Start()
    {
        currentHealth.Variable.Value = Max.Value;
    }

    public void UpdateHealth(int damageAmount)
    {
        currentHealth.Variable.Value -= damageAmount;
        currentHealth.Variable.Value = Mathf.Clamp(currentHealth.Variable.Value, Min.Value,Max.Value);
        Image.fillAmount = currentHealth.Value / Max.Value;
    }
}
