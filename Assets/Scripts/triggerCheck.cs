﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerCheck : MonoBehaviour
{
    //tìm hiểu Invoke trong unity
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player") // check đối tượng có tag là player không 
        {
            Invoke("Fall", 0.5f);   //chạy hàm  fall sau 0.5s

        }
    }
    private void Fall()
    {
        GetComponentInParent<Rigidbody>().isKinematic = false;  // bỏ iskinematic(là làm cho vật không chịu tác động của tọng lực -> vật đứng yên) trong component rigidbody 
        GetComponentInParent<Rigidbody>().useGravity = true; //set gravity (vật sẽ rơi xuống) 
        Destroy(transform.parent.gameObject,2f);        // phá hủy game object sau 2ss
    }
}
