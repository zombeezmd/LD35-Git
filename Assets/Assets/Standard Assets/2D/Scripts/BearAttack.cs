using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class BearAttack : MonoBehaviour {


    private void Awake()
    {
        // Setting up references.
        m_GroundCheck = transform.Find("GroundCheck");
        m_CeilingCheck = transform.Find("CeilingCheck");
        m_Anim = GetComponent<Animator>();
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
