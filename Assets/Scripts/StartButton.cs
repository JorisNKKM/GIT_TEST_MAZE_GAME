using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.position += Vector3.down * 0.1f;
    }
    private void OnMouseUp()
    {
        transform.position += Vector3.up * 0.1f;


        SceneManager.LoadScene("Level 1");


    }
}
