using UnityEngine;
using System.Collections;

public class loadScene : MonoBehaviour
{
		public float buttonPressAmount = 0.12f;

		void OnMouseDown ()
		{
				// play sound on button click
				audio.Play ();
				// press button
				transform.position = new Vector2 (transform.position.x, transform.position.y - buttonPressAmount);
				
		}
		void OnMouseUp ()
		{
				// release button
				transform.position = new Vector2 (transform.position.x, transform.position.y + buttonPressAmount);
				// load game level named "Game"		
				Application.LoadLevel ("Game");
		}
}
