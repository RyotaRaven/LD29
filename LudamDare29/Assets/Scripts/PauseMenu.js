var gamePaused : boolean = false;
function Start()
{
}
function Update () {

 if(!gamePaused)
 {
	Screen.lockCursor = true;
	Screen.lockCursor = false;
 }
 
 if(Input.GetKeyDown(KeyCode.Escape)){
 if(gamePaused){
 
 Time.timeScale=1.0;
 gamePaused = false;
 Screen.lockCursor=true;
 
 }else{
 
 Time.timeScale = 0.0;
 gamePaused = true;
 Screen.lockCursor=false;
 }
 }
 
}
 
function OnGUI(){
 if(gamePaused){
 if(GUI.Button(Rect (Screen.width/2-50, 100, 100, 30), "Resume")){
 Time.timeScale = 1.0;
 gamePaused = false;
 }
 if(GUI.Button(Rect(Screen.width/2-50, 140, 100, 30), "Main Menu"))
 {
 	gamePaused=false;
	Application.LoadLevel("Menu");
 }
 if(GUI.Button(Rect(Screen.width/2-50, 180, 100, 30), "Restart"))
 {
 gamePaused=false;
 Time.timeScale = 1.0;
 Application.LoadLevel("World");
 }
 if(GUI.Button(Rect(Screen.width/2-50, 220, 100, 30), "Quit")){
 Application.Quit();
    }
 }
 else GUI.Label(Rect(0, 10, 150, 30), "Press Escape to Pause");
}