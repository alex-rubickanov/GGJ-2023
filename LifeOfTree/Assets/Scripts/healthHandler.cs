using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class healthHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthValue;
    [SerializeField] Slider statusSlider;
    [SerializeField] int healthReduction = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(statusSlider.value < 36.6f || statusSlider.value > 68.0f)
        {
            int Totalhealth = (int)statusSlider.value - healthReduction;
            print(Totalhealth);
            healthValue.SetText(Totalhealth.ToString());
        }
    }
}
