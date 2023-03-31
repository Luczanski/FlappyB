using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AddCoin : MonoBehaviour
{
    
        private void OnTriggerEnter2D(Collider2D other)
        {
            GameManager.Instance.UpdateCoin();
        }
   
}
