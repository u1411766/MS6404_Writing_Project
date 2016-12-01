using UnityEngine;
using System.Collections;

public class MS_UI_Manager : MonoBehaviour {
    private GameObject UI_Panel;
    private GameObject UI_Tutorial;
    private MS_PC_Movement PC_Move;
    public bool bl_triggered = false;

	// Use this for initialization
	void Start () {

        UI_Panel = GameObject.Find("Panel");
        UI_Tutorial = GameObject.Find("Tutorial_Text");
        PC_Move = GameObject.Find("MS_PC").GetComponent<MS_PC_Movement>();
       
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.E) && !bl_triggered)
        {
            UI_Panel.SetActive(false);
            UI_Tutorial.SetActive(false);
            bl_triggered = true;
            PC_Move.bl_move_lock = false;
        }

	}


}
