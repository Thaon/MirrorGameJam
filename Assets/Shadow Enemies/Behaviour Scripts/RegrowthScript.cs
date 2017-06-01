using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegrowthScript : MonoBehaviour {

    public float m_counter = 0.0f;
    public bool m_limbRegrowing = false;
	
	// Update is called once per frame
	void Update ()
    {
        while(m_limbRegrowing)
        {
            if (m_counter > 10.0f)
            {
                this.gameObject.SetActive(true);
                m_counter = 0.0f;
            }
            m_counter += 0.01f;
        }
    }

    public void TakeDamage()
    {
        this.gameObject.SetActive(false);
    }
}
