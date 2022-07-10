using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pausemenu : MonoBehaviour
{
    public GameObject Panel;
    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void Resume()
    {
        Panel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
