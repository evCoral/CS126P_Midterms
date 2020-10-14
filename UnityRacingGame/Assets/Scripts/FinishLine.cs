using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider hit){
        if (hit.gameObject.name == "Player"){
            SceneManager.LoadScene(1);
        }
    }
}
