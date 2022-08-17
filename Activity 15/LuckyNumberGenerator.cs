namespace Activity_15
{
    public partial class LuckyNumberGenerator : Form
    {

        

        public LuckyNumberGenerator()
        {
            InitializeComponent();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorButton.BackColor = colorDialog1.Color;
            }
        }

        //Load function, populates countryCombobox
        private void LuckyNumberGenerator_Load(object sender, EventArgs e)
        {
            //Create countries and assign arbitrary values for lucky number solution
            var countryList = new List<Country>();
            countryList.Add(new Country("Australia", 9));
            countryList.Add(new Country("United States of America", 1));
            countryList.Add(new Country("France", 2));
            countryList.Add(new Country("Italy", 5));
            countryList.Add(new Country("Spain", 4));
            countryList.Add(new Country("United Kingdom", 3));
            countryList.Add(new Country("New Zealand", 6));
            countryList.Add(new Country("French Polynesia", 16));
            countryList.Add(new Country("Japan", 8));
            countryList.Add(new Country("Brazil", 10));
            countryList.Add(new Country("Netherlands", 11));
            countryList.Add(new Country("Belgium", 12));
            countryList.Add(new Country("Poland", 13));
            countryList.Add(new Country("Czech Republic", 14));
            countryList.Add(new Country("China", 7));
            countryList.Add(new Country("India", 15));
            //populate countries with their individual cities to visit
            PopulateCountries(countryList);

            //assign list to countryCombobox
            countryCombo.DataSource = countryList;
            countryCombo.DisplayMember = "Name";
            countryCombo.ValueMember = "Value";
            countryCombo.SelectedIndex = 0;

            
        }

        //Method to change city combo box based on choice in country combo box
        private void countryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Country country = (Country)countryCombo.SelectedItem;
            cityCombo.DataSource = country.CityList;
            cityCombo.DisplayMember = "Name";
            cityCombo.ValueMember = "Value";
           
        }

        //method to add cities to countries
        private static void PopulateCountries(List<Country> countries)
        {
            //loop through each country, using their value in a switch statement to differentiate cities
            foreach (Country country in countries)
            {
                switch (country.Value)
                {
                    case 1:
                        country.AddCity("New York", 1);
                        country.AddCity("Phoenix", 2);
                        country.AddCity("Las Vegas", 3);
                        country.AddCity("Miami", 4);
                        country.AddCity("Maui", 5);
                        break;
                    case 2:
                        country.AddCity("Paris", 1);
                        country.AddCity("Marseille", 2);
                        country.AddCity("Lyon", 3);
                        country.AddCity("Carcassonne", 4);
                        country.AddCity("Mont Saint-Michel", 5);
                        break;
                    case 3:
                        country.AddCity("London", 1);
                        country.AddCity("Edinburgh", 2);
                        country.AddCity("Salisbury", 3);
                        country.AddCity("Glasgow", 4);
                        country.AddCity("Belfast", 5);
                        break;
                    case 4:
                        country.AddCity("Barcelona", 1);
                        country.AddCity("Madrid", 2);
                        country.AddCity("Seville", 3);
                        country.AddCity("Palma de Mallorca", 4);
                        country.AddCity("Granada", 5);
                        break;
                    case 5:
                        country.AddCity("Rome", 1);
                        country.AddCity("Florence", 2);
                        country.AddCity("Venice", 3);
                        country.AddCity("Naples", 4);
                        country.AddCity("Pisa", 5);
                        break;
                    case 6:
                        country.AddCity("Auckland", 1);
                        country.AddCity("Christchurch", 2);
                        country.AddCity("Wellington", 3);
                        country.AddCity("Rotorua", 4);
                        country.AddCity("Napier", 5);
                        break;
                    case 7:
                        country.AddCity("Beijing", 1);
                        country.AddCity("Hong Kong", 2);
                        country.AddCity("Shanghai", 3);
                        country.AddCity("Xi'an", 4);
                        country.AddCity("Guangzhou", 5);
                        break;
                    case 8:
                        country.AddCity("Tokyo", 1);
                        country.AddCity("Kyoto", 2);
                        country.AddCity("Osaka", 3);
                        country.AddCity("Fukuoka", 4);
                        country.AddCity("Sapporo", 5);
                        break;
                    case 9:
                        country.AddCity("Sydney", 1);
                        country.AddCity("Melbourne", 2);
                        country.AddCity("Cairns", 3);
                        country.AddCity("Canberra", 4);
                        country.AddCity("Alice Springs", 5);
                        break;
                    case 10:
                        country.AddCity("Rio de Janeiro", 1);
                        country.AddCity("Salvador", 2);
                        country.AddCity("Fortaleza", 3);
                        country.AddCity("Recife", 4);
                        country.AddCity("Manaus", 5);
                        break;
                    case 11:
                        country.AddCity("Amsterdam", 1);
                        country.AddCity("Utrecht", 2);
                        country.AddCity("Rotterdam", 3);
                        country.AddCity("The Hague", 4);
                        country.AddCity("Arnhem", 5);
                        break;
                    case 12:
                        country.AddCity("Brussels", 1);
                        country.AddCity("Antwerp", 2);
                        country.AddCity("Ghent", 3);
                        country.AddCity("Burges", 4);
                        country.AddCity("Mons", 5);
                        break;
                    case 13:
                        country.AddCity("Krakow", 1);
                        country.AddCity("Warsaw", 2);
                        country.AddCity("Gdansk", 3);
                        country.AddCity("Torun", 4);
                        country.AddCity("Wroclaw", 5);
                        break;
                    case 14:
                        country.AddCity("Prague", 1);
                        country.AddCity("Cesky Krumlov", 2);
                        country.AddCity("Karlovy Vary", 3);
                        country.AddCity("Kutna Hora", 4);
                        country.AddCity("Olomouc", 5);
                        break;
                    case 15:
                        country.AddCity("Mumbai", 1);
                        country.AddCity("Dehli", 2);
                        country.AddCity("Jaipur", 3);
                        country.AddCity("Manali", 4);
                        country.AddCity("Agra", 5);
                        break;
                    case 16:
                        country.AddCity("Tahiti", 1);
                        country.AddCity("Bora Bora", 2);
                        country.AddCity("Mo'orea", 3);
                        country.AddCity("The Marquesas", 4);
                        country.AddCity("The Tuamotus", 5);
                        break;
                }
            }
        }

        //button click for getting lucky number generated
        private void luckyNumButton_Click(object sender, EventArgs e)
        {
            //find lucky number
            int luckyNumber = GetLuckyNumber((Country)countryCombo.SelectedItem, (City)cityCombo.SelectedItem, colorButton.BackColor);
            
            //generate new form
            LuckyNumberDisplay display = new LuckyNumberDisplay();
            //change lucky number label to show correct lucky number
            display.luckyNumLabel.Text = luckyNumber.ToString();
            //display new form
            display.ShowDialog();
        }

        //method to derive lucky number
        private static int GetLuckyNumber(Country country, City city, Color color)
        {
            //use RGB values from favorite color and country and city values, then mod by 100 to get lucky number from 0-99
            //Note: If favorite color is pure black, lucky number will always be 0
            int lucky = ((color.R + color.B + color.G) * ((country.Value * 2) + (city.Value * 5))) % 100;
            return lucky;
        }
    }
}