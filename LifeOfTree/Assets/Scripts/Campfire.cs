using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campfire : MonoBehaviour
{
    public ParticleSystem fireParticle;

    public void PressedButton()
    {
        Debug.Log("Button has been pressed");
        fireParticle.Stop();
    }
}
