﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 

namespace ELPLServicesLibrary
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

        private CourtProceedingPackRequestDisbursementDisputedRequestResponse[] disbursementDisputedField;

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
        public CourtProceedingPackRequestDisbursementDisputedRequestResponse[] DisbursementDisputed
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

        private decimal percInterestRateField;

        private string commentsField;

        private decimal grossValueClaimedField;

        private C00_YNFlag evidenceAttachedField;

        private decimal valueClaimedAfterContribField;

        private C18_LossType_ELPL lossTypeField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public decimal GrossValueClaimed
        {
            get
            {
                return this.grossValueClaimedField;
            }
            set
            {
                this.grossValueClaimedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag EvidenceAttached
        {
            get
            {
                return this.evidenceAttachedField;
            }
            set
            {
                this.evidenceAttachedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public decimal ValueClaimedAfterContrib
        {
            get
            {
                return this.valueClaimedAfterContribField;
            }
            set
            {
                this.valueClaimedAfterContribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C18_LossType_ELPL LossType
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
}