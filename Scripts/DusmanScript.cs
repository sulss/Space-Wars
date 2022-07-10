using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DusmanScript : MonoBehaviour
{
    public float dusmanCan = 50f;
    float surekaydet = 0f;
    float Delay = 10f;
    public GameObject patlama;
    public float dusmanHizi=2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - surekaydet) > Delay)
        {
            dusmanCan = dusmanCan + (25f * (Time.time / 15));
            surekaydet = Time.time;
            dusmanHizi += .5f * (Time.time/15);   
        }

        if (gameObject.transform.position.z > -9)
        {
            gameObject.transform.Translate(0, 0, Time.deltaTime * 1.5f * dusmanHizi);
        }
        else
        {
            
            Destroy(gameObject);
            SoundManager.PlaySound("patlama");
            GameObject newPatlama = Instantiate(patlama, gameObject.transform.position, Quaternion.identity);
            Destroy(newPatlama, 2);
            GameObject anaKontrolcum = GameObject.FindGameObjectWithTag("Kalancan");
            anaKontrolcum.GetComponent<canbar>().GetDamage(10);


        }
    
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (dusmanCan > 0 && collision.transform.tag == "Mermi")
        {
            dusmanCan -= 25f;
            Destroy(collision.gameObject);

            if (dusmanCan < 0 )
            
            {
                
                Destroy(gameObject);
                SoundManager.PlaySound("patlama");
                GameObject newPatlama = Instantiate(patlama, gameObject.transform.position, Quaternion.identity);
                Destroy(newPatlama, 2); GameObject anaKontrolcum = GameObject.FindGameObjectWithTag("Kalancan");
                anaKontrolcum.GetComponent<canbar>().PuanKazan();


            }

        }
        
    }

}
