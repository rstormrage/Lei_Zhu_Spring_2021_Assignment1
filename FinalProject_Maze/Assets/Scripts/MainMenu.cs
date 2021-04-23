using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MainMenu: MonoBehaviour {
private bool menushow; // Use this for initialization 
    void Start () {
DontDestroyOnLoad (this);
menushow = true;//初始化为 true，即显示菜单 
    }
// Update is called once per frame 
    void Update () {
if(Input.GetKey(KeyCode.Escape)){
menushow = true;
 } }
void OnGUI(){
if(menushow == false){
return; }
if(GUI.Button(new Rect( Screen.width/2-30,Screen.height/2-90,60,30 ),"Level 1")){
			SceneManager.LoadScene(1); 
			menushow = false;//隐藏菜单
 }
		else if(GUI.Button(new Rect(Screen.width/2-30,Screen.height/2-50,60,30),"Level 2"))
		{
			SceneManager.LoadScene(2);
			menushow = false;//隐藏菜单
}
		else if
			(GUI.Button(new
Rect(Screen.width/2-30,Screen.height/2-10,60,30),"Help"))
		{ 
			SceneManager.LoadScene(6);
menushow = false;//隐藏菜单
}
		else if (GUI.Button(new
Rect(Screen.width/2-30,Screen.height/2+30,60,30),"Quit"))
		{  //Application.Quit();
			SceneManager.LoadScene(3); 
			menushow = false;//隐藏菜单
}
}
}
