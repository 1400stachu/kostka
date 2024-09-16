namespace kostka
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //wygenerowanie liczby losowej
            Random r = new Random();
            //genrujemy rzut kostką K6 - <1;6>
            int kostka = r.Next(1, 7);
            //wyświetlenie wyniku
            RollValueLabel.Text = "Wysolowany rzut: " + kostka.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}