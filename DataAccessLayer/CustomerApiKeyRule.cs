//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerApiKeyRule
    {
        public int Id { get; set; }
        public int ApiKeyId { get; set; }
        public string Mode { get; set; }
        public string Method { get; set; }
        public string Domain { get; set; }
        public string Operation { get; set; }
        public string Ip { get; set; }
        public string ApplicationName { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime Changed { get; set; }
        public string ChangedBy { get; set; }
    
        public virtual CustomerApiKey CustomerApiKey { get; set; }
    }
}
