namespace DefaultNamespace
{
    public class GUI
    {
        public string Maintext { get; set; }
        public string OptionsText { get; set; }

        public GUI(string maintext, string optionsText)
        {
            Maintext = maintext;
            OptionsText = optionsText;
        }

        // Public methods
        public void ShowText()
        {
            Console.WriteLine(Maintext);
        }
        public void UpdateText()
        {
            // Implementation for updating text on the GUI
        }

        public void Delay()
        {
            // Implementation for delay (e.g., thread sleep or similar logic)
        }

        public void ChangeMaintext(string newText)
        {
            Maintext = newText;
        }

        public void ChangeOptions()
        {
            // Implementation for changing options text
        }
    }
}