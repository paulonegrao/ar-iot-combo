using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PubButtons : MonoBehaviour
{
	public void OnPreheatButtonPress() {
		GameObject.Find("CodeContainer").SendMessage("PreheatStart");
    }

    public void OnCooldownButtonPress() {
		GameObject.Find("CodeContainer").SendMessage("CooldownStart");
    }
    public void OnPrintButtonPress() {
		GameObject.Find("CodeContainer").SendMessage("PrintStart");
    }
}
