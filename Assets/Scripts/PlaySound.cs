using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    
    public AudioSource hit;
    public AudioSource theme;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    audio = GetComponent<AudioSource>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    public void Theme()
    {
        theme.Play();
    }

    public void hitDiamond()
    {
        hit.Play();
    }
}
