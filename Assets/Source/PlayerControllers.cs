using UnityEngine;
using System.Collections;

// Temporary hacked player controls, this allow me to control both
// players with one keyboard. Could have done via inspector for keybinding
// but since this is just temporary it was not needed.
public class PlayerControllers : MonoBehaviour {
	#region public Properties
	public Transform PlayerOne;
	public Transform PlayerTwo;
	public float JumpHeight = 10f;
	#endregion

	#region Unity Methods
	void Update() {
		UpdatePlayer(true, KeyCode.W, KeyCode.S, KeyCode.A, KeyCode.D, KeyCode.F);
		UpdatePlayer(false, KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.Space);
	}
	#endregion

	#region private Methods
	private void UpdatePlayer(bool isPlayerOne, KeyCode MoveForward, KeyCode MoveBackward, KeyCode MoveLeft, KeyCode MoveRight, KeyCode Jump) {
		Transform PlayerTarget = (isPlayerOne) ? PlayerOne : PlayerTwo;

		if (Input.GetKey(MoveForward)) {
			PlayerTarget.GetComponent<CharacterController>().Move(Vector3.forward * Time.deltaTime);
		}

		if (Input.GetKey(MoveBackward)) {
			PlayerTarget.GetComponent<CharacterController>().Move(Vector3.back * Time.deltaTime);
		}

		if (Input.GetKey(MoveLeft)) {
			PlayerTarget.GetComponent<CharacterController>().Move(Vector3.left * Time.deltaTime);
		}

		if (Input.GetKey(MoveRight)) {
			PlayerTarget.GetComponent<CharacterController>().Move(Vector3.right * Time.deltaTime);
		}

		if (Input.GetKeyDown(Jump)) {
			PlayerTarget.GetComponent<CharacterController>().Move(Vector3.up * Time.deltaTime * JumpHeight);
		}

		PlayerTarget.GetComponent<CharacterController>().Move(Physics.gravity * Time.deltaTime);
	}
	#endregion
}