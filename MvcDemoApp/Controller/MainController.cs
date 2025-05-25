using MvcDemoApp.Model;
using MvcDemoApp.View;

namespace MvcDemoApp.Controller
{
    public class MainController
    {
        private readonly PersonModel _model;
        private readonly MainForm _view;

        public MainController(PersonModel model, MainForm view)
        {
            _model = model;
            _view = view;

            _view.OnGreet += GreetPerson;
        }

        private void GreetPerson(string name)
        {
            _model.Name = name;
            string message = _model.GetGreeting();
            _view.SetGreeting(message);
        }
    }
}
