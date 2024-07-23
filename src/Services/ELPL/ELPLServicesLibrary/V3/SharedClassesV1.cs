﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ELPLServicesLibrary
{
    #region CT_A2A_ClaimantLosses_ELPL
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_A2A_ClaimantLosses_ELPL
    {

        private C18_LossType_ELPL lossTypeField;

        private bool lossTypeFieldSpecified;

        private C00_YNFlag evidenceAttachedField;

        private string commentsField;

        private decimal grossValueClaimedField;

        private decimal interestField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LossTypeSpecified
        {
            get
            {
                return this.lossTypeFieldSpecified;
            }
            set
            {
                this.lossTypeFieldSpecified = value;
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
        public decimal Interest
        {
            get
            {
                return this.interestField;
            }
            set
            {
                this.interestField = value;
            }
        }
    }
    #endregion CT_A2A_ClaimantLosses_ELPL


    #region CT_A2A_CompanyDetails
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
    #endregion CT_A2A_CompanyDetails


    #region CT_INPUT_Claim_Details_ELPL
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Claim_Details_ELPL
    {

        private C16_SignatoryType signatoryField;

        private C00_YNFlag retainedCopyField;

        private C29_ClaimValue claimValueField;

        private C30_ClaimType claimTypeField;

        private System.DateTime notificationDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C16_SignatoryType Signatory
        {
            get
            {
                return this.signatoryField;
            }
            set
            {
                this.signatoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag RetainedCopy
        {
            get
            {
                return this.retainedCopyField;
            }
            set
            {
                this.retainedCopyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C29_ClaimValue ClaimValue
        {
            get
            {
                return this.claimValueField;
            }
            set
            {
                this.claimValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C30_ClaimType ClaimType
        {
            get
            {
                return this.claimTypeField;
            }
            set
            {
                this.claimTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "date")]
        public System.DateTime NotificationDate
        {
            get
            {
                return this.notificationDateField;
            }
            set
            {
                this.notificationDateField = value;
            }
        }
    }
    #endregion CT_INPUT_Claim_Details_ELPL


    #region CT_A2A_AgreementDetails
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_A2A_AgreementDetails
    {

        private decimal grossAmountField;

        private decimal interimPaymentAmountField;

        private string commentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public decimal GrossAmount
        {
            get
            {
                return this.grossAmountField;
            }
            set
            {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public decimal InterimPaymentAmount
        {
            get
            {
                return this.interimPaymentAmountField;
            }
            set
            {
                this.interimPaymentAmountField = value;
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
    }
    #endregion CT_A2A_AgreementDetails


    #region CT_INPUT_Address
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Address
    {

        private string countryField;

        private string postCodeField;

        private string districtField;

        private string countyField;

        private string cityField;

        private string street1Field;

        private string street2Field;

        private string houseNameField;

        private string houseNumberField;

        private C01_AddressType addressTypeField;

        private bool addressTypeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string PostCode
        {
            get
            {
                return this.postCodeField;
            }
            set
            {
                this.postCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string District
        {
            get
            {
                return this.districtField;
            }
            set
            {
                this.districtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string County
        {
            get
            {
                return this.countyField;
            }
            set
            {
                this.countyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Street1
        {
            get
            {
                return this.street1Field;
            }
            set
            {
                this.street1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Street2
        {
            get
            {
                return this.street2Field;
            }
            set
            {
                this.street2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string HouseName
        {
            get
            {
                return this.houseNameField;
            }
            set
            {
                this.houseNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string HouseNumber
        {
            get
            {
                return this.houseNumberField;
            }
            set
            {
                this.houseNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C01_AddressType AddressType
        {
            get
            {
                return this.addressTypeField;
            }
            set
            {
                this.addressTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddressTypeSpecified
        {
            get
            {
                return this.addressTypeFieldSpecified;
            }
            set
            {
                this.addressTypeFieldSpecified = value;
            }
        }
    }
    #endregion CT_INPUT_Address


    #region CT_INPUT_Funding_ELPL
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Funding_ELPL
    {

        private C00_YNFlag fundingUndertakenField;

        private C00_YNFlag section58Field;

        private bool section58FieldSpecified;

        private System.DateTime conditionalFeeDateField;

        private bool conditionalFeeDateFieldSpecified;

        private C00_YNFlag section29Field;

        private bool section29FieldSpecified;

        private string iCNameField;

        private string iCAddressField;

        private string policyNumberField;

        private System.DateTime policyDateField;

        private bool policyDateFieldSpecified;

        private string levelOfCoverField;

        private C00_YNFlag premiumsStagedField;

        private bool premiumsStagedFieldSpecified;

        private string increasingPointField;

        private C00_YNFlag membershipOrganisationField;

        private bool membershipOrganisationFieldSpecified;

        private string organizationNameField;

        private System.DateTime agreementDateField;

        private bool agreementDateFieldSpecified;

        private C00_YNFlag otherField;

        private bool otherFieldSpecified;

        private string otherDetailsField;

        private string commentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag FundingUndertaken
        {
            get
            {
                return this.fundingUndertakenField;
            }
            set
            {
                this.fundingUndertakenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Section58
        {
            get
            {
                return this.section58Field;
            }
            set
            {
                this.section58Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Section58Specified
        {
            get
            {
                return this.section58FieldSpecified;
            }
            set
            {
                this.section58FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "date")]
        public System.DateTime ConditionalFeeDate
        {
            get
            {
                return this.conditionalFeeDateField;
            }
            set
            {
                this.conditionalFeeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConditionalFeeDateSpecified
        {
            get
            {
                return this.conditionalFeeDateFieldSpecified;
            }
            set
            {
                this.conditionalFeeDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Section29
        {
            get
            {
                return this.section29Field;
            }
            set
            {
                this.section29Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Section29Specified
        {
            get
            {
                return this.section29FieldSpecified;
            }
            set
            {
                this.section29FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ICName
        {
            get
            {
                return this.iCNameField;
            }
            set
            {
                this.iCNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ICAddress
        {
            get
            {
                return this.iCAddressField;
            }
            set
            {
                this.iCAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string PolicyNumber
        {
            get
            {
                return this.policyNumberField;
            }
            set
            {
                this.policyNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "date")]
        public System.DateTime PolicyDate
        {
            get
            {
                return this.policyDateField;
            }
            set
            {
                this.policyDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PolicyDateSpecified
        {
            get
            {
                return this.policyDateFieldSpecified;
            }
            set
            {
                this.policyDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string LevelOfCover
        {
            get
            {
                return this.levelOfCoverField;
            }
            set
            {
                this.levelOfCoverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag PremiumsStaged
        {
            get
            {
                return this.premiumsStagedField;
            }
            set
            {
                this.premiumsStagedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PremiumsStagedSpecified
        {
            get
            {
                return this.premiumsStagedFieldSpecified;
            }
            set
            {
                this.premiumsStagedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string IncreasingPoint
        {
            get
            {
                return this.increasingPointField;
            }
            set
            {
                this.increasingPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag MembershipOrganisation
        {
            get
            {
                return this.membershipOrganisationField;
            }
            set
            {
                this.membershipOrganisationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MembershipOrganisationSpecified
        {
            get
            {
                return this.membershipOrganisationFieldSpecified;
            }
            set
            {
                this.membershipOrganisationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string OrganizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                this.organizationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "date")]
        public System.DateTime AgreementDate
        {
            get
            {
                return this.agreementDateField;
            }
            set
            {
                this.agreementDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgreementDateSpecified
        {
            get
            {
                return this.agreementDateFieldSpecified;
            }
            set
            {
                this.agreementDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Other
        {
            get
            {
                return this.otherField;
            }
            set
            {
                this.otherField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OtherSpecified
        {
            get
            {
                return this.otherFieldSpecified;
            }
            set
            {
                this.otherFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string OtherDetails
        {
            get
            {
                return this.otherDetailsField;
            }
            set
            {
                this.otherDetailsField = value;
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
    }
    #endregion CT_INPUT_Funding_ELPL


    #region CT_INPUT_Liability_ELPL
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Liability_ELPL
    {

        private string defendantResponsibilityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string DefendantResponsibility
        {
            get
            {
                return this.defendantResponsibilityField;
            }
            set
            {
                this.defendantResponsibilityField = value;
            }
        }
    }
    #endregion CT_INPUT_Liability_ELPL


    #region CT_INPUT_AccidentDetails_ELPL
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_AccidentDetails_ELPL
    {

        private System.DateTime accidentDateField;

        private bool accidentDateFieldSpecified;

        private string accidentTimeField;

        private string accidentLocationField;

        private string accidentDescriptionField;

        private C26_YNNK incidentReportedField;

        private string reportedDateAndToWhomField;

        private C31_ClaimantLocation claimantLocationField;

        private bool claimantLocationFieldSpecified;

        private string claimantLocationOtherField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "date")]
        public System.DateTime AccidentDate
        {
            get
            {
                return this.accidentDateField;
            }
            set
            {
                this.accidentDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccidentDateSpecified
        {
            get
            {
                return this.accidentDateFieldSpecified;
            }
            set
            {
                this.accidentDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string AccidentTime
        {
            get
            {
                return this.accidentTimeField;
            }
            set
            {
                this.accidentTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string AccidentLocation
        {
            get
            {
                return this.accidentLocationField;
            }
            set
            {
                this.accidentLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string AccidentDescription
        {
            get
            {
                return this.accidentDescriptionField;
            }
            set
            {
                this.accidentDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C26_YNNK IncidentReported
        {
            get
            {
                return this.incidentReportedField;
            }
            set
            {
                this.incidentReportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ReportedDateAndToWhom
        {
            get
            {
                return this.reportedDateAndToWhomField;
            }
            set
            {
                this.reportedDateAndToWhomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C31_ClaimantLocation ClaimantLocation
        {
            get
            {
                return this.claimantLocationField;
            }
            set
            {
                this.claimantLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClaimantLocationSpecified
        {
            get
            {
                return this.claimantLocationFieldSpecified;
            }
            set
            {
                this.claimantLocationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ClaimantLocationOther
        {
            get
            {
                return this.claimantLocationOtherField;
            }
            set
            {
                this.claimantLocationOtherField = value;
            }
        }
    }
    #endregion CT_INPUT_AccidentDetails_ELPL


    #region CT_INPUT_Rehabilitation
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Rehabilitation
    {

        private C03_RehabilitationRecommended rehabilitationUndertakenField;

        private string rehabilitationTreatmentField;

        private C00_YNFlag rehabilitationNeedsField;

        private bool rehabilitationNeedsFieldSpecified;

        private string rehabilitationDetailsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C03_RehabilitationRecommended RehabilitationUndertaken
        {
            get
            {
                return this.rehabilitationUndertakenField;
            }
            set
            {
                this.rehabilitationUndertakenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string RehabilitationTreatment
        {
            get
            {
                return this.rehabilitationTreatmentField;
            }
            set
            {
                this.rehabilitationTreatmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag RehabilitationNeeds
        {
            get
            {
                return this.rehabilitationNeedsField;
            }
            set
            {
                this.rehabilitationNeedsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RehabilitationNeedsSpecified
        {
            get
            {
                return this.rehabilitationNeedsFieldSpecified;
            }
            set
            {
                this.rehabilitationNeedsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string RehabilitationDetails
        {
            get
            {
                return this.rehabilitationDetailsField;
            }
            set
            {
                this.rehabilitationDetailsField = value;
            }
        }
    }
    #endregion CT_INPUT_Rehabilitation


    #region CT_HospitalAddress
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_HospitalAddress
    {

        private string addressLine1Field;

        private string addressLine2Field;

        private string addressLine3Field;

        private string addressLine4Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string AddressLine1
        {
            get
            {
                return this.addressLine1Field;
            }
            set
            {
                this.addressLine1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string AddressLine2
        {
            get
            {
                return this.addressLine2Field;
            }
            set
            {
                this.addressLine2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string AddressLine3
        {
            get
            {
                return this.addressLine3Field;
            }
            set
            {
                this.addressLine3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string AddressLine4
        {
            get
            {
                return this.addressLine4Field;
            }
            set
            {
                this.addressLine4Field = value;
            }
        }
    }
    #endregion CT_HospitalAddress


    #region CT_INPUT_Injury_ELPL
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Injury_ELPL
    {

        private C00_YNFlag respiratoryField;

        private bool respiratoryFieldSpecified;

        private C00_YNFlag deafnessField;

        private bool deafnessFieldSpecified;

        private C00_YNFlag vibrationInjuryField;

        private bool vibrationInjuryFieldSpecified;

        private C00_YNFlag dermatitisField;

        private bool dermatitisFieldSpecified;

        private C00_YNFlag otherField;

        private bool otherFieldSpecified;

        private string injurySustainedDescriptionField;

        private C00_YNFlag timeOffRequiredField;

        private string timeOffPeriodField;

        private C00_YNFlag stillOffWorkField;

        private bool stillOffWorkFieldSpecified;

        private C00_YNFlag medicalAttentionSeekingField;

        private System.DateTime medicalAttentionFirstDateField;

        private bool medicalAttentionFirstDateFieldSpecified;

        private C00_YNFlag hospitalAttendanceField;

        private C00_YNFlag overnightDetentionField;

        private bool overnightDetentionFieldSpecified;

        private string daysNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Respiratory
        {
            get
            {
                return this.respiratoryField;
            }
            set
            {
                this.respiratoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RespiratorySpecified
        {
            get
            {
                return this.respiratoryFieldSpecified;
            }
            set
            {
                this.respiratoryFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Deafness
        {
            get
            {
                return this.deafnessField;
            }
            set
            {
                this.deafnessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeafnessSpecified
        {
            get
            {
                return this.deafnessFieldSpecified;
            }
            set
            {
                this.deafnessFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag VibrationInjury
        {
            get
            {
                return this.vibrationInjuryField;
            }
            set
            {
                this.vibrationInjuryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VibrationInjurySpecified
        {
            get
            {
                return this.vibrationInjuryFieldSpecified;
            }
            set
            {
                this.vibrationInjuryFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Dermatitis
        {
            get
            {
                return this.dermatitisField;
            }
            set
            {
                this.dermatitisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DermatitisSpecified
        {
            get
            {
                return this.dermatitisFieldSpecified;
            }
            set
            {
                this.dermatitisFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Other
        {
            get
            {
                return this.otherField;
            }
            set
            {
                this.otherField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OtherSpecified
        {
            get
            {
                return this.otherFieldSpecified;
            }
            set
            {
                this.otherFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string InjurySustainedDescription
        {
            get
            {
                return this.injurySustainedDescriptionField;
            }
            set
            {
                this.injurySustainedDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag TimeOffRequired
        {
            get
            {
                return this.timeOffRequiredField;
            }
            set
            {
                this.timeOffRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string TimeOffPeriod
        {
            get
            {
                return this.timeOffPeriodField;
            }
            set
            {
                this.timeOffPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag StillOffWork
        {
            get
            {
                return this.stillOffWorkField;
            }
            set
            {
                this.stillOffWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StillOffWorkSpecified
        {
            get
            {
                return this.stillOffWorkFieldSpecified;
            }
            set
            {
                this.stillOffWorkFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag MedicalAttentionSeeking
        {
            get
            {
                return this.medicalAttentionSeekingField;
            }
            set
            {
                this.medicalAttentionSeekingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "date")]
        public System.DateTime MedicalAttentionFirstDate
        {
            get
            {
                return this.medicalAttentionFirstDateField;
            }
            set
            {
                this.medicalAttentionFirstDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MedicalAttentionFirstDateSpecified
        {
            get
            {
                return this.medicalAttentionFirstDateFieldSpecified;
            }
            set
            {
                this.medicalAttentionFirstDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag HospitalAttendance
        {
            get
            {
                return this.hospitalAttendanceField;
            }
            set
            {
                this.hospitalAttendanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag OvernightDetention
        {
            get
            {
                return this.overnightDetentionField;
            }
            set
            {
                this.overnightDetentionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OvernightDetentionSpecified
        {
            get
            {
                return this.overnightDetentionFieldSpecified;
            }
            set
            {
                this.overnightDetentionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string DaysNumber
        {
            get
            {
                return this.daysNumberField;
            }
            set
            {
                this.daysNumberField = value;
            }
        }
    }
    #endregion CT_INPUT_Injury_ELPL


    #region CT_INPUT_Claimant_PersonalDetails_ELPL
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Claimant_PersonalDetails_ELPL
    {

        private CT_INPUT_Address addressField;

        private string nameField;

        private string middleNameField;

        private string surnameField;

        private System.DateTime dateOfBirthField;

        private C02_TitleType titleTypeField;

        private string otherTitleField;

        /// <remarks/>
        public CT_INPUT_Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "date")]
        public System.DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirthField;
            }
            set
            {
                this.dateOfBirthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C02_TitleType TitleType
        {
            get
            {
                return this.titleTypeField;
            }
            set
            {
                this.titleTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string OtherTitle
        {
            get
            {
                return this.otherTitleField;
            }
            set
            {
                this.otherTitleField = value;
            }
        }
    }
    #endregion CT_INPUT_Claimant_PersonalDetails_ELPL


    #region CT_INPUT_ClaimantDetails_ELPL
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_ClaimantDetails_ELPL
    {

        private CT_INPUT_Claimant_PersonalDetails_ELPL personalDetailsField;

        private string occupationField;

        private C00_YNFlag childClaimField;

        private string nationalInsuranceNumberField;

        private string nINCommentField;

        private string employmentPeriodField;

        private string exposurePeriodField;

        /// <remarks/>
        public CT_INPUT_Claimant_PersonalDetails_ELPL PersonalDetails
        {
            get
            {
                return this.personalDetailsField;
            }
            set
            {
                this.personalDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Occupation
        {
            get
            {
                return this.occupationField;
            }
            set
            {
                this.occupationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag ChildClaim
        {
            get
            {
                return this.childClaimField;
            }
            set
            {
                this.childClaimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string NationalInsuranceNumber
        {
            get
            {
                return this.nationalInsuranceNumberField;
            }
            set
            {
                this.nationalInsuranceNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string NINComment
        {
            get
            {
                return this.nINCommentField;
            }
            set
            {
                this.nINCommentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string EmploymentPeriod
        {
            get
            {
                return this.employmentPeriodField;
            }
            set
            {
                this.employmentPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ExposurePeriod
        {
            get
            {
                return this.exposurePeriodField;
            }
            set
            {
                this.exposurePeriodField = value;
            }
        }
    }
    #endregion CT_INPUT_ClaimantDetails_ELPL


    #region CT_INPUT_Defendant_CompanyDetails
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Defendant_CompanyDetails
    {

        private CT_INPUT_Address addressField;

        private string companyNameField;

        private string emailAddressField;

        private string contactNameField;

        private string contactMiddleNameField;

        private string contactSurnameField;

        private string telephoneNumberField;

        private string referenceNumberField;

        private string policyNumberField;

        private string providerAddressField;

        /// <remarks/>
        public CT_INPUT_Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
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
        public string PolicyNumber
        {
            get
            {
                return this.policyNumberField;
            }
            set
            {
                this.policyNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ProviderAddress
        {
            get
            {
                return this.providerAddressField;
            }
            set
            {
                this.providerAddressField = value;
            }
        }
    }
    #endregion CT_INPUT_Defendant_CompanyDetails


    #region CT_INPUT_Defendant_PersonalDetails_ELPL
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Defendant_PersonalDetails_ELPL
    {

        private CT_INPUT_Address addressField;

        private string nameField;

        private string middleNameField;

        private string surnameField;

        private C02_TitleType titleTypeField;

        private bool titleTypeFieldSpecified;

        private string otherTitleField;

        /// <remarks/>
        public CT_INPUT_Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C02_TitleType TitleType
        {
            get
            {
                return this.titleTypeField;
            }
            set
            {
                this.titleTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TitleTypeSpecified
        {
            get
            {
                return this.titleTypeFieldSpecified;
            }
            set
            {
                this.titleTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string OtherTitle
        {
            get
            {
                return this.otherTitleField;
            }
            set
            {
                this.otherTitleField = value;
            }
        }
    }
    #endregion CT_INPUT_Defendant_PersonalDetails_ELPL


    #region CT_INPUT_InsurerInformation_ELPL
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_InsurerInformation_ELPL
    {

        private string insurerNameField;

        private C00_YNFlag selectedField;

        private bool selectedFieldSpecified;

        private string insurerOrganizationIDField;

        private string insurerOrganizationPathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string InsurerName
        {
            get
            {
                return this.insurerNameField;
            }
            set
            {
                this.insurerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Selected
        {
            get
            {
                return this.selectedField;
            }
            set
            {
                this.selectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SelectedSpecified
        {
            get
            {
                return this.selectedFieldSpecified;
            }
            set
            {
                this.selectedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string InsurerOrganizationID
        {
            get
            {
                return this.insurerOrganizationIDField;
            }
            set
            {
                this.insurerOrganizationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string InsurerOrganizationPath
        {
            get
            {
                return this.insurerOrganizationPathField;
            }
            set
            {
                this.insurerOrganizationPathField = value;
            }
        }
    }
    #endregion CT_INPUT_InsurerInformation_ELPL

    
    #region CT_INPUT_DefendantDetails_ELPL
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_DefendantDetails_ELPL
    {

        private CT_INPUT_Defendant_PersonalDetails_ELPL personalDetailsField;

        private CT_INPUT_InsurerInformation_ELPL insurerInformationField;

        private CT_INPUT_InsurerInformation_ELPL[] insurerFoundField;

        private CT_INPUT_Defendant_CompanyDetails companyDetailsField;

        private C09_SubjectStatus_ELPL defendantStatusField;

        private string policyNumberReferenceField;

        /// <remarks/>
        public CT_INPUT_Defendant_PersonalDetails_ELPL PersonalDetails
        {
            get
            {
                return this.personalDetailsField;
            }
            set
            {
                this.personalDetailsField = value;
            }
        }

        /// <remarks/>
        public CT_INPUT_InsurerInformation_ELPL InsurerInformation
        {
            get
            {
                return this.insurerInformationField;
            }
            set
            {
                this.insurerInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InsurerFound")]
        public CT_INPUT_InsurerInformation_ELPL[] InsurerFound
        {
            get
            {
                return this.insurerFoundField;
            }
            set
            {
                this.insurerFoundField = value;
            }
        }

        /// <remarks/>
        public CT_INPUT_Defendant_CompanyDetails CompanyDetails
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C09_SubjectStatus_ELPL DefendantStatus
        {
            get
            {
                return this.defendantStatusField;
            }
            set
            {
                this.defendantStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string PolicyNumberReference
        {
            get
            {
                return this.policyNumberReferenceField;
            }
            set
            {
                this.policyNumberReferenceField = value;
            }
        }
    }
    #endregion CT_INPUT_DefendantDetails_ELPL


    #region CT_INPUT_ClaimantRepresentative_CompanyDetails_ELPL
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_ClaimantRepresentative_CompanyDetails_ELPL
    {

        private CT_INPUT_Address addressField;

        private string companyNameField;

        private string emailAddressField;

        private string contactNameField;

        private string contactMiddleNameField;

        private string contactSurnameField;

        private string telephoneNumberField;

        private string referenceNumberField;

        /// <remarks/>
        public CT_INPUT_Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
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
    }
    #endregion CT_INPUT_ClaimantRepresentative_CompanyDetails_ELPL


    #region CT_DefendantAdmits
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_DefendantAdmits
    {

        private C00_YNFlag accidentOccurredField;

        private bool accidentOccurredFieldSpecified;

        private C00_YNFlag causedByDefendantField;

        private bool causedByDefendantFieldSpecified;

        private C00_YNFlag causedSomeLossToTheClaimantField;

        private bool causedSomeLossToTheClaimantFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag AccidentOccurred
        {
            get
            {
                return this.accidentOccurredField;
            }
            set
            {
                this.accidentOccurredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccidentOccurredSpecified
        {
            get
            {
                return this.accidentOccurredFieldSpecified;
            }
            set
            {
                this.accidentOccurredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag CausedByDefendant
        {
            get
            {
                return this.causedByDefendantField;
            }
            set
            {
                this.causedByDefendantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CausedByDefendantSpecified
        {
            get
            {
                return this.causedByDefendantFieldSpecified;
            }
            set
            {
                this.causedByDefendantFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag CausedSomeLossToTheClaimant
        {
            get
            {
                return this.causedSomeLossToTheClaimantField;
            }
            set
            {
                this.causedSomeLossToTheClaimantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CausedSomeLossToTheClaimantSpecified
        {
            get
            {
                return this.causedSomeLossToTheClaimantFieldSpecified;
            }
            set
            {
                this.causedSomeLossToTheClaimantFieldSpecified = value;
            }
        }
    }
    #endregion CT_DefendantAdmits


    #region CT_INPUT_Hospital_R3
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Hospital_R3
    {

        private CT_HospitalAddress hospitalAddressField;

        private C07_HospitalType_R3 hospitalTypeField;

        private string hospitalNameField;

        private string postCodeField;

        /// <remarks/>
        public CT_HospitalAddress HospitalAddress
        {
            get
            {
                return this.hospitalAddressField;
            }
            set
            {
                this.hospitalAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C07_HospitalType_R3 HospitalType
        {
            get
            {
                return this.hospitalTypeField;
            }
            set
            {
                this.hospitalTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string HospitalName
        {
            get
            {
                return this.hospitalNameField;
            }
            set
            {
                this.hospitalNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string PostCode
        {
            get
            {
                return this.postCodeField;
            }
            set
            {
                this.postCodeField = value;
            }
        }
    }
    #endregion CT_INPUT_Hospital_R3


    #region DocumentInputClaimAndClaimantDetails
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentInputClaimAndClaimantDetails
    {

        private DocumentInputClaimAndClaimantDetailsClaimantRepresentative claimantRepresentativeField;

        private CT_INPUT_DefendantDetails_ELPL defendantDetailsField;

        private CT_INPUT_ClaimantDetails_ELPL claimantDetailsField;

        /// <remarks/>
        public DocumentInputClaimAndClaimantDetailsClaimantRepresentative ClaimantRepresentative
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
        public CT_INPUT_DefendantDetails_ELPL DefendantDetails
        {
            get
            {
                return this.defendantDetailsField;
            }
            set
            {
                this.defendantDetailsField = value;
            }
        }

        /// <remarks/>
        public CT_INPUT_ClaimantDetails_ELPL ClaimantDetails
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
    #endregion DocumentInputClaimAndClaimantDetails


    #region DocumentInputClaimAndClaimantDetailsClaimantRepresentative
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentInputClaimAndClaimantDetailsClaimantRepresentative
    {

        private CT_INPUT_ClaimantRepresentative_CompanyDetails_ELPL companyDetailsField;

        /// <remarks/>
        public CT_INPUT_ClaimantRepresentative_CompanyDetails_ELPL CompanyDetails
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
    #endregion DocumentInputClaimAndClaimantDetailsClaimantRepresentative


    #region DocumentInputMedicalDetails
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentInputMedicalDetails
    {

        private CT_INPUT_Injury_ELPL injuryField;

        private CT_INPUT_Hospital_R3[] hospitalField;

        private CT_INPUT_Rehabilitation rehabilitationField;

        /// <remarks/>
        public CT_INPUT_Injury_ELPL Injury
        {
            get
            {
                return this.injuryField;
            }
            set
            {
                this.injuryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Hospital")]
        public CT_INPUT_Hospital_R3[] Hospital
        {
            get
            {
                return this.hospitalField;
            }
            set
            {
                this.hospitalField = value;
            }
        }

        /// <remarks/>
        public CT_INPUT_Rehabilitation Rehabilitation
        {
            get
            {
                return this.rehabilitationField;
            }
            set
            {
                this.rehabilitationField = value;
            }
        }
    }
    #endregion DocumentInputMedicalDetails


    #region DocumentInputAccidentData
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentInputAccidentData
    {

        private CT_INPUT_AccidentDetails_ELPL accidentDetailsField;

        /// <remarks/>
        public CT_INPUT_AccidentDetails_ELPL AccidentDetails
        {
            get
            {
                return this.accidentDetailsField;
            }
            set
            {
                this.accidentDetailsField = value;
            }
        }
    }
    #endregion DocumentInputAccidentData


    #region DocumentInputLiabilityFunding
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentInputLiabilityFunding
    {

        private CT_INPUT_Liability_ELPL liabilityField;

        private CT_INPUT_Funding_ELPL fundingField;

        /// <remarks/>
        public CT_INPUT_Liability_ELPL Liability
        {
            get
            {
                return this.liabilityField;
            }
            set
            {
                this.liabilityField = value;
            }
        }

        /// <remarks/>
        public CT_INPUT_Funding_ELPL Funding
        {
            get
            {
                return this.fundingField;
            }
            set
            {
                this.fundingField = value;
            }
        }
    }
    #endregion DocumentInputLiabilityFunding

}
