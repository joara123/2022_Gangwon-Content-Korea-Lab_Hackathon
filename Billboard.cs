using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Camera camTr;
    //private Transform tr;
    //private float posX;
    //private float posZ;

    // Start is called before the first frame update
    void Start()
    {
        camTr = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = camTr.transform.position - transform.position;
        v.x = v.z = 0;
        transform.LookAt(camTr.transform.position - v);
        Debug.Log(camTr.transform.position - v);

    }
}
