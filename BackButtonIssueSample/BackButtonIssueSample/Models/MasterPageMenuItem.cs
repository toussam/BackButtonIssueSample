using BackButtonIssueSample.Views;
using System;

namespace BackButtonIssueSample.Models
{
    public class MasterPageMenuItem
    {
        public int      Id { get; set; }
        public Type     TargetType { get; set; }
        public string   Title { get; set; }

        public MasterPageMenuItem()
        {
            TargetType = typeof(MasterPageDetail);
        }
    }
}