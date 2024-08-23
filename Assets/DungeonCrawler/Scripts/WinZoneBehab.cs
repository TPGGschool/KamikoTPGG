using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZoneBehab : MonoBehaviour
{
    public Canvas winScreen;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {

            winScreen.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
