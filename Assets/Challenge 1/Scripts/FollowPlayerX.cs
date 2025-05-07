using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;//connects to plane object
    private Vector3 offset = new Vector3(30, 0, 10); // creates offset

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //camera position = plane position + offset
        transform.position = plane.transform.position + offset;
    }
}
