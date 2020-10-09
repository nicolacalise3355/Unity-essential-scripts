public class floor1: {

	//quando attraversata dalla sphere1 LOG

	//deve essere Trigger
	//visionare Collider MAtrix per vedere cosa collide con cosa

	//quando entra
	void OnTriggerEnter(Collider other){
		 Debug.Log(other.gameObject.name);
	}

	//quando esce
	void OnTriggerExit(Collider other){
		Debug.Log(other.gameObject.name);
	}


}