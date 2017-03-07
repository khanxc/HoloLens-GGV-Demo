using UnityEngine;
using System.Collections;
using HoloToolkit;
using System.Collections.Generic;

public class ActivateManipulation : MonoBehaviour {

	// Use this for initialization



    public void triggerMoveAircraftAction()
    {
        GestureManager.Instance.Transition(GestureManager.Instance.ManipulationRecognizer);
    }

    public void stopAircraftMovement()
    {

    }
}
