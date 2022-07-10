using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class canbar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public float health;
    float maxHealth = 100;
    public TextMeshProUGUI puan;
    public int skor = 0;
    public TextMeshProUGUI finalSkor;


    public GameObject GameOverPanel;


    private void OnCollisionEnter(Collision collision)
    {
        slider.value = health;
        if (collision.transform.tag == "Dusman")
        {
            GetDamage(10);
        }
    }
    public void GetDamage(float amount)
    {
        health -= amount;
        gameObject.GetComponent<Slider>().value -= amount;
        if (health <= 0)
        {
            
            GameOverPanel.SetActive(true);
            SoundManager.PlaySound("dead");
            SoundManager.PlaySound("over");

            finalSkor.text = skor.ToString();
           
            Time.timeScale = 0;
        }
    }
    public void PuanKazan()
    {
        skor += 10;
        puan.text = skor.ToString();
    }
    public void TekrarOyna()
    {
        
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}
