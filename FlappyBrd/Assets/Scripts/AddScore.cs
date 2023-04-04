using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AddScore : MonoBehaviour
{

    private void OnTriggerExit2D(Collider2D other)
    {
        GameManager.Instance.UpdateScore();
        GameManager.Instance.BestScore();
       
        GameManager.Instance.PointS();

    }

  
}

