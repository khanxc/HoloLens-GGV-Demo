using HoloToolkit;
using UnityEngine;
using System.Collections;

public class ActivateModelGrab : MonoBehaviour {


    public GameObject ModelToGrab;
	// Use this for initialization

     public void grabModelButtonTapped()
    {
        ModelToGrab.SendMessageUpwards("OnTappingGrabButton");
    }

}
