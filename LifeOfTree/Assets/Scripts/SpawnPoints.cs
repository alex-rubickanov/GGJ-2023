using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField] Transform[] spawnLocations;
    [SerializeField] GameObject pointObject;
    [SerializeField] float objectSpeed;
    [SerializeField] int addPoints = 10;
    int randomNumber;
    [SerializeField] ShopButton shop;
    [SerializeField] LayerMask layer;
    RaycastHit hit;

    void Start()
    {
        StartCoroutine(spawnRandomPoints());
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if(Physics.Raycast(ray, out hit, 100, layer) && Input.GetKeyDown(KeyCode.Mouse0))
        {
            shop.TotalPoints += addPoints;
            Destroy(hit.rigidbody.gameObject);
        }
    }

    IEnumerator spawnRandomPoints()
    {
        randomNumber = Random.Range(5, 8);


        while (true)
        {
            yield return new WaitForSeconds(randomNumber);
            int randomLocation = Random.Range(0, spawnLocations.Length);

            GameObject point = Instantiate(pointObject, spawnLocations[randomLocation].position, Quaternion.identity);
            point.GetComponent<Rigidbody>().velocity = -transform.up * objectSpeed * Time.deltaTime;
        }

    }
}
