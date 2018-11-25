using Microsoft.VisualStudio.Text.Classification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorDebug.ColorOutput
{
    internal class InformationAboutFormat
    {
        public InformationAboutFormat(string key, string checkedValue, bool isStart, IClassificationType classificationType)
        {
            Key = key;
            CheckedValue = checkedValue;
            ClassificationType = classificationType;
        }

        private bool _isStart;
        public bool IsStart
        {
            get { return _isStart; }
            set
            {
                if (_isStart != value)
                {
                    _isStart = value;
                }
            }
        }

        private string _key;
        public string Key
        {
            get { return _key; }
            private set { _key = value; }
        }

        private string _checkedValue;
        public string CheckedValue
        {
            get { return _checkedValue; }
            private set
            {
                if (_checkedValue != value)
                {
                    _checkedValue = value;
                }
            }
        }

        private IClassificationType _classificationType;
        public IClassificationType ClassificationType
        {
            get { return _classificationType; }
            private set { _classificationType = value; }
        }

        internal bool IsContain(string text, out IClassificationType classificationType)
        {
            classificationType = (IsStart ? text.StartsWith(CheckedValue) : text.Contains(CheckedValue)) ? ClassificationType : null;
            return classificationType != null;
        }
    }
}
