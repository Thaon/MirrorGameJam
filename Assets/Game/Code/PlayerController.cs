using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    #region member variables

    public GameObject m_shard;
    public GameObject m_target;
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
            m_anim.GetComponentInChildren<SkinnedMeshRenderer>().sharedMaterial.SetFloat("_MKGlowPower", 2.5f);
        }
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Vector3 origin = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
            Vector3 dir = Camera.main.transform.forward;

            if (Physics.Raycast(origin, dir, out hit))
            {
                m_target.SetActive(true);
                m_target.transform.position = hit.point;
            }
            else
            {
                m_target.SetActive(false);
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            m_anim.SetBool("shooting", false);
            m_shard.SetActive(true);
            m_anim.GetComponentInChildren<SkinnedMeshRenderer>().sharedMaterial.SetFloat("_MKGlowPower", 0);
            m_target.SetActive(false);
        }
    }
}
