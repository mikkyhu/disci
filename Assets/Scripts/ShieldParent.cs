﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldParent : MonoBehaviour {

    public GameObject FreeShield;

    public void SetParent(GameObject hand_l) {

        FreeShield.transform.parent = hand_l.transform;
        Debug.Log("Shield's Parent: " + FreeShield.transform.parent.parent.name);
    }

    public void DetachFromParent() {

        transform.parent = null;
    }

}
