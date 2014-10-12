using UnityEngine;
using System.Collections;

public class bgAnim : MonoBehaviour
{
		// Variables to control the speed of background movement
		public float speed = 0.001f;
		private float position = 0;

		void Update ()
		{
				position += speed;
				if (position > 1.0f)
						position -= 1.0f; // Resets position value to start
				renderer.material.mainTextureOffset = new Vector2 (position, 0);
		}
}
