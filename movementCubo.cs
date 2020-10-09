public class movementCubo: {

	float speed = 5;

	void start(){

	}

	void update(){
		movement();
	}

	// ci possiamo muovere su 3 assi
	void movement(){

		//se inizializziamo a 0
		Vector3 direzione = new Vector3(0,0,0);

		float movimentoOrizzontale = Input.GetAxis("Horizontal");
		float movimentoVerticale = Input.GetAxis("Vertical");

		if(movimentoOrizzontale != 0){	
			//diamo a Z lo spostamento orizzontale
			direzione.z = movimentoOrizzontale;
		}

		if(movimentoVerticale != 0){
			//diamo a y lo spostamento verticale
			direzione.y = movimentoVerticale;
		}

		/*
		transform -> indica il transform dell'oggetto corrente
		Translate -> transla/fa muovere un oggetto
		speed -> velocita con cui si muove
		Time.deltaTime -> serve per compensare la differenza di FPS
		*/
		
		transform.Translate(direzione * speed * Time.deltaTime);
	}

}