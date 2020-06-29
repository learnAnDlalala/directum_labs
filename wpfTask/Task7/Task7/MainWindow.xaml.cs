namespace Task7
{
    using System.IO;
    using System.IO.Compression;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;

    /// <summary>
    /// Main class
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Inicilization point
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
            SetContentInRTB(@"D:\direction\q2.rtf.gz", this.textBox1);  // То же что и с логом.
        }

        /// <summary>
        /// Метод заполнения RichTextBox
        /// </summary>
        /// <param name="filepath">path to file</param>
        /// <param name="textBox">current richtexbox</param>
        public static void SetContentInRTB(string filepath, RichTextBox textBox)
        {
            FileInfo file = new FileInfo(filepath);
            if (file.Exists)
            {
                using (FileStream compressedFile = new FileStream(filepath, FileMode.Open))
                using (GZipStream decompreseedFile = new GZipStream(compressedFile, CompressionMode.Decompress, true))
                {
                    TextRange content = new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd);
                    content.Load(decompreseedFile, DataFormats.Rtf);
                }
            }
        }
    }
}
