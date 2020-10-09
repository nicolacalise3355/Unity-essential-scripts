public class ShooterTrigger2: {

	//si mette sulla telecamera insiee a quell altr

	public GameObject logShooter; //assegnamoci un oggetto tipo personaggio

	void update(){
		if(Input.GetKeyDown(KeyCode.s)){
			LogShooter2 lg = logShooter.GetComponent<LogShooter2>();
			if(lg != null){
				lg.shootlog("HELLO!");
			}
		}
	}



}