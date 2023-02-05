using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    [SerializeField] GameObject shopInterface;
    [SerializeField] TextMeshProUGUI pointsValue;
    [SerializeField] public int TotalPoints;
    //cost shop
    //Heal
    [SerializeField] int healCost;
    [SerializeField] int additionalHeal;
    [SerializeField] TextMeshProUGUI healValue;
    //fire 
    [SerializeField] int fireCost;
    [SerializeField] ParticleSystem fire;
    [SerializeField] float fireTimeLimit;

    //Animation hover
    Animator anim;
   
    void Start()
    {
        shopInterface.SetActive(false);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        pointsValue.SetText(TotalPoints.ToString());
    }

    public void OpenCloseShop()
    {
        if(shopInterface.activeSelf == false)
        {
            shopInterface.SetActive(true);
        }
        else
        {
            shopInterface.SetActive(false);
        }
    }

    public void PurchaseHeal()
    {
        if(TotalPoints >= healCost)
        {
            TotalPoints -= healCost;

            if(int.Parse(healValue.text) < 100)
            {
              
                int totalHealth = int.Parse(healValue.text) + additionalHeal;
                print(totalHealth);
                healValue.SetText(totalHealth.ToString());
            }

        }
    }

    public void PurchaseFire()
    {
        if(TotalPoints>= fireCost)
        {
            fire.Play();

            Invoke("TurnOffTheFire", fireTimeLimit);
        }
    }

    void TurnOffTheFire()
    {
        fire.Stop();
    }

    public void TriggerHover()
    {
        anim.SetBool("hover", true);
    }

    public void UnHover()
    {
        anim.SetBool("hover", false);
    }
}
