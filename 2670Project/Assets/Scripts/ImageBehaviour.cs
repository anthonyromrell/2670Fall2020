using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    private Image img;
    public FloatData data;
    public UnityEvent fillAmountZeroEvent;
    private void Start()
    {
        img = GetComponent<Image>();
    }

    public void UpdateFillAmount()
    {
        StopAllCoroutines();
        //StartCoroutine(OnUpdateFillAmount());
    }
    
    private IEnumerator OnUpdateFillAmount(float change)
    {
        while (img.fillAmount >= data.value)
        {
            img.fillAmount += change;
            yield return new WaitForFixedUpdate();
        }
    }
}