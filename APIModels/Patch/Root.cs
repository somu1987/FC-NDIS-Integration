﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FC_NDIS.APIModels.Patch
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    //public class Attributes
    //{
    //    public string type { get; set; }
    //    public string referenceId { get; set; }
    //}

    //public class Record
    //{
    //    public Attributes attributes { get; set; }
    //    public bool Batch_Created__c { get; set; }
    //    public string enrtcr__Client__c { get; set; }
    //    public string enrtcr__Date__c { get; set; }
    //    public decimal enrtcr__Quantity__c { get; set; }
    //    public string enrtcr__Support_Contract_Item__c { get; set; }
    //    public string enrtcr__Support_Contract__c { get; set; }
    //    public string enrtcr__Site__c { get; set; }
    //    public string enrtcr__Support_CategoryId__c { get; set; }
    //    public string enrtcr__Site_Service_Program__c { get; set; }
    //    public string enrtcr__Rate__c { get; set; }
    //    public string enrtcr__Worker__c { get; set; }
    //    public bool enrtcr__Client_Rep_Accepted__c { get; set; }
    //    public bool enrtcr__Use_Negotiated_Rate__c { get; set; }
    //    public decimal enrtcr__Negotiated_Rate_Ex_GST__c { get; set; }
    //    public decimal enrtcr__Negotiated_Rate_GST__c { get; set; }
    //}

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class RichInput
    {
        public bool Batch_Created__c { get; set; }
        public string enrtcr__Client__c { get; set; }
        public string enrtcr__Date__c { get; set; }
        public decimal enrtcr__Quantity__c { get; set; }
        public string enrtcr__Support_Contract_Item__c { get; set; }
        public string enrtcr__Support_Contract__c { get; set; }
        public string enrtcr__Site__c { get; set; }
        public string enrtcr__Support_CategoryId__c { get; set; }
        public string enrtcr__Site_Service_Program__c { get; set; }
        public string enrtcr__Rate__c { get; set; }
        public string enrtcr__Comments__c { get; set; }
        public string enrtcr__Worker__c { get; set; }
        public bool enrtcr__Client_Rep_Accepted__c { get; set; }
        public bool enrtcr__Use_Negotiated_Rate__c { get; set; }
        public decimal enrtcr__Negotiated_Rate_Ex_GST__c { get; set; }
        public decimal enrtcr__Negotiated_Rate_GST__c { get; set; }
    }

    public class BatchRequest
    {
        public string method { get; set; }
        public string url { get; set; }
        public RichInput richInput { get; set; }
    }

    public class Root
    {
        public List<BatchRequest> batchRequests { get; set; }
    }
   
}
