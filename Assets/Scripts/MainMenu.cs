using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void BlinkandShake()
    {
        SceneManager.LoadScene("Shake&Blink");
    }
    public void DragandDrop()
    {
        SceneManager.LoadScene("Drag&Drop");
    }
}
