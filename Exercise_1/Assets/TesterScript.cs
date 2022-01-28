using UnityEngine;

public class TesterScript : MonoBehaviour {

    void FixedUpdate ()
    {
      GetComponent<Rigidbody>().AddForce(0, 3 * Time.deltaTime, 0);
    }
}
