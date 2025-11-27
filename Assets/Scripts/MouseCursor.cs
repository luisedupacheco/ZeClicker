using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    void Start()
    {

        // Desativa o cursor padrão do mouse (seta)
        Cursor.visible = false;
              
    }
    
    void Update()
    {

        // Salva a posição global do ponteiro do mouse em uma variável
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        // Seta a posição do objeto (novo cursor) para essa posição salva anteriormente
        transform.position = mousePosition;

    }

}
