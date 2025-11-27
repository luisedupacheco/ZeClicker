using Unity.VisualScripting;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{

    void Start()
    {

        // Armazena o Rigidbody2D do objeto que vai ser instanciado em uma variável
        Rigidbody2D objectRB = GetComponent<Rigidbody2D>();

        // Armazena uma direção aleatória com range (X,Y) para o impulso
        Vector3 forceDirection = new Vector3(Random.Range(-10f, 10f), 24f, 0).normalized * 24f;

        // o que significa cada parte da linha acima:
        // Vector3: Cria um vetor 3D
        // new Vector3(): Inicializa um novo vetor 3D
        // Random.Range(-10f, 10f): Gera um valor aleatório entre -10 e 10 para o eixo X
        // 12f: Define o valor fixo de 12 para o eixo Y
        // 0: Define o valor fixo de 0 para o eixo Z
        // .normalized: Normaliza o vetor, ou seja, ajusta seu comprimento para 1, mantendo sua direção
        // * 12f: Multiplica o vetor normalizado por 12, ajustando seu comprimento para 12 unidades

        // multiplicamos no final porque queremos que o impulso tenha uma magnitude de 12 unidades, ou seja,
        // queremos que o objeto seja impulsionado com uma força de 12 unidades na direção calculada.

        // esse 12f tem a ver com o 12f do eixo Y? Não diretamente. O 12f no eixo Y define a direção inicial do impulso,
        // enquanto o * 12f no final ajusta a magnitude total do vetor de força resultante.

        // em um bom português: primeiro definimos a direção do impulso (com um valor fixo no eixo Y e um valor aleatório no eixo X),
        // depois normalizamos esse vetor para garantir que ele tenha um comprimento de 1, em seguida,
        // multiplicamos por 12 para definir a força total do impulso.

        // então se trocar o 12f do eixo Y para 15f, o impulso terá uma direção diferente, mas a magnitude total do impulso ainda será 12 unidades,
        // porque estamos normalizando o vetor antes de multiplicar por 12f.

        // nesse contexto, magnitude pode significar "força total do impulso" ou "tamanho do vetor de força".


        // Aplica o impulso no objeto instanciado, baseado na direção armazenada acima
        objectRB.AddForce(forceDirection, ForceMode2D.Impulse);

    }

    void Update()
    {

        // Verifica se a posição do objeto instanciado está fora da câmera
        if (transform.position.y < -7 || transform.position.x < -5 || transform.position.x > 5)
        {

            // Se sim, destrói o objeto
            Destroy(gameObject);

        }

    }

}
