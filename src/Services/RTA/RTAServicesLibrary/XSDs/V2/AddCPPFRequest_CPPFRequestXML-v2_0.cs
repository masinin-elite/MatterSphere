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
    public partial class CourtProceedingPackRequest
    {

        private CourtProceedingPackRequestClaimAndClaimantDetails claimAndClaimantDetailsField;

        private CourtProceedingPackRequestLastClaimantOffer[] claimantLossesField;

        private CourtProceedingPackRequestCourtProceedingsPackPartA courtProceedingsPackPartAField;

        private CourtProceedingPackRequestDisbursementDisputedRequestResponse[] disbursmentDisputedField;

        private CourtProceedingPackRequestCourtProceedingsPackPartB courtProceedingsPackPartBField;

        private CourtProceedingPackRequestDefendantLegalRepresentative defendantLegalRepresentativeField;

        private CourtProceedingPackRequestStatementOfTruth statementOfTruthField;

        /// <remarks/>
        public CourtProceedingPackRequestClaimAndClaimantDetails ClaimAndClaimantDetails
        {
            get
            {
                return this.claimAndClaimantDetailsField;
            }
            set
            {
                this.claimAndClaimantDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("LastClaimantOffer", IsNullable = false)]
        public CourtProceedingPackRequestLastClaimantOffer[] ClaimantLosses
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
        public CourtProceedingPackRequestCourtProceedingsPackPartA CourtProceedingsPackPartA
        {
            get
            {
                return this.courtProceedingsPackPartAField;
            }
            set
            {
                this.courtProceedingsPackPartAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DisbursementDisputedRequestResponse", IsNullable = false)]
        public CourtProceedingPackRequestDisbursementDisputedRequestResponse[] DisbursmentDisputed
        {
            get
            {
                return this.disbursmentDisputedField;
            }
            set
            {
                this.disbursmentDisputedField = value;
            }
        }

        /// <remarks/>
        public CourtProceedingPackRequestCourtProceedingsPackPartB CourtProceedingsPackPartB
        {
            get
            {
                return this.courtProceedingsPackPartBField;
            }
            set
            {
                this.courtProceedingsPackPartBField = value;
            }
        }

        /// <remarks/>
        public CourtProceedingPackRequestDefendantLegalRepresentative DefendantLegalRepresentative
        {
            get
            {
                return this.defendantLegalRepresentativeField;
            }
            set
            {
                this.defendantLegalRepresentativeField = value;
            }
        }

        /// <remarks/>
        public CourtProceedingPackRequestStatementOfTruth StatementOfTruth
        {
            get
            {
                return this.statementOfTruthField;
            }
            set
            {
                this.statementOfTruthField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CourtProceedingPackRequestClaimAndClaimantDetails
    {

        private CourtProceedingPackRequestClaimAndClaimantDetailsClaimantRepresentative claimantRepresentativeField;

        private CourtProceedingPackRequestClaimAndClaimantDetailsClaimantDetails claimantDetailsField;

        /// <remarks/>
        public CourtProceedingPackRequestClaimAndClaimantDetailsClaimantRepresentative ClaimantRepresentative
        {
            get
            {
                return this.claimantRepresentativeField;
            }
            set
            {
                this.claimantRepresentativeField = value;
            }
        }

        /// <remarks/>
        public CourtProceedingPackRequestClaimAndClaimantDetailsClaimantDetails ClaimantDetails
        {
            get
            {
                return this.claimantDetailsField;
            }
            set
            {
                this.claimantDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CourtProceedingPackRequestClaimAndClaimantDetailsClaimantRepresentative
    {

        private CT_A2A_CompanyDetails companyDetailsField;

        /// <remarks/>
        public CT_A2A_CompanyDetails CompanyDetails
        {
            get
            {
                return this.companyDetailsField;
            }
            set
            {
                this.companyDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_A2A_CompanyDetails
    {

        private string contactNameField;

        private string contactMiddleNameField;

        private string contactSurnameField;

        private string emailAddressField;

        private string referenceNumberField;

        private string telephoneNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ContactName
        {
            get
            {
                return this.contactNameField;
            }
            set
            {
                this.contactNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ContactMiddleName
        {
            get
            {
                return this.contactMiddleNameField;
            }
            set
            {
                this.contactMiddleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ContactSurname
        {
            get
            {
                return this.contactSurnameField;
            }
            set
            {
                this.contactSurnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string EmailAddress
        {
            get
            {
                return this.emailAddressField;
            }
            set
            {
                this.emailAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ReferenceNumber
        {
            get
            {
                return this.referenceNumberField;
            }
            set
            {
                this.referenceNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string TelephoneNumber
        {
            get
            {
                return this.telephoneNumberField;
            }
            set
            {
                this.telephoneNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CourtProceedingPackRequestClaimAndClaimantDetailsClaimantDetails
    {

        private string occupation_CPPField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Occupation_CPP
        {
            get
            {
                return this.occupation_CPPField;
            }
            set
            {
                this.occupation_CPPField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CourtProceedingPackRequestLastClaimantOffer
    {

        private C18_LossType_R2 lossTypeField;

        private decimal percInterestRateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C18_LossType_R2 LossType
        {
            get
            {
                return this.lossTypeField;
            }
            set
            {
                this.lossTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public decimal PercInterestRate
        {
            get
            {
                return this.percInterestRateField;
            }
            set
            {
                this.percInterestRateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    public enum C18_LossType_R2
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CourtProceedingPackRequestCourtProceedingsPackPartA
    {

        private C00_YNFlag allDisbursementAgreedAndPaidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag AllDisbursementAgreedAndPaid
        {
            get
            {
                return this.allDisbursementAgreedAndPaidField;
            }
            set
            {
                this.allDisbursementAgreedAndPaidField = value;
            }
        }
    }

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    //[System.SerializableAttribute()]
    //public enum C00_YNFlag
    //{

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("1")]
    //    Item1,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("0")]
    //    Item0,
    //}

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CourtProceedingPackRequestDisbursementDisputedRequestResponse
    {

        private decimal amountClaimedField;

        private decimal amountPaidField;

        private string disbursementDisputedField;

        private string disbursementIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public decimal AmountClaimed
        {
            get
            {
                return this.amountClaimedField;
            }
            set
            {
                this.amountClaimedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public decimal AmountPaid
        {
            get
            {
                return this.amountPaidField;
            }
            set
            {
                this.amountPaidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string DisbursementDisputed
        {
            get
            {
                return this.disbursementDisputedField;
            }
            set
            {
                this.disbursementDisputedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string DisbursementId
        {
            get
            {
                return this.disbursementIdField;
            }
            set
            {
                this.disbursementIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CourtProceedingPackRequestCourtProceedingsPackPartB
    {

        private CourtProceedingPackRequestCourtProceedingsPackPartBFixedCosts fixedCostsField;

        private decimal claimantFinalOfferField;

        private decimal defendantFinalOfferField;

        /// <remarks/>
        public CourtProceedingPackRequestCourtProceedingsPackPartBFixedCosts FixedCosts
        {
            get
            {
                return this.fixedCostsField;
            }
            set
            {
                this.fixedCostsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public decimal ClaimantFinalOffer
        {
            get
            {
                return this.claimantFinalOfferField;
            }
            set
            {
                this.claimantFinalOfferField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public decimal DefendantFinalOffer
        {
            get
            {
                return this.defendantFinalOfferField;
            }
            set
            {
                this.defendantFinalOfferField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CourtProceedingPackRequestCourtProceedingsPackPartBFixedCosts
    {

        private C00_YNFlag stage1FixedCostsPaidField;

        private C00_YNFlag stage2FixedCostsPaidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Stage1FixedCostsPaid
        {
            get
            {
                return this.stage1FixedCostsPaidField;
            }
            set
            {
                this.stage1FixedCostsPaidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Stage2FixedCostsPaid
        {
            get
            {
                return this.stage2FixedCostsPaidField;
            }
            set
            {
                this.stage2FixedCostsPaidField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CourtProceedingPackRequestDefendantLegalRepresentative
    {

        private C00_YNFlag hasDefendantNamedLegalRepField;

        private bool hasDefendantNamedLegalRepFieldSpecified;

        private string defendantLegalDetailsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag HasDefendantNamedLegalRep
        {
            get
            {
                return this.hasDefendantNamedLegalRepField;
            }
            set
            {
                this.hasDefendantNamedLegalRepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasDefendantNamedLegalRepSpecified
        {
            get
            {
                return this.hasDefendantNamedLegalRepFieldSpecified;
            }
            set
            {
                this.hasDefendantNamedLegalRepFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string DefendantLegalDetails
        {
            get
            {
                return this.defendantLegalDetailsField;
            }
            set
            {
                this.defendantLegalDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CourtProceedingPackRequestStatementOfTruth
    {

        private C00_YNFlag retainedSignedCopyField;

        private C16_SignatoryType signatoryTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag RetainedSignedCopy
        {
            get
            {
                return this.retainedSignedCopyField;
            }
            set
            {
                this.retainedSignedCopyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C16_SignatoryType SignatoryType
        {
            get
            {
                return this.signatoryTypeField;
            }
            set
            {
                this.signatoryTypeField = value;
            }
        }
    }

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    //[System.SerializableAttribute()]
    //public enum C16_SignatoryType
    //{

    //    /// <remarks/>
    //    S,

    //    /// <remarks/>
    //    C,
    //}
}