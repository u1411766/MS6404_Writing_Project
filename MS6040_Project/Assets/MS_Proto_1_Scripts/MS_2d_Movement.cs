using UnityEngine;
using System.Collections;

public class MS_2d_Movement : MonoBehaviour {

    public int speed = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.LeftArrow)){

            transform.position += Vector3.left * speed * Time.deltaTime;
        
        }

        if(Input.GetKey(KeyCode.RightArrow)){

            transform.position += Vector3.right * speed * Time.deltaTime;

        }

	}
}
