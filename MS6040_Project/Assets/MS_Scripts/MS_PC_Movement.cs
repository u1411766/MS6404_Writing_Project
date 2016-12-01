using UnityEngine;
using System.Collections;

public class MS_PC_Movement : MonoBehaviour {

    public float fl_speed = 1f;
    private Rigidbody2D rb2d_pc;
    public float fl_jump_power;
    public bool bl_grounded;
    public bool bl_move_lock = false;
    private MS_UI_Manager UI_Manager;

	// Use this for initialization
	void Start () {

        rb2d_pc = gameObject.GetComponent<Rigidbody2D>();
        UI_Manager = GameObject.Find("Game_Manager").GetComponent<MS_UI_Manager>();

	}
	
	// Update is called once per frame
	void Update () {

        if (!bl_move_lock)
        {
            Walk();
        }
	}

    void Walk()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.position += Vector3.left * fl_speed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.position += Vector3.right * fl_speed * Time.deltaTime;

        }

        if (Input.GetKeyDown("space") && bl_grounded)
        {
            rb2d_pc.AddForce(Vector2.up * fl_jump_power);

        }
    }
}
