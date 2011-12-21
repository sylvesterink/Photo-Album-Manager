using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Photo_Album
{
    class Photo
    {
        private string _name;
        private string _file;
        private string _path;
        private string _description;
        private Size _dimensions;
        private DateTime _dateAdded;
        private DateTime _dateModified;
        private HashSet<string> _tagList;

        public Photo()
        {
            _name = "";
            _file = "";
            _path = "";
            _description = "";
            _dimensions.Height = _dimensions.Width = 0;
            _dateAdded = DateTime.Now;
            _dateModified = DateTime.Now;
            _tagList = new HashSet<string>();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string File
        {
            get { return _file; }
            set { _file = value; }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int Height
        {
            get { return _dimensions.Height; }
            set { _dimensions.Height = value; }
        }

        public int Width
        {
            get { return _dimensions.Width; }
            set { _dimensions.Width = value; }
        }

        public DateTime DateAdded
        {
            get { return _dateAdded; }
            set { _dateAdded = value; }
        }

        public DateTime DateModified
        {
            get { return _dateModified; }
            set { _dateModified = value; }
        }

        public HashSet<string> Tags
        {
            get { return _tagList; }
            set { _tagList = value; }
        }
    }
}
