namespace _12hLecture
{
    using System;
    using System.Globalization; // Лишний using.
    using System.Reflection;
    using System.Resources;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Entry Point
        /// </summary>
        public MainWindow()
        {
            this.Initialized += this.WindowInitilized;
            InitializeComponent();  // StyleCop.
        }

        /// <summary>
        /// Дополнительное события иницилизации
        /// </summary>
        /// <param name="sender">object отправитель</param>
        /// <param name="e">аргумент события</param>
        public void WindowInitilized(object sender, EventArgs e)
        {
            var resMan = new ResourceManager("_12hLecture.TextMessages", Assembly.GetExecutingAssembly());
            MessageBox.Show(resMan.GetString("HelloMessage", new System.Globalization.CultureInfo("en")));
        }

        /// <summary>
        /// Обработичк кноки
        /// </summary>
        /// <param name="sender">object отправитель</param>
        /// <param name="e">аргумент события</param>
        private void button1_Click(object sender, RoutedEventArgs e) // StyleCop.
        {
            MessageBox.Show(TextMessages.HelloMessage);
        }
    }
}
