using UnityEngine;
using System.Collections;

public class hurdleMover : MonoBehaviour
{
		public float hurdler = 0.07f;

		void Update ()
		{
				transform.Translate (Vector3.left * hurdler, Space.World);
				Destroy (this.gameObject, 8);
		}
}
