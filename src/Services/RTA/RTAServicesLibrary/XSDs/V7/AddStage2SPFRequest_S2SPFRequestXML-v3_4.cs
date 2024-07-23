﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 

namespace RTAServicesLibraryV7
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Stage2SettlementPackRequest
    {

        private Stage2SettlementPackRequestClaimantRepresentative claimantRepresentativeField;

        private Stage2SettlementPackRequestMedicalReport medicalReportField;

        private CT_A2A_ClaimantLosses[] claimantLossesField;

        private Stage2SettlementPackRequestStatementOfTruth statementOfTruthField;

        private Stage2SettlementPackRequestAgreementData agreementDataField;

        /// <remarks/>
        public Stage2SettlementPackRequestClaimantRepresentative ClaimantRepresentative
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
        public Stage2SettlementPackRequestMedicalReport MedicalReport
        {
            get
            {
                return this.medicalReportField;
            }
            set
            {
                this.medicalReportField = value;
            }
        }

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
        public Stage2SettlementPackRequestStatementOfTruth StatementOfTruth
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

        /// <remarks/>
        public Stage2SettlementPackRequestAgreementData AgreementData
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Stage2SettlementPackRequestClaimantRepresentative
    {

        private CT_A2A_MedCoCase medCoCaseField;

        private string contactNameField;

        private string contactMiddleNameField;

        private string contactSurnameField;

        private string emailAddressField;

        private string referenceNumberField;

        private string telephoneNumberField;

        /// <remarks/>
        public CT_A2A_MedCoCase MedCoCase
        {
            get
            {
                return this.medCoCaseField;
            }
            set
            {
                this.medCoCaseField = value;
            }
        }

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

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //public partial class CT_A2A_MedCoCase
    //{

    //    private C00_YNFlag softTissueField;

    //    private string medCoCaseIDField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public C00_YNFlag SoftTissue
    //    {
    //        get
    //        {
    //            return this.softTissueField;
    //        }
    //        set
    //        {
    //            this.softTissueField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public string MedCoCaseID
    //    {
    //        get
    //        {
    //            return this.medCoCaseIDField;
    //        }
    //        set
    //        {
    //            this.medCoCaseIDField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
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

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //public partial class CT_A2A_ClaimantLosses
    //{

    //    private C18_LossType_R7 lossTypeField;

    //    private C00_YNFlag evidenceAttachedField;

    //    private string commentsField;

    //    private decimal grossValueClaimedField;

    //    private decimal percContribNegDeductionsField;

    //    private decimal interestField;

    //    private C33_TariffType tariffTypeField;

    //    private bool tariffTypeFieldSpecified;

    //    private C34_SelectDurationOfTheInjuryCR selectDurationOfTheInjuryField;

    //    private bool selectDurationOfTheInjuryFieldSpecified;

    //    private C00_YNFlag excepCircumstancesUpliftField;

    //    private bool excepCircumstancesUpliftFieldSpecified;

    //    private C36_ExcepCircumstancesUpliftPerc excepCircumstancesUpliftPercField;

    //    private bool excepCircumstancesUpliftPercFieldSpecified;

    //    private string excepCircumstancesUpliftNoteField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public C18_LossType_R7 LossType
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

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public decimal Interest
    //    {
    //        get
    //        {
    //            return this.interestField;
    //        }
    //        set
    //        {
    //            this.interestField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public C33_TariffType TariffType
    //    {
    //        get
    //        {
    //            return this.tariffTypeField;
    //        }
    //        set
    //        {
    //            this.tariffTypeField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool TariffTypeSpecified
    //    {
    //        get
    //        {
    //            return this.tariffTypeFieldSpecified;
    //        }
    //        set
    //        {
    //            this.tariffTypeFieldSpecified = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public C34_SelectDurationOfTheInjuryCR SelectDurationOfTheInjury
    //    {
    //        get
    //        {
    //            return this.selectDurationOfTheInjuryField;
    //        }
    //        set
    //        {
    //            this.selectDurationOfTheInjuryField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool SelectDurationOfTheInjurySpecified
    //    {
    //        get
    //        {
    //            return this.selectDurationOfTheInjuryFieldSpecified;
    //        }
    //        set
    //        {
    //            this.selectDurationOfTheInjuryFieldSpecified = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public C00_YNFlag ExcepCircumstancesUplift
    //    {
    //        get
    //        {
    //            return this.excepCircumstancesUpliftField;
    //        }
    //        set
    //        {
    //            this.excepCircumstancesUpliftField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool ExcepCircumstancesUpliftSpecified
    //    {
    //        get
    //        {
    //            return this.excepCircumstancesUpliftFieldSpecified;
    //        }
    //        set
    //        {
    //            this.excepCircumstancesUpliftFieldSpecified = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public C36_ExcepCircumstancesUpliftPerc ExcepCircumstancesUpliftPerc
    //    {
    //        get
    //        {
    //            return this.excepCircumstancesUpliftPercField;
    //        }
    //        set
    //        {
    //            this.excepCircumstancesUpliftPercField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool ExcepCircumstancesUpliftPercSpecified
    //    {
    //        get
    //        {
    //            return this.excepCircumstancesUpliftPercFieldSpecified;
    //        }
    //        set
    //        {
    //            this.excepCircumstancesUpliftPercFieldSpecified = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    //    public string ExcepCircumstancesUpliftNote
    //    {
    //        get
    //        {
    //            return this.excepCircumstancesUpliftNoteField;
    //        }
    //        set
    //        {
    //            this.excepCircumstancesUpliftNoteField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    //[System.SerializableAttribute()]
    //public enum C18_LossType_R7
    //{

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

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("13")]
    //    Item13,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("14")]
    //    Item14,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("15")]
    //    Item15,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("16")]
    //    Item16,
    //}

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    //[System.SerializableAttribute()]
    //public enum C33_TariffType
    //{

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("1")]
    //    Item1,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("2")]
    //    Item2,
    //}

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    //[System.SerializableAttribute()]
    //public enum C34_SelectDurationOfTheInjuryCR
    //{

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
    //}

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    //[System.SerializableAttribute()]
    //public enum C36_ExcepCircumstancesUpliftPerc
    //{

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

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("13")]
    //    Item13,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("14")]
    //    Item14,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("15")]
    //    Item15,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("16")]
    //    Item16,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("17")]
    //    Item17,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("18")]
    //    Item18,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("19")]
    //    Item19,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("20")]
    //    Item20,
    //}

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Stage2SettlementPackRequestMedicalReport
    {

        private C22_MedicalReport medicalReportStage2Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C22_MedicalReport MedicalReportStage2
        {
            get
            {
                return this.medicalReportStage2Field;
            }
            set
            {
                this.medicalReportStage2Field = value;
            }
        }
    }

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    //[System.SerializableAttribute()]
    //public enum C22_MedicalReport
    //{

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
    //}

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Stage2SettlementPackRequestStatementOfTruth
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
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    //[System.SerializableAttribute()]
    //public enum C16_SignatoryType
    //{

    //    /// <remarks/>
    //    S,

    //    /// <remarks/>
    //    C,
    //}

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Stage2SettlementPackRequestAgreementData
    {

        private string commentsField;

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
    }
}