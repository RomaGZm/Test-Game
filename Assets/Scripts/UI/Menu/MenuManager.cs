using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private MenuView _view;
    private MenuController _controller;
    private MenuModel _model;

    [SerializeField]
    private Lives _livesData;


    /// <summary>
    /// Init menu  
    /// </summary>
    private void Awake()
    {       

        _model = new MenuModel(_livesData);
        _controller = new MenuController(_model, _view);
       
    }
   
}
