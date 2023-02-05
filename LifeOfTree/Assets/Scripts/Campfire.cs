using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Campfire : MonoBehaviour
{
    public ParticleSystem fireParticle;
    [SerializeField] Slider statusSlider;
    [SerializeField] float heat;


    public void PressedButton()
    {
        Debug.Log("Button has been pressed");
        fireParticle.Stop();
    }

    private void Update()
    {
        if (fireParticle.isPlaying == true)
        {
            statusSlider.value -= heat * Time.deltaTime;
        }
    }
}
