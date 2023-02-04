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

    //Animation

    [SerializeField] Animator arrowUpAnim;
    [SerializeField] Animator arrowDownAnim;
    [SerializeField] GameObject upArrow;
    [SerializeField] GameObject downArrow;

    Animator anim;





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
        if (seasonChanges.seasonObjects[1].activeSelf == true)
        {
            

            print("Its summer");
            slider.value += n * Time.deltaTime;
            arrowUpAnim.SetBool("Heating", true);
            arrowDownAnim.SetBool("Cold", false);

            //if its summer
        }
        else if (seasonChanges.seasonObjects[2].activeSelf == true)
        {
           
            slider.value -= n * Time.deltaTime;

            arrowUpAnim.SetBool("Heating", false);
            arrowDownAnim.SetBool("Cold", true);
        }
        else
        {
            arrowUpAnim.SetBool("Heating", false);
            arrowDownAnim.SetBool("Cold", false);
        }
       

       
    }

   
}
