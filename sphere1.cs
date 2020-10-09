public class sphere1: {

	//quando la sfera attraversa il floor1 si fa un Log

	
	void OnCollisionEnter(Collision collision){
		Debug.Log("Ho colliso con: " + collision.gameObject.name);
	}

	//continua a collidere
	void OnCollisionStay(Collision collision){

	}


}