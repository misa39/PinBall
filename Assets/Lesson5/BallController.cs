using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

		private float visiblePosZ = -6.5f;

		private GameObject gameoverText;

		private GameObject scoreText;

		private int score = 0;

		void Start () {
				this.gameoverText = GameObject.Find ("GameOverText");

				this.scoreText = GameObject.Find ("ScoreText");
		}
	
		// Update is called once per frame
		void Update () {
				if (this.transform.position.z < this.visiblePosZ) {
					this.gameoverText.GetComponent<Text> ().text = "Game Over";
				}
		}

		void OnCollisionEnter(Collision other){
			if (other.gameObject.tag == "LargeStarTag") {
				score += 10;
			}
			if (other.gameObject.tag == "LargeCloudTag") {
				score += 20;
			}
			if (other.gameObject.tag == "SmallCloudTag") {
			score += 20;
		}
		this.scoreText.GetComponent<Text> ().text = "Score ; " + score;
		}
}