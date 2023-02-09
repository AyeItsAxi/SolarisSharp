namespace SolarisSharp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static void Init()
        {
            if (!Directory.Exists(Paths.AppDataDirectory))
            {
                Directory.CreateDirectory(Paths.AppDataDirectory);
            }
        }
    }
}
