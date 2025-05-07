using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    
    public float propSpeed;//public float propSpeed for testing

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //spins propeller in a Z direction
        transform.Rotate(Vector3.forward * propSpeed * Time.deltaTime); 
    }
}
