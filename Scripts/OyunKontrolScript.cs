using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OyunKontrolScript : MonoBehaviour
{
    public float Skyboxspeed;
    Vector3 poz;
    public float MermiGücü = 50;
    public float DüsmanCani = 100;
  
    public GameObject Dusman;
    public GameObject Mermi;
    public GameObject Gemi;
    public float hiz;
    float surekaydet = 0f;
    float Delay = 2f;
    float sure = Time.time;
    float ÝceridenAtesEtmeSikligi;
    public float disaridanAtesEtmeSikligi;


    Vector3 GemiPoz;


    // Start is called before the first frame update
    void Awake()

    {
        Vector3 poz = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if((Time.time-surekaydet) > Delay)
        {
            surekaydet = Time.time;
            DusmanUret();
            if(Delay>1)
            Delay -= 0.1f;
        }

            if (Input.GetKey(KeyCode.D) && Gemi.transform.position.x <= 1.56f)
        {
            Gemi.transform.Translate(1f * Time.deltaTime*hiz, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) && Gemi.transform.position.x >= -1.44f)
        {
            Gemi.transform.Translate(-1f * Time.deltaTime*hiz, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space)&& Time.time > ÝceridenAtesEtmeSikligi)
        {
            SoundManager.PlaySound("laser");
            GameObject newMermi = Instantiate(Mermi, GemiPoz,Quaternion.Euler(90f,0f,0f));
            ÝceridenAtesEtmeSikligi = Time.time + disaridanAtesEtmeSikligi;
        }
        GemiPoz = Gemi.transform.position;
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * Skyboxspeed);
    }
    void DusmanUret()
    {
        poz.x = Random.Range(-1.44f, 1.5f);
        poz.y = .9f;
        poz.z = 20f;
        GameObject newDusman = Instantiate(Dusman, poz, Quaternion.Euler(180f,0f,180f));   
    }


 

}
