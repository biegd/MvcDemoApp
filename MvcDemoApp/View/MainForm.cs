using System;
using System.Windows.Forms;

namespace MvcDemoApp.View
{
    public partial class MainForm : Form
    {
        public event Action<string> OnGreet;

        private TextBox nameTextBox;
        private Label greetingLabel;

        public MainForm()
        {
            //InitializeComponent();

            this.Text = "MVC Demo";
            this.Width = 400;
            this.Height = 200;

            nameTextBox = new TextBox { Left = 20, Top = 20, Width = 200 };
            var greetButton = new Button { Text = "Grüßen", Left = 240, Top = 20 };
            greetingLabel = new Label { Left = 20, Top = 60, Width = 300 };

            greetButton.Click += (sender, e) => OnGreet?.Invoke(nameTextBox.Text);

            this.Controls.Add(nameTextBox);
            this.Controls.Add(greetButton);
            this.Controls.Add(greetingLabel);
        }

        public void SetGreeting(string message)
        {
            greetingLabel.Text = message;
        }
    }
}
