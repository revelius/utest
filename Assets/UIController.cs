using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    PanelRenderer renderer;
    VisualElement root;
    public GameObject sphere;
    Button btn1;
    Button btn2;
    void Start()
    {
        renderer = GetComponent<PanelRenderer>();
        renderer.RegisterUIReloadCallback(OnUIReload);
    }
    void OnUIReload(PanelRenderer panelRenderer, VisualElement root, int version)
    {
        this.root = root;
        btn1 = root.Q<Button>("Btn1");
        btn2 = root.Q<Button>("Btn2");
        btn1.clicked += Show;
    }

    void Update()
    {
        
    }
    void Show()
    {
        Debug.Log("공 나타나게 할꺼임");
    }
}
