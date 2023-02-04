using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeasonChanges : MonoBehaviour
{
    [SerializeField] string[] seasons;
    float timeOfChange;
    
    void Start()
    {
        while (true)
        {
            StartCoroutine(SetTheSeason());
        }
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    IEnumerator SetTheSeason()
    {
        timeOfChange = Random.Range(15, 30);
        yield return new WaitForSeconds(timeOfChange);
    }
}
