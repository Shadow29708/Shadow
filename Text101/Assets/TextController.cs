using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TextController : MonoBehaviour {
	public Text text;
	private enum States {cell, sheets_0, sheets_1, lock_0, lock_1, mirror, cell_mirror, freedom, cafe_0, cafe_1, roamingcells, wander, freeprisoners, forksknives_0, spoons, cell_escape, Caught, FREE};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cell; 
	}
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) {state_cell();}
		else if (myState == States.sheets_0) {state_sheets_0();}
		else if (myState == States.sheets_1) {state_sheets_1();}
		else if (myState == States.lock_0) {state_lock_0();}
		else if (myState == States.lock_1) {state_lock_1();}
		else if (myState == States.mirror) {state_mirror();}
		else if (myState == States.cell_mirror) {state_cell_mirror();}
		else if (myState == States.freedom) {state_freedom();}
		else if (myState == States.cafe_0) {state_cafe_0();}
		else if (myState == States.roamingcells) {state_roamingcells();}
		else if (myState == States.wander) {state_wander();}
		else if (myState == States.freeprisoners) {state_freeprisoners();}
		else if (myState == States.forksknives_0) {state_forksknives_0();}
		else if (myState == States.spoons) {state_spoons();}
		else if (myState == States.cell_escape) {state_cell_escape();}
		else if (myState == States.Caught) {state_Caught();}
		else if (myState == States.FREE) {state_FREE();}	                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
	}
	void state_cell () {
		text.text = "You are in a prison cell, and you want to escape. There are " +
			    "some dirty sheets on the bed, a mirror on the wall, and the door " +
				"is locked from the outside.\n\n" +
				"Press S to view Sheets, M to view Mirror and L to view Lock" ;
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.sheets_0;}
		else if (Input.GetKeyDown(KeyCode.M)) {myState = States.mirror;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.lock_0;}
	}
	void state_mirror () {
		text.text = "The dirty old mirror on the wall seems loose.\n\n" +
			"Press T to Take the mirror, or R to Return to cell" ;
		if (Input.GetKeyDown(KeyCode.T)) {myState = States.cell_mirror;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell;}
	}
	void state_sheets_0 () {
		text.text = "You can't believe you sleep in these things. Surely it's " +
			"time somebody changed them. The pleasures of prison life " +
				"I guess!\n\n" +
				"Press R to Return to roaming your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell;}
	}
	void state_sheets_1 () {
		text.text = "Holding a mirror in your hand doesn't make the sheets look " +
			"any better.\n\n" +"Press R to Return to roaming your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell_mirror;}
	}
	void state_lock_0 () {
		text.text = "This is one of those button locks. You have no idea what the " +
			"combination is. You wish you could somehow see where the dirty " +
				"fingerprints were, maybe that would help.\n\n" +
				"Press R to Return to roaming your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell;}
	}
	void state_lock_1 () {
		text.text = "You carefully put the mirror through the bars, and turn it round " +
			"so you can see the lock. You can just make out fingerprints around " +
				"the buttons. You press the dirty buttons, and hear a click.\n\n" +
				"Press O to Open, or R to Return to your cell" ;
		if (Input.GetKeyDown(KeyCode.O)) {myState = States.freedom;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell_mirror;}
	}
	void state_cell_mirror () {
		text.text = "You are still in your cell, and you STILL want to escape! There are " +
			    "some dirty sheets on the bed, a mark where the mirror was, " +
				"and that pesky door is still there, and firmly locked!\n\n" +
				"Press S to view Sheets, or L to view Lock" ;
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.sheets_1;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.lock_1;}
	}
	void state_freedom () {
		text.text = "You are FREE! From your cell at least, Now you must escape the prison walls.\n\n" +
			"Press W to wander around.         Press L to look in other peoples cells.         Press C to look in the cafe.";
		if (Input.GetKeyDown(KeyCode.W)) {myState = States.wander;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.roamingcells;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.cafe_0;}
	}
	void state_cafe_0 () {
		text.text = "You are now in the Cafe, What would you like to do?\n\n" +
			"Press A to look at spoons.         Press F to look at knives and forks.";
		if (Input.GetKeyDown(KeyCode.F)) {myState = States.forksknives_0;}
		else if (Input.GetKeyDown(KeyCode.A)) {myState = States.spoons;}
	}
	void state_wander () {
		text.text = "You are wandering around and a guard spots you.\n\n" +
			"Press P to play again." ;
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
	}
	void state_roamingcells () {
		text.text = "You are checking in some prisoners cells, But they arent that happy about it.\n\n" +
			"Press F to free the prisoners.";
		if (Input.GetKeyDown(KeyCode.F)) {myState = States.freeprisoners;}
	}
	void state_freeprisoners () {
		text.text = "You free all the prisoners, But they start a riot and everything ends badly for you.\n\n" +
			"Press P to play again.";
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
	}
	void state_forksknives_0 () {
		text.text = "These could be of some use! Maybe for chipping the wall!.\n\n" +
			"Press R to Return to go back to cell! These knives and forks could come in handy!";
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell_escape;}
	}
	void state_spoons () {
		text.text = "These just look useless, Their the flimsy ones that always break!.\n\n" +
			"Press R to Return to cafe!";
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cafe_0;}
	}
	void state_cell_escape () {
		text.text = "You got back in your cell undectected, What would you like to do?\n\n" +
			"Press M to Mine through the floor.         Press D to dig under your bed.";
		if (Input.GetKeyDown(KeyCode.M)) {myState = States.Caught;}
		else if (Input.GetKeyDown(KeyCode.D)) {myState = States.FREE;}
	}
	void state_Caught () {
		text.text = "The guards saw the hole in the floor.\n\n" +
			"Press R to play again.";
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell;}
	}
	void state_FREE () {
		text.text = "You are FREE! No kidding, Have fun out of prison!\n\n" +
			"Press R to play again.";
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell;}
	}
}