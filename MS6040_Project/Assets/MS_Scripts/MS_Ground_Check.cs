using UnityEngine;
using System.Collections;

public class MS_Ground_Check : MonoBehaviour {

    private MS_PC_Movement PC_move;

	// Use this for initialization
	void Start () {

        PC_move = GetComponentInParent<MS_PC_Movement>();

	}
	
	// Update is called once per frame
	void Update () {
	

	}

    void OnTriggerEnter2D(Collider2D col)
    {
        PC_move.bl_grounded = true;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        PC_move.bl_grounded = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        PC_move.bl_grounded = false;
    }
}
