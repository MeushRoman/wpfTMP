using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.Pages
{
    public class Document
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public byte[] Data { get; set; }
        public string FileName { get; set; }
    }
}
