using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace _5b3g0901
{
    public partial class MyDocumentViewer : Window
    {
        public MyDocumentViewer()
        {
            InitializeComponent();

            FontFamilyComboBox.ItemsSource = Fonts.SystemFontFamilies;
            FontFamilyComboBox.SelectedItem = new FontFamily("Microsoft JhengHei");

            double[] sizes = { 8, 10, 12, 14, 16, 18, 20, 24, 28, 36, 48, 72 };
            FontSizeComboBox.ItemsSource = sizes;
            FontSizeComboBox.SelectedItem = 12.0;
        }

        private void TextColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (MyRichTextBox != null && e.NewValue != null)
            {
                SolidColorBrush brush = new SolidColorBrush(e.NewValue.Value);
                MyRichTextBox.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, brush);
            }
        }

        private void FontFamilyComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (MyRichTextBox != null && FontFamilyComboBox.SelectedItem != null)
            {
                MyRichTextBox.Selection.ApplyPropertyValue(TextElement.FontFamilyProperty, FontFamilyComboBox.SelectedItem);
            }
        }

        private void FontSizeComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (MyRichTextBox != null && FontSizeComboBox.SelectedItem != null)
            {
                MyRichTextBox.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, FontSizeComboBox.SelectedItem);
            }
        }
    }
}
