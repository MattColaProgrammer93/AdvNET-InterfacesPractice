namespace InterfacesPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateAndSort_Click(object sender, EventArgs e)
        {
            Candy can1 = new()
            {
                Name = "JollyCracker",
                Flavor = "Watermellon",
                DateOfCreation = new DateTime(1998, 1, 7)
            };

            Candy can2 = new()
            {
                Name = "GummyFret",
                Flavor = "Strawberry",
                DateOfCreation = new DateTime(1994, 4, 3)
            };

            Candy can3 = new()
            {
                Name = "BlokyGum",
                Flavor = "Lemon",
                DateOfCreation = new DateTime(1999, 9, 12)
            };

            List<Candy> candies = new()
            {
                can1, 
                can2, 
                can3
            };

            candies.Sort();

            MessageBox.Show("Candies are sorted");
        }
    }
}