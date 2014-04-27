var gamePaused : boolean = false;
 
function Update () {
 
 if(Input.GetKeyDown(KeyCode.Escape)){
 if(gamePaused){
 
 Time.timeScale=1.0;
 gamePaused = false;
 
 }else{
 
 Time.timeScale = 0.0;
 gamePaused = true;
 }
 }
 
}
 
function OnGUI(){
 
 if(gamePaused){
 if(GUI.Button(Rect (Screen.width/2-50, 100, 100, 30), "Resume")){
 Time.timeScale = 1.0;
 gamePaused = false;
 }
 if(GUI.Button(Rect(Screen.width/2-50, 140, 100, 30), "Main Menu")){
	Application.LoadLevel("Menu");
 }
 if(GUI.Button(Rect(Screen.width/2-50, 180, 100, 30), "Restart"))
 {
 Time.timeScale = 1.0;
 Application.LoadLevel("World");
 }
 if(GUI.Button(Rect(Screen.width/2-50, 220, 100, 30), "Quit")){
 Application.Quit();
    }
 }
}