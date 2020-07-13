namespace _12hLecture
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Constuctor App
        /// </summary>
        static App()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
              new System.Globalization.CultureInfo("en");
        }
    }
}
