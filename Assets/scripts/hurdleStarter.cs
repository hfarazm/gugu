using UnityEngine;
using System.Collections;

public class hurdleStarter : MonoBehaviour
{
		public GameObject hurdle;
		public int timeManager;
		public GUIText scoreText;
	
		void Update ()
		{
				transform.position = new Vector3 (12f, 4f, -4);
				timeManager = (int)Time.timeSinceLevelLoad;
				scoreText.text = timeManager.ToString (); 

				if (!IsInvoking ("makeHurdle"))
						Invoke ("makeHurdle", 2.5f);
		}
	
		void makeHurdle ()
		{
				Instantiate (hurdle, transform.position = new Vector3 (9f, Random.Range (3f, -3f), 0), transform.rotation);
		}
}
