using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlingSphere : MonoBehaviour
{
  public float rotationSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
    }
}
