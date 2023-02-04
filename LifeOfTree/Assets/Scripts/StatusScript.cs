using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusScript : MonoBehaviour
{
    [SerializeField] IslandScript island;
    [SerializeField] Gradient gradient;
    [SerializeField] Image fill;
    [SerializeField] SeasonChanges seasonChanges;

    [Header("Soil Moisture")]
    [SerializeField] float duringSpringReduction;
    [SerializeField] public float duringSummerReduction;
    [SerializeField] public float duringWinterReduction;
 


    Slider slider;
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = island.startingValueStatus;

        fill.color = gradient.Evaluate(1f); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        fill.color = gradient.Evaluate(slider.normalizedValue);

        SoilFunction();
    }

    private void SoilFunction()
    {
        //if its spring
        if (seasonChanges.seasonObjects[0].activeSelf == true)
        {
            
            slider.value -= duringSpringReduction * Time.deltaTime;

            //if its summer
        }
        else if (seasonChanges.seasonObjects[1].activeSelf == true)
        {
           
            slider.value -= duringSummerReduction * Time.deltaTime;
        }

        // if its winter
        else if (seasonChanges.seasonObjects[2].activeSelf == true)
        {
            slider.value += duringWinterReduction * Time.deltaTime;
        }
    }

    public void addWater(float value)
    {
        slider.value += value * Time.deltaTime;
    }
}
