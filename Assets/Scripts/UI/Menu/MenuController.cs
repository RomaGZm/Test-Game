

public class MenuController 
{
    private MenuModel Model { get; set; }
    private MenuView View { get; set; }

    /// <summary>
    /// Init menu
    /// </summary>
    /// <param name="model"></param>
    /// <param name="view"></param>
    public MenuController(MenuModel model, MenuView view)
    {
        Model = model;
        View = view;

        View.SetLives(Model.GetLives());
        View.SetTime(Model.GetTime());

    }

}
