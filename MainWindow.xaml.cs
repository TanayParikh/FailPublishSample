namespace FailPublishSample;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddWpfBlazorWebView(); //has to change existing ones to use this version for extension.
        serviceCollection.AddBlazorWebViewDeveloperTools();
        serviceCollection.RegisterWPFServices();
        serviceCollection.RegisterBlazorBeginningClasses();
        Resources.Add("services", serviceCollection.BuildServiceProvider());
        Start.DoTab = () =>
        {
            tt.StartTabProcesses();
        };
        InitializeComponent();
    }
}