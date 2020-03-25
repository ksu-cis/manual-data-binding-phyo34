using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Adds event handler to our notes , whenver our note changes, this should be invoked 
        /// </summary>
        public event EventHandler NoteChanged;

        /// <summary>
        /// Private backing variable for title 
        /// </summary>

        private string title = DateTime.Now.ToString();

        /// <summary>
        /// The title of the Note
        /// </summary>
        public string Title
        {
            get { return title; }
            set
            {
                if (title == value) return;
                title = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// private backing variable for our body 
        /// </summary>
        private string body = "";

        /// <summary>
        /// The text of the note
        /// </summary>
        public string Body
        {
            get { return body; }
            set
            {
                if (body == value) return;
                body = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }
    }
}
