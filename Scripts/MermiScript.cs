using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiScript : MonoBehaviour
{
    public float mermiHizi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0f, Time.deltaTime * 4f * mermiHizi, 0f );
        
        if (gameObject.transform.position.z > 20f)
        {
            Destroy(gameObject);
        }

        
    }

    
}
