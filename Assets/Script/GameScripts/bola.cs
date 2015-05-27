using UnityEngine;
using System.Collections;

public class bola : MonoBehaviour {
	
	private int changeside;
	public GameObject prefab;
	public GameObject jogador;
	public GameObject linha;
	private bool comecou;
	private int aumento = 0;
	private int controle;
	private int quant;
	public GameObject[] quantarray;
	public GameObject setaCima;
	public GameObject setaDireita;
	public GameObject setaEsquerda;
	
	void Start () {
		
		controle = aumento - 1;
		
		for (int linhas = 0; linhas <= aumento; linhas++) {
			linha = (GameObject) Instantiate(prefab, new Vector3(-1.3f, linhas-controle,0), Quaternion.identity);
		}
	}
	
	void Update () {
		
		
		// caso o movimento do player for para direita a bola vai para direita (antes de dar Inicio)
		if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.D) && !comecou || Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.Space) && !comecou)
		{
			changeside = 1;
			rigidbody2D.velocity = new Vector2 (4 * changeside, 5);
			comecou = true;
		}
		// caso o movimento do player for para esquerda a bola vai para esquerda (antes de dar inicio)
		if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.A) && !comecou || Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.Space) && !comecou)
		{
			changeside = -1;
			rigidbody2D.velocity = new Vector2(4 * changeside, 5);
			comecou = true;
		}
		
		// caso o jogador nao aperte nada para se movimentar a bola segue em 90 graus
		if (Input.GetKeyDown(KeyCode.Space)  && !comecou || Input.GetKeyDown(KeyCode.Space) && !comecou)
		{
			changeside = 0;
			rigidbody2D.velocity = new Vector2(4 * changeside,5);
			comecou = true;
		}  
		
		
		if (!comecou) {
			transform.position = new Vector2(jogador.transform.position.x, jogador.transform.position.y + 1);
		}
		
		quantarray = GameObject.FindGameObjectsWithTag("Blocos");
		quant = quantarray.Length;
		
		if (quant == 0)
		{
			comecou = false;
			aumento += 1;
			
			for (int linhas = 0; linhas <= aumento; linhas++) {
				linha = (GameObject) Instantiate(prefab, new Vector3(-1.3f, linhas - aumento + 1,0), Quaternion.identity);
			}
			
			transform.position = new Vector2(jogador.transform.position.x, jogador.transform.position.y + 1);		
			rigidbody2D.velocity = Vector2.zero;
			
			if (!comecou) {
				transform.position = new Vector2(jogador.transform.position.x, jogador.transform.position.y + 1);
			}
			
		}
		
	}
}
	