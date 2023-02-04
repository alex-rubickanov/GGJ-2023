using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGrow : MonoBehaviour
{
    [SerializeField] private int treeGrow = 0;
    public GameObject[] trees;
    public ParticleSystem treeGrowParticle;


    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            treeGrow++;
            CurrentTree();
        }
        
    }

    private void CurrentTree()
    {
        if (treeGrow == 0)
        {
            Debug.Log("");
            trees[0].SetActive(true);
        }

        if (treeGrow == 1)
        {
            trees[0].SetActive(false);
            trees[1].SetActive(true);
            treeGrowParticle.Play();
        }

        if (treeGrow == 2)
        {
            trees[1].SetActive(false);
            trees[2].SetActive(true);
            treeGrowParticle.Play();
        }

        if (treeGrow == 3)
        {
            trees[2].SetActive(false);
            trees[3].SetActive(true);
            treeGrowParticle.Play();
        }
    }
}
