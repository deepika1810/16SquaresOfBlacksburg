﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ManipulationScript : MonoBehaviour {

    float rotSpeed = 200;

    private void OnMouseDrag()
    {
		
		float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        //float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX);
        //transform.Rotate(Vector3.right, -rotY);
    }
}
