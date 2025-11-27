using UnityEngine;
using TMPro;

public class ObjectManager : MonoBehaviour
{
    // Declara variável de referência para o texto de UI 
    public TextMeshProUGUI textoContadorClique;
    
    // Declara variável para contagem de cliques
    public int contador = 0;

    // Declara variável de referência de posição (transform) para o ponto de spawn
    public Transform spawnPoint;

    // Declara variável de referência para o objeto (spawnpoint) 
    public GameObject objetoGerado;

    // Método para clique no objeto principal
    void OnMouseDown()
    {

        // Aumenta o valor da variável de contagem
        contador++;

        // Seta o valor atualizado da variável no texto da UI
        textoContadorClique.text = contador.ToString();

        // Cria objetos (instâncias) ao clicar no objeto principal
        Instantiate(objetoGerado, spawnPoint.position, spawnPoint.rotation);
              
    }

}
