using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandScript : MonoBehaviour
{
    [Header("Rotation")]
    [SerializeField] float rotationSpeed = 5f;
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
