using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MS_UI_Trigger : MonoBehaviour {

    public GameObject pc_trigger;
    private GameObject UI_Panel;
    public GameObject UI_Text;
    private MS_PC_Movement PC_Move;
    private bool bl_triggered;
    public bool bl_active;

	// Use this for initialization
	void Start () {

        UI_Panel = GameObject.Find("Panel");
        UI_Text.SetActive(false);
        PC_Move = GameObject.Find("MS_PC").GetComponent<MS_PC_Movement>();
	}
	
	// Update is called once per frame
	void Update () {
        
        //Allows the player to deactivate the UI panels and textm also allows the PC to start moving again
        if (bl_active && Input.GetKey("e"))
        {
            UI_Panel.SetActive(false);
            UI_Text.SetActive(false);
            bl_triggered = true;
            bl_active = false;
            PC_Move.bl_move_lock = false;
        }
	}//---

    //Sets the trigger to the active state, and tells the rest of the script that the player is locked into a conversation
    void OnTriggerEnter2D(Collider2D col)
    {
        if (!bl_triggered)
        {
            bl_active = true;
        }
    }

    //Sets the associated UI panel to true, and locks the player character's movement
    void OnTriggerStay2D(Collider2D col)
    {
        if (bl_active)
        {
            UI_Panel.SetActive(true);
            UI_Text.SetActive(true);
            PC_Move.bl_move_lock = true;
        }      
    }//---


}//======
