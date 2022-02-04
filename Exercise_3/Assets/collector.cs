using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collector : MonoBehaviour
{
  public string collectibleTag;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter ( Collision collision )
    {
      Debug.Log(":D");
      if( collision.gameObject.tag == collectibleTag )
      {
        Debug.Log("Ded");
        GameObject.Destroy( collision.gameObject );
      }
    }
}
