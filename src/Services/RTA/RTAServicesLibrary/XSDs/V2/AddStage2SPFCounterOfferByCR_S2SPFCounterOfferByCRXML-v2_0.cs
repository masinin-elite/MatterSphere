﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 

namespace RTAServicesLibraryV2
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Stage2SettlementPackCounterOfferByCR
    {

        private CT_A2A_ClaimantLosses[] claimantLossesField;

        private Stage2SettlementPackCounterOfferByCRAgreementData agreementDataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CurrentClaimantOffer", IsNullable = false)]
        public CT_A2A_ClaimantLosses[] ClaimantLosses
        {
            get
            {
                return this.claimantLossesField;
            }
            set
            {
                this.claimantLossesField = value;
            }
        }

        /// <remarks/>
        public Stage2SettlementPackCounterOfferByCRAgreementData AgreementData
        {
            get
            {
                return this.agreementDataField;
            }
            set
            {
                this.agreementDataField = value;
            }
        }
    }

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //public partial class CT_A2A_ClaimantLosses
    //{

    //    private C18_LossType_R2 lossTypeField;

    //    private C00_YNFlag evidenceAttachedField;

    //    private string commentsField;

    //    private decimal grossValueClaimedField;

    //    private decimal percContribNegDeductionsField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public C18_LossType_R2 LossType
    //    {
    //        get
    //        {
    //            return this.lossTypeField;
    //        }
    //        set
    //        {
    //            this.lossTypeField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public C00_YNFlag EvidenceAttached
    //    {
    //        get
    //        {
    //            return this.evidenceAttachedField;
    //        }
    //        set
    //        {
    //            this.evidenceAttachedField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public string Comments
    //    {
    //        get
    //        {
    //            return this.commentsField;
    //        }
    //        set
    //        {
    //            this.commentsField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public decimal GrossValueClaimed
    //    {
    //        get
    //        {
    //            return this.grossValueClaimedField;
    //        }
    //        set
    //        {
    //            this.grossValueClaimedField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public decimal PercContribNegDeductions
    //    {
    //        get
    //        {
    //            return this.percContribNegDeductionsField;
    //        }
    //        set
    //        {
    //            this.percContribNegDeductionsField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    //[System.SerializableAttribute()]
    //public enum C18_LossType_R2 {

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("0")]
    //    Item0,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("1")]
    //    Item1,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("2")]
    //    Item2,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("3")]
    //    Item3,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("4")]
    //    Item4,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("5")]
    //    Item5,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("6")]
    //    Item6,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("7")]
    //    Item7,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("8")]
    //    Item8,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("9")]
    //    Item9,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("10")]
    //    Item10,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("11")]
    //    Item11,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("12")]
    //    Item12,
    //}

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    //[System.SerializableAttribute()]
    //public enum C00_YNFlag {

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("1")]
    //    Item1,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("0")]
    //    Item0,
    //}

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //public partial class CT_A2A_AgreementDetails
    //{

    //    private decimal grossAmountField;

    //    private decimal interimPaymentAmountField;

    //    private string commentsField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public decimal GrossAmount
    //    {
    //        get
    //        {
    //            return this.grossAmountField;
    //        }
    //        set
    //        {
    //            this.grossAmountField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public decimal InterimPaymentAmount
    //    {
    //        get
    //        {
    //            return this.interimPaymentAmountField;
    //        }
    //        set
    //        {
    //            this.interimPaymentAmountField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public string Comments
    //    {
    //        get
    //        {
    //            return this.commentsField;
    //        }
    //        set
    //        {
    //            this.commentsField = value;
    //        }
    //    }
    //}

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Stage2SettlementPackCounterOfferByCRAgreementData
    {

        private Stage2SettlementPackCounterOfferByCRAgreementDataFinalAgreementDetails finalAgreementDetailsField;

        /// <remarks/>
        public Stage2SettlementPackCounterOfferByCRAgreementDataFinalAgreementDetails FinalAgreementDetails
        {
            get
            {
                return this.finalAgreementDetailsField;
            }
            set
            {
                this.finalAgreementDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Stage2SettlementPackCounterOfferByCRAgreementDataFinalAgreementDetails
    {

        private CT_A2A_AgreementDetails agreementDetailsField;

        /// <remarks/>
        public CT_A2A_AgreementDetails AgreementDetails
        {
            get
            {
                return this.agreementDetailsField;
            }
            set
            {
                this.agreementDetailsField = value;
            }
        }
    }
}