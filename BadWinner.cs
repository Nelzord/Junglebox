using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BadWinner : MonoBehaviour
{




    void OnTriggerEnter(Collider other)
    {

        Math.theScore += -5;
      
    }

}