
public class spawn: {

	//gli diamo un oggetto
	public GameObject cuboPrefab;

	void start(){
		Debug.Log("Log del sistema");
		// Instantiate(cuboPrefab); //lo spawna a 0 0 0
	}

	void update(){
		spawnaOggetto();
	}

	void spawnaOggetto(){ // 0 = click mouse sinistro
		float x = Random.Range(-5,5);
		float y = Random.Range(-5,5);
		float z = Random.Range(-5,5);

		Vector3 position = new Vector3(x,y,z);

		Quaternion rotazione = cuboPrefab.transform.rotation;

		if(Input.GetMouseButtonUp(0)){
			Instantiate(cuboPrefab, position, rotazione);
		}
	}


}