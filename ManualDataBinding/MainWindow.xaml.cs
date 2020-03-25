using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ManualDataBinding.Data;

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Creates the note to add to our window 
        /// </summary>
        Note note = new Note();
        public MainWindow()
        {
            InitializeComponent();
            Editor.Note = note;
        }

        /// <summary>
        /// Event handler to create new note and apply it to the editor
        /// </summary>
        /// <param name="sender">button clicked</param>
        /// <param name="e">the event args</param>
        public void OnNewNote(object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.Note = note;
        }

        /// <summary>
        /// Event handler that clears the contents of the notes 
        /// </summary>
        /// <param name="snder">button clicked</param>
        /// <param name="e">the event args</param>
        public void OnClearNote(object snder, RoutedEventArgs e)
        {
            note.Body = "";
        }

        /// <summary>
        /// Event handler to mutate the current note
        /// </summary>
        /// <param name="snder">button clicked</param>
        /// <param name="e">the event args</param>
        public void OnMutateNote(object snder, RoutedEventArgs e)
        {
            note.Title = "Master Splinter";
            note.Body = "There is no monster more dangerous than a lack of compassion";
        }
    }
}
