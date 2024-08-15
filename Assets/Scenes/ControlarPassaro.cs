using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ControladorPassaro : MonoBehaviour
{
    private UIDocument document;
    private Button botaoVermelho;
    private Button botaoAzul;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        botaoVermelho = document.rootVisualElement.Q<Button>("btnVermelho");
        botaoVermelho.RegisterCallback<ClickEvent>(onBotaoVermelhoClick);

        botaoAzul = document.rootVisualElement.Q<Button>("btnAzul");
        botaoAzul.RegisterCallback<ClickEvent>(onBotaoAzulClick);

    }

    void onBotaoVermelhoClick(ClickEvent evt)
    {
        SceneManager.LoadScene("CenaPrincipal");
    }

    void onBotaoAzulClick(ClickEvent evt)
    {
        SceneManager.LoadScene("CenaPrincipal1");
    }
}
