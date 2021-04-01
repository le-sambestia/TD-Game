﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private bool doMovement = false;

    public float panSpeed = 30f;
    public float panborderThickness = 10f;

    public float scrollSpeed = 5f;
    public float minY = 10f;
    public float maxY = 80f;
    // Update is called once per frame
    void Update()
    {
        if(GameManger.GameIsOver)
        {
            this.enabled = false;
            return;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            doMovement = !doMovement;

        if (!doMovement)
            return;
        //has mouse controls but they are commented out 

        if(Input.GetKey("w") /*|| Input.mousePosition.y >= Screen.height - panborderThickness*/)
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("s") /*|| Input.mousePosition.y <= panborderThickness*/)
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d") /*|| Input.mousePosition.x >= Screen.width - panborderThickness*/)
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("a") /*|| Input.mousePosition.x <= panborderThickness*/)
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }


        //scroll mechanics 

        /*float scroll = Input.GetAxis("MouseScrollWheel");

        Vector3 pos = transform.position;

        pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        transform.position = pos;*/

    }
}
