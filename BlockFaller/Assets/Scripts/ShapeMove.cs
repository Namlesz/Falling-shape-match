﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeMove : MonoBehaviour
{
    void Start()
    {
        Variable vars = GameObject.Find("GameController").GetComponent<Variable>();
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0,-vars.speed));
    }
}