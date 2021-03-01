using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	public float speed = 10.0f;
	public float rotationSpeed = 100.0f;
	private Vector3 moveDirection;

	void FixedUpdate () {
		float translation = speed;
		float rotation = rotationSpeed;

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;

		moveDirection = new Vector3 (0, -9.81f, 0);

		if(Input.GetKey(KeyCode.W))
		   {
			moveDirection = new Vector3 (moveDirection.x,moveDirection.y,translation);
		//	moveDirection = new Vector3 (0, -9.81f, translation);


			
		}
		
		if(Input.GetKey(KeyCode.S))
		   {
			moveDirection = new Vector3 (moveDirection.x,moveDirection.y,-translation);

			
		}

		if(Input.GetKey(KeyCode.A))
		   {
			moveDirection = new Vector3 (-translation,moveDirection.y,moveDirection.z);

			
			}
		
		if(Input.GetKey(KeyCode.D))
		   {
			moveDirection = new Vector3 (translation,moveDirection.y,moveDirection.z);

			
		}
		
		if (!Input.GetKey (KeyCode.W) && !Input.GetKey (KeyCode.S) &&!Input.GetKey (KeyCode.A) && !Input.GetKey (KeyCode.D)) {
						transform.rigidbody.velocity = Vector3.zero;
				} else {
						moveDirection = transform.TransformDirection (moveDirection);
						transform.rigidbody.velocity = moveDirection;
				}
			//transform.Translate (0, 0, translation);
	}
}
