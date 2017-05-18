using System.Collections;
using UnityEngine;

public class FripperController : MonoBehaviour {
		private HingeJoint myHingeJoint;

		private float defaulAngle = 20;
		private float flidkAngle = -20;

		void Start () {
				this.myHingeJoint = GetComponent<HingeJoint>();

				SetAngle(this.defaulAngle);
	}

	void Update () {

			if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag") {
			SetAngle (this.flidkAngle);
			}
			if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag") {
			SetAngle (this.flidkAngle);
			}

			if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag") {
			SetAngle (this.defaulAngle);
			}
			if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag") {
			SetAngle (this.defaulAngle);
			}
	}

	public void SetAngle (float angle){
		JointSpring jointSpr = this.myHingeJoint.spring;
		jointSpr.targetPosition = angle;
		this.myHingeJoint.spring = jointSpr;
	}
}