using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesMenu : MonoBehaviour
{

    public void IniciarJogo()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }





}
