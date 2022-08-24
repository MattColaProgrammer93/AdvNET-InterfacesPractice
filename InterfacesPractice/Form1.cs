namespace InterfacesPractice
{
    public partial class Form1 : Form
    {
        private readonly ILogger _logger;

        public Form1(ILogger logger)
        {
            _logger = logger;
            InitializeComponent();
        }

        private void btnCreateAndSort_Click(object sender, EventArgs e)
        {
            _logger.Log("Create and Sort button was clicked");

            string sentence = "The day is pretty bright, pretty cool right?";
            int wordCount = sentence.WordCount();
            MessageBox.Show(wordCount.ToString());

            /*string phoneNumber = "123";
            if (phoneNumber.IsPhoneNumber())
            {

            }*/

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

            Candy can4 = null!;

            List<Candy> candies = new()
            {
                can1, 
                can2, 
                can3,
                can4
            };

            candies.Sort();

            MessageBox.Show("Candies are sorted");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _logger.Log("Form is loaded");
        }
    }
}