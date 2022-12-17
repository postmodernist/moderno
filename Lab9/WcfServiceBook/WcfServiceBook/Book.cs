using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfServiceBook
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public Int32 BookId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Year { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public int PagesCount { get; set; }
        
    }
}