using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    #region member variables

    public GameObject m_shard;
    public Animator m_anim;

    #endregion

    void Start ()
    {
		
	}
	
	void Update ()
    {
		if (Input.GetMouseButtonDown(0))
        {
            m_anim.SetBool("shooting", true);
            m_shard.SetActive(false);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            m_anim.SetBool("shooting", false);
            m_shard.SetActive(true);
        }
	}
}
