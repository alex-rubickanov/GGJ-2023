using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemperatureUI : MonoBehaviour
{
    [SerializeField] SeasonChanges seasonChanges;
    [SerializeField] Slider slider;
    [SerializeField] Gradient gradient;
    [SerializeField] Image fill;
    [SerializeField] float n;
    [SerializeField] float startingValue;





    void Start()
    {
        fill.color = gradient.Evaluate(1f);
        slider.value = startingValue;
    }

    // Update is called once per frame
    void Update()
    {
        seasons();
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    private void seasons()
    {
       
        if (seasonChanges.seasonObjects[0].activeSelf == true)
        {

            slider.value -= n * Time.deltaTime;

            //if its summer
        }
        else if (seasonChanges.seasonObjects[2].activeSelf == true)
        {

            slider.value += n * Time.deltaTime;
        }

       
    }

   
}
