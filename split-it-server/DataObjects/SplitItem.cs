using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace split_it_server.DataObjects
{
    public class SplitItem : EntityData
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Location { get; set; }
        public DateTime Time { get; set; }
        public bool Paid { get; set; }
        public int SplitBetween { get; set; }
        public int SplitType { get; set; }
    }
}