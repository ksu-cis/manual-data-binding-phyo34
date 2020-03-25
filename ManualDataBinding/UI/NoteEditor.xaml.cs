using System;
using System.Collections.Generic;
using System.Text;
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

namespace ManualDataBinding.UI
{
    /// <summary>
    /// Interaction logic for NoteEditor.xaml
    /// </summary>
    public partial class NoteEditor : UserControl
    {

        /// <summary>
        /// private backing variable for note 
        /// </summary>
        private Note note;

        /// <summary>
        /// Note that will be edited by this control 
        /// </summary>
        public Note Note {
            get { return note; }
            set
            {
                if (note != null) note.NoteChanged -= OnNoteChanged;
                note = value;
                //attach event listener
                if (note != null)
                {
                    note.NoteChanged += OnNoteChanged;
                    OnNoteChanged(note, new EventArgs());
                    //note.NoteChanged += OnNoteChanged;
                    //Title.Text = note.Title;
                    //Body.Text = note.Body;
                }


            }
        }

        public NoteEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event listener for notes changed 
        /// </summary>
        /// <param name="sender">button clicked</param>
        /// <param name="e">the event args</param>
        public void OnNoteChanged (object sender, EventArgs e)
        {
            if (Note == null) return;
            Title.Text = Note.Title;
            Body.Text = Note.Body;

        }

        /// <summary>
        /// Event listener for title change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnTitleChange (object sender, TextChangedEventArgs e)
        {
            Note.Title = Title.Text; 

        }

        /// <summary>
        /// Event listener for body change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnBodyChange(object sender, TextChangedEventArgs e)
        {
            Note.Body = Body.Text;
        }

      
    }
}
