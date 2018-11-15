using LandscapeGeneratorMenu.Model.Menu;
using LandscapeGeneratorMenu.Model.Menu.Interface;
using LandscapeGeneratorMenu.View.Interface;

namespace LandscapeGeneratorMenu.Presenter
{
    class MenuFormPresenter
    {
        private IMenuView menuView;
        private IMenuTemplate menuTemplate;
        public MenuFormPresenter(IMenuView menuView)
        {
            this.menuView = menuView;
            this.menuTemplate = new MenuTemplateModel();
        }
    }
}
