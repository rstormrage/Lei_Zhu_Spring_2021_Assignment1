using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit : MonoBehaviour {

	[Tooltip("ExitMessage拖进来")]
	Text ExitMessageObj;
	float fadingSpeed = 1;
	bool fading;
	float startFadingTimep;
	Color originalColor;
	Color transparentColor;
	string sss;

	void Start()
	{
		ExitMessageObj = this.GetComponent<Text>();
		originalColor = ExitMessageObj.color;
		transparentColor = originalColor;
		transparentColor.a = 0;
		ExitMessageObj.text = "再次按下返回键退出游戏";
		ExitMessageObj.color = transparentColor;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (startFadingTimep == 0)
			{
				ExitMessageObj.color = originalColor;
				startFadingTimep = Time.time;
				fading = true;
			}
			else
			{                  Application.Quit();//退出游戏
			}
		}
		if (fading)
		{
			ExitMessageObj.color = Color.Lerp(originalColor, transparentColor, (Time.time - startFadingTimep) * fadingSpeed);
			if (ExitMessageObj.color.a < 2.0 / 255)
			{
				ExitMessageObj.color = transparentColor;
				startFadingTimep = 0;
				fading = false;
			}
		}
	}
}
