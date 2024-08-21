namespace Module01Exercise01
{
    public partial class MainPage : ContentPage
    {
        public string Firstname { get; set; }
        public Color ColorIndigo { get; set; }
        public MainPage()
        {
            InitializeComponent();

            Firstname = "Hello There!";
            ColorIndigo = Colors.Indigo;

            this.BindingContext = this;
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {

        }

        private void OnChangeBackgroundColorL(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.GreenYellow;
        }

        private void OnChangeBackgroundColorG(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Gold;
        }

        private void OnChangeBackgroundColorR(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Red;
        }


    }

}
