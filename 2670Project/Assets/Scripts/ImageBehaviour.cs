using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    private Image img;
    public FloatData data;
    private float tempValue;
    private void Start()
    {
        img = GetComponent<Image>();
        tempValue = data.value;
    }

    public void UpdateFillAmount()
    {
        StartCoroutine(OnUpdateFillAmount());
    }
    
    private IEnumerator OnUpdateFillAmount()
    {
        while (tempValue > data.value)
        {
            img.fillAmount = tempValue;
            yield return new WaitForFixedUpdate();
            tempValue -= 0.01f;
        }
        
        tempValue = data.value;
        
    }
}