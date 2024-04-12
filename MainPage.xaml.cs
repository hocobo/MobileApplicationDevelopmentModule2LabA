namespace Module2LabA
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            double weight = Convert.ToDouble(weight_inp.Text);
            double height = Convert.ToDouble(height_inp.Text);
            double bmi = (weight / (height * height)) * 703;
            BMI.Text = $"Your BMI is {bmi}";
        }
    }

}
