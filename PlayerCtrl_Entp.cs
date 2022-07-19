using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl_Entp : MonoBehaviour
{
   public Transform player;
   public float speed = 3;
   public GameObject[] obj = new GameObject[3];
   public GameObject mainCam;
   public GameObject parent;
   private bool isMove = false;
   private bool isDrop = false;
   private bool isGround = false;
   private Vector3 buildLoc;
   private int i;
    public GameObject testgo;
    
   // Start is called before the first frame update
   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 forward = mainCam.transform.TransformDirection(Vector3.forward) * 100;
        Debug.DrawRay(this.transform.position, forward, Color.green);

        if (Physics.Raycast(this.transform.position, forward, out hit))
        {

            if(hit.transform.gameObject.CompareTag("button"))
			{
				hit.transform.GetComponent<Button>().onClick.Invoke();
			}
			if (Input.GetMouseButtonDown(0)){
				if(!hit.transform.gameObject.CompareTag("button"))
				{
					testgo = hit.transform.gameObject;
				}
				c_delete del = GameObject.Find("DELETE").GetComponent<c_delete>();
				del.isD = false;
			}

            if (hit.transform.gameObject.CompareTag("Bed"))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    isMove = false;
                    Debug.Log("hit");
                    isDrop = true;
                    i = 0;
                    buildLoc.y = 2.02f;
                }
            }
            else if (hit.transform.gameObject.CompareTag("Sofa"))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    isMove = false;
                    Debug.Log("hit");
                    isDrop = true;
                    i = 1;
                    buildLoc.y = 1.52f;
                }
            }
            else if (hit.transform.gameObject.CompareTag("Tv"))
            {
                if(Input.GetMouseButtonDown(0))
                {
                    isMove = false;
                    Debug.Log("hit");
                    isDrop = true;
                    i = 2;
                    buildLoc.y = 1.29f;
                }
            }

            else if (hit.transform.gameObject.CompareTag("Bathub"))
            {
                if(Input.GetMouseButtonDown(0))
                {
                    isMove = false;
                    Debug.Log("hit");
                    isDrop = true;
                    i = 3;
                    buildLoc.y = 0.8f;
                }
            }

            else if (hit.transform.gameObject.CompareTag("Sink"))
            {
                if(Input.GetMouseButtonDown(0))
                {
                    isMove = false;
                    Debug.Log("hit");
                    isDrop = true;
                    i = 4;
                    buildLoc.y = 1.2f;
                }
            }

            else if (hit.transform.gameObject.CompareTag("Drawer"))
            {
                if(Input.GetMouseButtonDown(0))
                {
                    isMove = false;
                    Debug.Log("hit");
                    isDrop = true;
                    i = 5;
                    buildLoc.y = 1.29f;
                }
            }

            else if (hit.transform.gameObject.CompareTag("BathSink"))
            {
                if(Input.GetMouseButtonDown(0))
                {
                    isMove = false;
                    Debug.Log("hit");
                    isDrop = true;
                    i = 6;
                    buildLoc.y = 1.56f;
                }
            }

            else if (hit.transform.gameObject.CompareTag("Toilet"))
            {
                if(Input.GetMouseButtonDown(0))
                {
                    isMove = false;
                    Debug.Log("hit");
                    isDrop = true;
                    i = 7;
                    buildLoc.y = 1.12f;
                }
            }

            else if (hit.transform.gameObject.CompareTag("Ref"))
            {
                if(Input.GetMouseButtonDown(0))
                {
                    isMove = false;
                    Debug.Log("hit");
                    isDrop = true;
                    i = 8;
                    buildLoc.y = 2.12f;
                }
            }

            else if (hit.transform.gameObject.CompareTag("Table"))
            {
                if(Input.GetMouseButtonDown(0))
                {
                    isMove = false;
                    Debug.Log("hit");
                    isDrop = true;
                    i = 9;
                    buildLoc.y = 1.53f;
                }
            }

            else if (hit.transform.gameObject.CompareTag("Lwall"))
            {
                if(Input.GetMouseButtonDown(0))
                {
                    isMove = false;
                    Debug.Log("hit");
                    isDrop = true;
                    i = 10;
                    buildLoc.y = 2.5f;
                }
            }

            else if (hit.transform.gameObject.CompareTag("Mwall"))
            {
                if(Input.GetMouseButtonDown(0))
                {
                    isMove = false;
                    Debug.Log("hit");
                    isDrop = true;
                    i = 11;
                    buildLoc.y = 2.5f;
                }
            }

            else if (hit.transform.gameObject.CompareTag("Swall"))
            {
                if(Input.GetMouseButtonDown(0))
                {
                    isMove = false;
                    Debug.Log("hit");
                    isDrop = true;
                    i = 12;
                    buildLoc.y = 2.5f;
                }
            }

            if (isDrop && hit.transform.gameObject.CompareTag("ground"))
            {
                if(Input.GetMouseButtonDown(0))
                {
                    isGround = true;
                    buildLoc.x = hit.point.x;
                    buildLoc.z = hit.point.z;
                }
                else if (Input.GetMouseButtonUp(0))
                {
                    GameObject data = Instantiate(obj[i], buildLoc, obj[i].transform.rotation);
                    data.transform.parent = parent.transform;
                }
            }
        }

        else if (Input.GetMouseButtonDown(0))
        {
            isMove = true;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            isMove = false;
        }

        if (isMove)
        {
            Vector3 dir = player.forward;
            this.transform.position += dir * Time.deltaTime * speed;
        }
    }
}