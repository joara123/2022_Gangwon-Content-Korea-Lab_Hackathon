using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange1 : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject dataModel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 forward = mainCam.transform.TransformDirection(Vector3.forward) * 100;

        if(Physics.Raycast(this.transform.position, forward, out hit))
        {
            if(hit.transform.gameObject.CompareTag("change1") && Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("UserServer");
                DontDestroyOnLoad(dataModel);
            }
        }
    }
}
