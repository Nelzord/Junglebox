using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Winner : MonoBehaviour
{

    


    void OnTriggerEnter(Collider other)
    {

        Math.theScore += 1;
        Destroy(gameObject);
    }

}