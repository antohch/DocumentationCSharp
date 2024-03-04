using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMagazine
{
    public enum PublicationType { Misc, Book, Magazine, Article}
    public abstract class Publication
    {
        private bool _published = false;
        private DateTime _datePublished;
        private int _totalPages;

        public Publication(string title, string publisher, PublicationType type) 
        { 
            if (string.IsNullOrWhiteSpace(publisher))
                throw new ArgumentException("The publisher is required.");
            Publisher = publisher;

            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("The title is required.");
            Title = title;

            Type = type;
        }

        public string Publisher { get; }
        public string Title { get; }
        public PublicationType Type { get; }
        public string? CopyrightName { get; private set; }
        public int CopyrightDate { get; private set; }
        public int Pages
        {
            get { return _totalPages; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "The number of pages cannot be zero or negative.");
                _totalPages = value;
            }
        }

        public string GetPublicationDate()
        {
            if (!_published)
                return "NYP";
            else
                return _datePublished.ToString("d");
        }
        public void Publish(DateTime datePublished)
        {
            _published = true;
            _datePublished = datePublished;
        }
        public void Copyright(string copyrighName, int copyrighDate)
        {
            if (string.IsNullOrWhiteSpace(copyrighName))
                throw new ArgumentException("The name of the copyright holder is required.");
            CopyrightName = copyrighName;

            int currentYear = DateTime.Now.Year;
            if (copyrighDate < currentYear - 10 || CopyrightDate > currentYear + 2)
                throw new ArgumentOutOfRangeException($"The copyright year must be between {currentYear - 10} and {currentYear + 1}");
            CopyrightDate = copyrighDate;
        }
        public override string ToString() => Title;
    }
}
