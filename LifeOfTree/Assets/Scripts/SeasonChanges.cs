using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SeasonChanges : MonoBehaviour
{
    [SerializeField] string[] seasons;
    float timeOfChange;

    [SerializeField] public GameObject [] seasonObjects;
    [SerializeField] TextMeshProUGUI uiText;
    public int randomSeason;

    [SerializeField] List<string> seasonNames;

    [SerializeField] float minimumTime;
    [SerializeField] float maximumTime;

 

    Animator anim;


    void Start()
    {
        
            StartCoroutine(SetTheSeason());
        anim = GetComponent<Animator>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
     
    
    }

 

    IEnumerator SetTheSeason()
    {
        timeOfChange = Random.Range(minimumTime, maximumTime);
        while (true)
        {
            
            yield return new WaitForSeconds(timeOfChange);


            randomSeason = Random.Range(0, seasonNames.Count);

         
            

            changeSeasonText();
            AddAndRemove();
            
            anim.SetTrigger("changeSeason");




        }
    }

    void AddAndRemove()
    {

       

        if (seasonNames.Count > 0)
        {
            seasonNames.Remove(seasonNames[randomSeason]);
        }

        if (seasonNames.Count <= 0)
        {
            seasonNames.Add("Spring");
            seasonNames.Add("Summer");
            seasonNames.Add("Winter");
        }

    }

   

    private void changeSeasonText()
    {
        if (seasonNames[randomSeason].Contains("Spring"))
        {
            
            seasonObjects[0].SetActive(true);
            seasonObjects[1].SetActive(false);
            seasonObjects[2].SetActive(false);

        }else if(seasonNames[randomSeason].Contains("Summer"))
        {
           
            seasonObjects[0].SetActive(false);
            seasonObjects[1].SetActive(true);
            seasonObjects[2].SetActive(false);
        }
        else if (seasonNames[randomSeason].Contains("Winter"))
        {
        
            seasonObjects[0].SetActive(false);
            seasonObjects[1].SetActive(false);
            seasonObjects[2].SetActive(true);
        }
    }


}
