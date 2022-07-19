using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl_User : MonoBehaviour
{
    public Transform player;
    public float speed = 3;
    private bool isMove = false;
    private GameObject inData;

    // Start is called before the first frame update
    void Start()
    {
        inData = GameObject.Find("dataModel");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            isMove = true;

        else if(Input.GetMouseButtonUp(0))
            isMove = false;

        if (isMove)
        {
            Vector3 dir = player.forward;
            dir.y = 0;
            this.transform.position += dir * Time.deltaTime * speed;
        }
    }
}