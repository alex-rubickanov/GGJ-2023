using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class levelDifficulty : MonoBehaviour
{
    [SerializeField] StatusScript statusScript;
    [SerializeField] SeasonChanges seasonChanges;
    [SerializeField] TreeGrow treeGrowth;
    [SerializeField] SpawnPoints points;

    bool stage1 = false;
    bool stage2 = false;
    bool stage3 = false;


 

   
    // Update is called once per frame
    void Update()
    {
      
        if (treeGrowth.treeGrow >= 20)
        {
            if (stage1 == false)
            {

               
                seasonChanges.minimumTime -= 5;
                seasonChanges.maximumTime -= 5;

                statusScript.duringSummerReduction -= 0.2f;
                statusScript.duringWinterReduction += 0.2f;
                statusScript.duringSpringReduction -= 0.2f;
                stage1 = true;
            }
         

           
           
        }

        if (treeGrowth.treeGrow >= 50)
        {
            if (stage2 == false)
            {

               
                seasonChanges.minimumTime -= 10;
                seasonChanges.maximumTime -= 10;

                statusScript.duringSummerReduction -= 0.2f;
                statusScript.duringWinterReduction += 0.2f;
                statusScript.duringSpringReduction -= 0.2f;

                points.minTime -= 1;
                points.MaxTime -= 1;
                stage2 = true;



            }
        }

        if (treeGrowth.treeGrow >= 75)
        {
            if (stage3 == false)
            {

                stage3 = true;
                seasonChanges.minimumTime -= 10;
                seasonChanges.maximumTime -= 10;

                statusScript.duringSummerReduction -= 0.2f;
                statusScript.duringWinterReduction += 0.2f;
                statusScript.duringSpringReduction -= 0.2f;

                points.minTime -= 1;
                points.MaxTime -= 1;
                stage3 = true;


            }

        }

        s
    }
}
