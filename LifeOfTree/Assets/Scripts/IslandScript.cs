using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IslandScript : MonoBehaviour
{
    [Header("Rotation")]
    [SerializeField] float rotationSpeed = 5f;

    [Header("Status")]
    [SerializeField] public float startingValueStatus;
    [SerializeField] SeasonChanges seasonChanges;
    [SerializeField] public Slider slider;

    [Header("Soil Moisture")]
    [SerializeField] float duringSpringReduction;
    [SerializeField] float duringSummerReduction;
    [SerializeField] float duringWinterReduction;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IslandRotation();
   

    }

  

    private void IslandRotation()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }

 


}
