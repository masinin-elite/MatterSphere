﻿using System;
using System.Collections.Generic;
using System.Text;
using RTAServicesLibraryV5;

namespace RTAServicesLibraryV5
{
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
    public partial class CT_MedCoCase
    {

        private C00_YNFlag softTissueField;

        private bool softTissueFieldSpecified;

        private string medCoCaseIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag SoftTissue
        {
            get
            {
                return this.softTissueField;
            }
            set
            {
                this.softTissueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SoftTissueSpecified
        {
            get
            {
                return this.softTissueFieldSpecified;
            }
            set
            {
                this.softTissueFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string MedCoCaseID
        {
            get
            {
                return this.medCoCaseIDField;
            }
            set
            {
                this.medCoCaseIDField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_A2A_CRUReference
    {

        private string cRUReferenceNumberField;

        private string cRUCommentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string CRUReferenceNumber
        {
            get
            {
                return this.cRUReferenceNumberField;
            }
            set
            {
                this.cRUReferenceNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string CRUComment
        {
            get
            {
                return this.cRUCommentField;
            }
            set
            {
                this.cRUCommentField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_Vehicle
    {

        private string vRNField;

        private string makeField;

        private string modelField;

        private string engineSizeField;

        private string colorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string VRN
        {
            get
            {
                return this.vRNField;
            }
            set
            {
                this.vRNField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Make
        {
            get
            {
                return this.makeField;
            }
            set
            {
                this.makeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string EngineSize
        {
            get
            {
                return this.engineSizeField;
            }
            set
            {
                this.engineSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_PoliceDetails
    {

        private string stationNameField;

        private string stationAddressField;

        private string reportingOfficerNameField;

        private string referenceNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string StationName
        {
            get
            {
                return this.stationNameField;
            }
            set
            {
                this.stationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string StationAddress
        {
            get
            {
                return this.stationAddressField;
            }
            set
            {
                this.stationAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ReportingOfficerName
        {
            get
            {
                return this.reportingOfficerNameField;
            }
            set
            {
                this.reportingOfficerNameField = value;
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


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_AccidentCircumstances
    {

        private C00_YNFlag vhclHitSideRoadField;

        private bool vhclHitSideRoadFieldSpecified;

        private C00_YNFlag vhclHitInRearField;

        private bool vhclHitInRearFieldSpecified;

        private C00_YNFlag vhclHitWhilstParkedField;

        private bool vhclHitWhilstParkedFieldSpecified;

        private C00_YNFlag accidCarParkField;

        private bool accidCarParkFieldSpecified;

        private C00_YNFlag accidRoundaboutField;

        private bool accidRoundaboutFieldSpecified;

        private C00_YNFlag accidChangingLanesField;

        private bool accidChangingLanesFieldSpecified;

        private C00_YNFlag concertinaCollisionField;

        private bool concertinaCollisionFieldSpecified;

        private C00_YNFlag otherField;

        private bool otherFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag VhclHitSideRoad
        {
            get
            {
                return this.vhclHitSideRoadField;
            }
            set
            {
                this.vhclHitSideRoadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VhclHitSideRoadSpecified
        {
            get
            {
                return this.vhclHitSideRoadFieldSpecified;
            }
            set
            {
                this.vhclHitSideRoadFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag VhclHitInRear
        {
            get
            {
                return this.vhclHitInRearField;
            }
            set
            {
                this.vhclHitInRearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VhclHitInRearSpecified
        {
            get
            {
                return this.vhclHitInRearFieldSpecified;
            }
            set
            {
                this.vhclHitInRearFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag VhclHitWhilstParked
        {
            get
            {
                return this.vhclHitWhilstParkedField;
            }
            set
            {
                this.vhclHitWhilstParkedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VhclHitWhilstParkedSpecified
        {
            get
            {
                return this.vhclHitWhilstParkedFieldSpecified;
            }
            set
            {
                this.vhclHitWhilstParkedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag AccidCarPark
        {
            get
            {
                return this.accidCarParkField;
            }
            set
            {
                this.accidCarParkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccidCarParkSpecified
        {
            get
            {
                return this.accidCarParkFieldSpecified;
            }
            set
            {
                this.accidCarParkFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag AccidRoundabout
        {
            get
            {
                return this.accidRoundaboutField;
            }
            set
            {
                this.accidRoundaboutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccidRoundaboutSpecified
        {
            get
            {
                return this.accidRoundaboutFieldSpecified;
            }
            set
            {
                this.accidRoundaboutFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag AccidChangingLanes
        {
            get
            {
                return this.accidChangingLanesField;
            }
            set
            {
                this.accidChangingLanesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccidChangingLanesSpecified
        {
            get
            {
                return this.accidChangingLanesFieldSpecified;
            }
            set
            {
                this.accidChangingLanesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag ConcertinaCollision
        {
            get
            {
                return this.concertinaCollisionField;
            }
            set
            {
                this.concertinaCollisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConcertinaCollisionSpecified
        {
            get
            {
                return this.concertinaCollisionFieldSpecified;
            }
            set
            {
                this.concertinaCollisionFieldSpecified = value;
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
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_RoadConditions
    {

        private C00_YNFlag dryField;

        private bool dryFieldSpecified;

        private C00_YNFlag wetField;

        private bool wetFieldSpecified;

        private C00_YNFlag snowField;

        private bool snowFieldSpecified;

        private C00_YNFlag iceField;

        private bool iceFieldSpecified;

        private C00_YNFlag mudField;

        private bool mudFieldSpecified;

        private C00_YNFlag oilField;

        private bool oilFieldSpecified;

        private C00_YNFlag otherField;

        private bool otherFieldSpecified;

        private string otherDetailsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Dry
        {
            get
            {
                return this.dryField;
            }
            set
            {
                this.dryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DrySpecified
        {
            get
            {
                return this.dryFieldSpecified;
            }
            set
            {
                this.dryFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Wet
        {
            get
            {
                return this.wetField;
            }
            set
            {
                this.wetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WetSpecified
        {
            get
            {
                return this.wetFieldSpecified;
            }
            set
            {
                this.wetFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Snow
        {
            get
            {
                return this.snowField;
            }
            set
            {
                this.snowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SnowSpecified
        {
            get
            {
                return this.snowFieldSpecified;
            }
            set
            {
                this.snowFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Ice
        {
            get
            {
                return this.iceField;
            }
            set
            {
                this.iceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IceSpecified
        {
            get
            {
                return this.iceFieldSpecified;
            }
            set
            {
                this.iceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Mud
        {
            get
            {
                return this.mudField;
            }
            set
            {
                this.mudField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MudSpecified
        {
            get
            {
                return this.mudFieldSpecified;
            }
            set
            {
                this.mudFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Oil
        {
            get
            {
                return this.oilField;
            }
            set
            {
                this.oilField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OilSpecified
        {
            get
            {
                return this.oilFieldSpecified;
            }
            set
            {
                this.oilFieldSpecified = value;
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
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_WeatherConditions
    {

        private C00_YNFlag sunField;

        private bool sunFieldSpecified;

        private C00_YNFlag rainField;

        private bool rainFieldSpecified;

        private C00_YNFlag snowField;

        private bool snowFieldSpecified;

        private C00_YNFlag iceField;

        private bool iceFieldSpecified;

        private C00_YNFlag fogField;

        private bool fogFieldSpecified;

        private C00_YNFlag otherField;

        private bool otherFieldSpecified;

        private string otherDetailsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Sun
        {
            get
            {
                return this.sunField;
            }
            set
            {
                this.sunField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SunSpecified
        {
            get
            {
                return this.sunFieldSpecified;
            }
            set
            {
                this.sunFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Rain
        {
            get
            {
                return this.rainField;
            }
            set
            {
                this.rainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RainSpecified
        {
            get
            {
                return this.rainFieldSpecified;
            }
            set
            {
                this.rainFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Snow
        {
            get
            {
                return this.snowField;
            }
            set
            {
                this.snowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SnowSpecified
        {
            get
            {
                return this.snowFieldSpecified;
            }
            set
            {
                this.snowFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Ice
        {
            get
            {
                return this.iceField;
            }
            set
            {
                this.iceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IceSpecified
        {
            get
            {
                return this.iceFieldSpecified;
            }
            set
            {
                this.iceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Fog
        {
            get
            {
                return this.fogField;
            }
            set
            {
                this.fogField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FogSpecified
        {
            get
            {
                return this.fogFieldSpecified;
            }
            set
            {
                this.fogFieldSpecified = value;
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
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_AlternativeCompany
    {

        private string companyNameField;

        private string addressField;

        private string telephoneNumberField;

        private string referenceNumberField;

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
        public string Address
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


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_AccidentDetails
    {

        private CT_INPUT_Driver_PersonalDetails driverField;

        private CT_INPUT_VehicleOwner_PersonalDetails ownerField;

        private CT_Vehicle vehicleField;

        private CT_INPUT_Insurance_CompanyDetails insuranceCompanyInformatiionField;

        private CT_WeatherConditions weatherConditionsField;

        private CT_RoadConditions roadConditionsField;

        private CT_AccidentCircumstances accidentCircumstancesField;

        private CT_PoliceDetails policeDetailsField;

        private C06_ClaimantType claimantTypeField;

        private string otherTypeField;

        private string occupantsNumberField;

        private C11_SeatbeltWearing seatbeltField;

        private bool seatbeltFieldSpecified;

        private C00_YNFlag driverIsDefendantField;

        private bool driverIsDefendantFieldSpecified;

        private System.DateTime accidentDateField;

        private string accidentTimeField;

        private string accidentLocationField;

        private string accidentDescriptionField;

        private C26_YNNK policeReportedField;

        private bool policeReportedFieldSpecified;

        /// <remarks/>
        public CT_INPUT_Driver_PersonalDetails Driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }

        /// <remarks/>
        public CT_INPUT_VehicleOwner_PersonalDetails Owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public CT_Vehicle Vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
            }
        }

        /// <remarks/>
        public CT_INPUT_Insurance_CompanyDetails InsuranceCompanyInformatiion
        {
            get
            {
                return this.insuranceCompanyInformatiionField;
            }
            set
            {
                this.insuranceCompanyInformatiionField = value;
            }
        }

        /// <remarks/>
        public CT_WeatherConditions WeatherConditions
        {
            get
            {
                return this.weatherConditionsField;
            }
            set
            {
                this.weatherConditionsField = value;
            }
        }

        /// <remarks/>
        public CT_RoadConditions RoadConditions
        {
            get
            {
                return this.roadConditionsField;
            }
            set
            {
                this.roadConditionsField = value;
            }
        }

        /// <remarks/>
        public CT_AccidentCircumstances AccidentCircumstances
        {
            get
            {
                return this.accidentCircumstancesField;
            }
            set
            {
                this.accidentCircumstancesField = value;
            }
        }

        /// <remarks/>
        public CT_PoliceDetails PoliceDetails
        {
            get
            {
                return this.policeDetailsField;
            }
            set
            {
                this.policeDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C06_ClaimantType ClaimantType
        {
            get
            {
                return this.claimantTypeField;
            }
            set
            {
                this.claimantTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string OtherType
        {
            get
            {
                return this.otherTypeField;
            }
            set
            {
                this.otherTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string OccupantsNumber
        {
            get
            {
                return this.occupantsNumberField;
            }
            set
            {
                this.occupantsNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C11_SeatbeltWearing Seatbelt
        {
            get
            {
                return this.seatbeltField;
            }
            set
            {
                this.seatbeltField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SeatbeltSpecified
        {
            get
            {
                return this.seatbeltFieldSpecified;
            }
            set
            {
                this.seatbeltFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag DriverIsDefendant
        {
            get
            {
                return this.driverIsDefendantField;
            }
            set
            {
                this.driverIsDefendantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DriverIsDefendantSpecified
        {
            get
            {
                return this.driverIsDefendantFieldSpecified;
            }
            set
            {
                this.driverIsDefendantFieldSpecified = value;
            }
        }

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
        public C26_YNNK PoliceReported
        {
            get
            {
                return this.policeReportedField;
            }
            set
            {
                this.policeReportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PoliceReportedSpecified
        {
            get
            {
                return this.policeReportedFieldSpecified;
            }
            set
            {
                this.policeReportedFieldSpecified = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Claim_Details
    {

        private C16_SignatoryType signatoryField;

        private C00_YNFlag retainedCopyField;

        private C29_ClaimValue claimValueField;

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
    }


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


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_AlternativeVehicleProvision
    {

        private CT_INPUT_Provider providerField;

        private C00_YNFlag claimantEntitledField;

        private C00_YNFlag aVRequiredByCLField;

        private bool aVRequiredByCLFieldSpecified;

        private C00_YNFlag aVProvidedField;

        private bool aVProvidedFieldSpecified;

        private C00_YNFlag hireNeedField;

        private bool hireNeedFieldSpecified;

        private C00_YNFlag aVRequiredByCRField;

        private bool aVRequiredByCRFieldSpecified;

        private string vehicleTypeField;

        private string contactNameField;

        private string telephoneNumberField;

        /// <remarks/>
        public CT_INPUT_Provider Provider
        {
            get
            {
                return this.providerField;
            }
            set
            {
                this.providerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag ClaimantEntitled
        {
            get
            {
                return this.claimantEntitledField;
            }
            set
            {
                this.claimantEntitledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag AVRequiredByCL
        {
            get
            {
                return this.aVRequiredByCLField;
            }
            set
            {
                this.aVRequiredByCLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AVRequiredByCLSpecified
        {
            get
            {
                return this.aVRequiredByCLFieldSpecified;
            }
            set
            {
                this.aVRequiredByCLFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag AVProvided
        {
            get
            {
                return this.aVProvidedField;
            }
            set
            {
                this.aVProvidedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AVProvidedSpecified
        {
            get
            {
                return this.aVProvidedFieldSpecified;
            }
            set
            {
                this.aVProvidedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag HireNeed
        {
            get
            {
                return this.hireNeedField;
            }
            set
            {
                this.hireNeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HireNeedSpecified
        {
            get
            {
                return this.hireNeedFieldSpecified;
            }
            set
            {
                this.hireNeedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag AVRequiredByCR
        {
            get
            {
                return this.aVRequiredByCRField;
            }
            set
            {
                this.aVRequiredByCRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AVRequiredByCRSpecified
        {
            get
            {
                return this.aVRequiredByCRFieldSpecified;
            }
            set
            {
                this.aVRequiredByCRFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string VehicleType
        {
            get
            {
                return this.vehicleTypeField;
            }
            set
            {
                this.vehicleTypeField = value;
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
    public partial class CT_INPUT_BusCoach
    {

        private C00_YNFlag bussOrCoachField;

        private string driverNameField;

        private string driverIDField;

        private string driverDescriptionField;

        private string vehicleDescriptionField;

        private string numberOfPassengersField;

        private C00_YNFlag evidenceField;

        private bool evidenceFieldSpecified;

        private string commentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag BussOrCoach
        {
            get
            {
                return this.bussOrCoachField;
            }
            set
            {
                this.bussOrCoachField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string DriverName
        {
            get
            {
                return this.driverNameField;
            }
            set
            {
                this.driverNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string DriverID
        {
            get
            {
                return this.driverIDField;
            }
            set
            {
                this.driverIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string DriverDescription
        {
            get
            {
                return this.driverDescriptionField;
            }
            set
            {
                this.driverDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string VehicleDescription
        {
            get
            {
                return this.vehicleDescriptionField;
            }
            set
            {
                this.vehicleDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string NumberOfPassengers
        {
            get
            {
                return this.numberOfPassengersField;
            }
            set
            {
                this.numberOfPassengersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Evidence
        {
            get
            {
                return this.evidenceField;
            }
            set
            {
                this.evidenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EvidenceSpecified
        {
            get
            {
                return this.evidenceFieldSpecified;
            }
            set
            {
                this.evidenceFieldSpecified = value;
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


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Claimant_PersonalDetails
    {

        private CT_INPUT_Address addressField;

        private string nameField;

        private string middleNameField;

        private string surnameField;

        private C08_Sex sexField;

        private bool sexFieldSpecified;

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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C08_Sex Sex
        {
            get
            {
                return this.sexField;
            }
            set
            {
                this.sexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SexSpecified
        {
            get
            {
                return this.sexFieldSpecified;
            }
            set
            {
                this.sexFieldSpecified = value;
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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Funding
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

        private C00_YNFlag ohterField;

        private bool ohterFieldSpecified;

        private string otherDetailsField;

        private C00_YNFlag consideredFreeLegalExpInsField;

        private bool consideredFreeLegalExpInsFieldSpecified;

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
        public C00_YNFlag Ohter
        {
            get
            {
                return this.ohterField;
            }
            set
            {
                this.ohterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OhterSpecified
        {
            get
            {
                return this.ohterFieldSpecified;
            }
            set
            {
                this.ohterFieldSpecified = value;
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
        public C00_YNFlag ConsideredFreeLegalExpIns
        {
            get
            {
                return this.consideredFreeLegalExpInsField;
            }
            set
            {
                this.consideredFreeLegalExpInsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConsideredFreeLegalExpInsSpecified
        {
            get
            {
                return this.consideredFreeLegalExpInsFieldSpecified;
            }
            set
            {
                this.consideredFreeLegalExpInsFieldSpecified = value;
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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_ClaimantDetails
    {

        private CT_INPUT_Claimant_PersonalDetails personalDetailsField;

        private CT_Vehicle vehicleField;

        private string occupationField;

        private C00_YNFlag childClaimField;

        private string nationalInsuranceNumberField;

        private string nINCommentField;

        private string askCUEPIReferenceField;

        /// <remarks/>
        public CT_INPUT_Claimant_PersonalDetails PersonalDetails
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
        public CT_Vehicle Vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
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
        public string AskCUEPIReference
        {
            get
            {
                return this.askCUEPIReferenceField;
            }
            set
            {
                this.askCUEPIReferenceField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Driver_PersonalDetails
    {

        private CT_INPUT_Address addressField;

        private string nameField;

        private string middleNameField;

        private string surnameField;

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
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Insurance_CompanyDetails
    {

        private CT_INPUT_Address addressField;

        private string companyNameField;

        private string policyNumberField;

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
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Liability
    {

        private string defendantResponsabilityField;

        private C00_YNFlag oP1ResponsabilityField;

        private bool oP1ResponsabilityFieldSpecified;

        private C00_YNFlag oP2ResponsabilityField;

        private bool oP2ResponsabilityFieldSpecified;

        private C00_YNFlag oP3ResponsabilityField;

        private bool oP3ResponsabilityFieldSpecified;

        private C00_YNFlag oP4ResponsabilityField;

        private bool oP4ResponsabilityFieldSpecified;

        private C00_YNFlag oP5ResponsabilityField;

        private bool oP5ResponsabilityFieldSpecified;

        private C00_YNFlag oP6ResponsabilityField;

        private bool oP6ResponsabilityFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string DefendantResponsability
        {
            get
            {
                return this.defendantResponsabilityField;
            }
            set
            {
                this.defendantResponsabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag OP1Responsability
        {
            get
            {
                return this.oP1ResponsabilityField;
            }
            set
            {
                this.oP1ResponsabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OP1ResponsabilitySpecified
        {
            get
            {
                return this.oP1ResponsabilityFieldSpecified;
            }
            set
            {
                this.oP1ResponsabilityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag OP2Responsability
        {
            get
            {
                return this.oP2ResponsabilityField;
            }
            set
            {
                this.oP2ResponsabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OP2ResponsabilitySpecified
        {
            get
            {
                return this.oP2ResponsabilityFieldSpecified;
            }
            set
            {
                this.oP2ResponsabilityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag OP3Responsability
        {
            get
            {
                return this.oP3ResponsabilityField;
            }
            set
            {
                this.oP3ResponsabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OP3ResponsabilitySpecified
        {
            get
            {
                return this.oP3ResponsabilityFieldSpecified;
            }
            set
            {
                this.oP3ResponsabilityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag OP4Responsability
        {
            get
            {
                return this.oP4ResponsabilityField;
            }
            set
            {
                this.oP4ResponsabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OP4ResponsabilitySpecified
        {
            get
            {
                return this.oP4ResponsabilityFieldSpecified;
            }
            set
            {
                this.oP4ResponsabilityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag OP5Responsability
        {
            get
            {
                return this.oP5ResponsabilityField;
            }
            set
            {
                this.oP5ResponsabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OP5ResponsabilitySpecified
        {
            get
            {
                return this.oP5ResponsabilityFieldSpecified;
            }
            set
            {
                this.oP5ResponsabilityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag OP6Responsability
        {
            get
            {
                return this.oP6ResponsabilityField;
            }
            set
            {
                this.oP6ResponsabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OP6ResponsabilitySpecified
        {
            get
            {
                return this.oP6ResponsabilityFieldSpecified;
            }
            set
            {
                this.oP6ResponsabilityFieldSpecified = value;
            }
        }
    }



    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_ClaimantRepresentative_CompanyDetails
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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Defendant_PersonalDetails
    {

        private CT_INPUT_Address addressField;

        private string nameField;

        private string middleNameField;

        private string surnameField;

        private C08_Sex sexField;

        private bool sexFieldSpecified;

        private System.DateTime dateOfBirthField;

        private bool dateOfBirthFieldSpecified;

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
        public C08_Sex Sex
        {
            get
            {
                return this.sexField;
            }
            set
            {
                this.sexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SexSpecified
        {
            get
            {
                return this.sexFieldSpecified;
            }
            set
            {
                this.sexFieldSpecified = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateOfBirthSpecified
        {
            get
            {
                return this.dateOfBirthFieldSpecified;
            }
            set
            {
                this.dateOfBirthFieldSpecified = value;
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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_OtherDetails_PersonalDetails
    {

        private CT_INPUT_Address addressField;

        private C02_TitleType titleTypeField;

        private bool titleTypeFieldSpecified;

        private string nameField;

        private string middleNameField;

        private string surnameField;

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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Injury
    {

        private C00_YNFlag softTissueField;

        private bool softTissueFieldSpecified;

        private C00_YNFlag boneInjuryField;

        private bool boneInjuryFieldSpecified;

        private C00_YNFlag whiplashField;

        private bool whiplashFieldSpecified;

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
        public C00_YNFlag SoftTissue
        {
            get
            {
                return this.softTissueField;
            }
            set
            {
                this.softTissueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SoftTissueSpecified
        {
            get
            {
                return this.softTissueFieldSpecified;
            }
            set
            {
                this.softTissueFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag BoneInjury
        {
            get
            {
                return this.boneInjuryField;
            }
            set
            {
                this.boneInjuryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BoneInjurySpecified
        {
            get
            {
                return this.boneInjuryFieldSpecified;
            }
            set
            {
                this.boneInjuryFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag Whiplash
        {
            get
            {
                return this.whiplashField;
            }
            set
            {
                this.whiplashField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WhiplashSpecified
        {
            get
            {
                return this.whiplashFieldSpecified;
            }
            set
            {
                this.whiplashFieldSpecified = value;
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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_DefendantDetails
    {

        private CT_INPUT_Defendant_PersonalDetails personalDetailsField;

        private CT_INPUT_Vehicle vehicleField;

        private CT_INPUT_InsurerInformation insurerInformationField;

        private CT_INPUT_InsurerInformation[] insurerFoundField;

        private CT_INPUT_Defendant_CompanyDetails companyDetailsField;

        private C09_SubjectStatus defendantStatusField;

        private string defDriverNameField;

        private string policyNumberReferenceField;

        private string commentsField;

        private string defedantAgeField;

        private string defendandDescriptionField;

        private string defendantDetailsObtainedField;

        /// <remarks/>
        public CT_INPUT_Defendant_PersonalDetails PersonalDetails
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
        public CT_INPUT_Vehicle Vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
            }
        }

        /// <remarks/>
        public CT_INPUT_InsurerInformation InsurerInformation
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
        public CT_INPUT_InsurerInformation[] InsurerFound
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
        public C09_SubjectStatus DefendantStatus
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
        public string DefDriverName
        {
            get
            {
                return this.defDriverNameField;
            }
            set
            {
                this.defDriverNameField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string DefedantAge
        {
            get
            {
                return this.defedantAgeField;
            }
            set
            {
                this.defedantAgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string DefendandDescription
        {
            get
            {
                return this.defendandDescriptionField;
            }
            set
            {
                this.defendandDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string DefendantDetailsObtained
        {
            get
            {
                return this.defendantDetailsObtainedField;
            }
            set
            {
                this.defendantDetailsObtainedField = value;
            }
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_InsurerInformation
    {

        private string insurerNameField;

        private C00_YNFlag selectedField;

        private bool selectedFieldSpecified;

        private string insurerOrganizationIDField;

        private string insurerOrganizationPathField;

        private C13_InsurerType_R3 insurerTypeField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C13_InsurerType_R3 InsurerType
        {
            get
            {
                return this.insurerTypeField;
            }
            set
            {
                this.insurerTypeField = value;
            }
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_OtherParty
    {

        private CT_INPUT_OtherDetails_PersonalDetails personalDetailsField;

        private CT_Vehicle vihicleInformationField;

        private CT_INPUT_Insurance_CompanyDetails insuranceCompanyInformatiionField;

        private C10_OtherParty oPTypeField;

        private string oPOtherField;

        /// <remarks/>
        public CT_INPUT_OtherDetails_PersonalDetails PersonalDetails
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
        public CT_Vehicle VihicleInformation
        {
            get
            {
                return this.vihicleInformationField;
            }
            set
            {
                this.vihicleInformationField = value;
            }
        }

        /// <remarks/>
        public CT_INPUT_Insurance_CompanyDetails InsuranceCompanyInformatiion
        {
            get
            {
                return this.insuranceCompanyInformatiionField;
            }
            set
            {
                this.insuranceCompanyInformatiionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C10_OtherParty OPType
        {
            get
            {
                return this.oPTypeField;
            }
            set
            {
                this.oPTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string OPOther
        {
            get
            {
                return this.oPOtherField;
            }
            set
            {
                this.oPOtherField = value;
            }
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Provider
    {

        private CT_Vehicle vehicleField;

        private string providerNameField;

        private string referenceNumberField;

        private string providerAddressField;

        private System.DateTime startDateField;

        private string endDateField;

        /// <remarks/>
        public CT_Vehicle Vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ProviderName
        {
            get
            {
                return this.providerNameField;
            }
            set
            {
                this.providerNameField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "date")]
        public System.DateTime StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
    }


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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Repairs
    {

        private CT_INPUT_AlternativeCompany alternativeCompanyField;

        private C00_YNFlag claiimingDamageOwnVehicleField;

        private C04_DetailsOfTheInsurance detailsOfTheInsuranceField;

        private bool detailsOfTheInsuranceFieldSpecified;

        private string otherDetailsField;

        private C00_YNFlag throughClaimantInsurerField;

        private bool throughClaimantInsurerFieldSpecified;

        private C00_YNFlag throughAlternatieCompanyField;

        private bool throughAlternatieCompanyFieldSpecified;

        private C05_RepairsPosition repairsPositionField;

        private bool repairsPositionFieldSpecified;

        private C00_YNFlag defendantInsInspectionField;

        private bool defendantInsInspectionFieldSpecified;

        private string locationField;

        private string contactDetailsField;

        private C14_YNDK totalLossField;

        private bool totalLossFieldSpecified;

        /// <remarks/>
        public CT_INPUT_AlternativeCompany AlternativeCompany
        {
            get
            {
                return this.alternativeCompanyField;
            }
            set
            {
                this.alternativeCompanyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag ClaiimingDamageOwnVehicle
        {
            get
            {
                return this.claiimingDamageOwnVehicleField;
            }
            set
            {
                this.claiimingDamageOwnVehicleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C04_DetailsOfTheInsurance DetailsOfTheInsurance
        {
            get
            {
                return this.detailsOfTheInsuranceField;
            }
            set
            {
                this.detailsOfTheInsuranceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DetailsOfTheInsuranceSpecified
        {
            get
            {
                return this.detailsOfTheInsuranceFieldSpecified;
            }
            set
            {
                this.detailsOfTheInsuranceFieldSpecified = value;
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
        public C00_YNFlag ThroughClaimantInsurer
        {
            get
            {
                return this.throughClaimantInsurerField;
            }
            set
            {
                this.throughClaimantInsurerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThroughClaimantInsurerSpecified
        {
            get
            {
                return this.throughClaimantInsurerFieldSpecified;
            }
            set
            {
                this.throughClaimantInsurerFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag ThroughAlternatieCompany
        {
            get
            {
                return this.throughAlternatieCompanyField;
            }
            set
            {
                this.throughAlternatieCompanyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThroughAlternatieCompanySpecified
        {
            get
            {
                return this.throughAlternatieCompanyFieldSpecified;
            }
            set
            {
                this.throughAlternatieCompanyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C05_RepairsPosition RepairsPosition
        {
            get
            {
                return this.repairsPositionField;
            }
            set
            {
                this.repairsPositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RepairsPositionSpecified
        {
            get
            {
                return this.repairsPositionFieldSpecified;
            }
            set
            {
                this.repairsPositionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag DefendantInsInspection
        {
            get
            {
                return this.defendantInsInspectionField;
            }
            set
            {
                this.defendantInsInspectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefendantInsInspectionSpecified
        {
            get
            {
                return this.defendantInsInspectionFieldSpecified;
            }
            set
            {
                this.defendantInsInspectionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ContactDetails
        {
            get
            {
                return this.contactDetailsField;
            }
            set
            {
                this.contactDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C14_YNDK TotalLoss
        {
            get
            {
                return this.totalLossField;
            }
            set
            {
                this.totalLossField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalLossSpecified
        {
            get
            {
                return this.totalLossFieldSpecified;
            }
            set
            {
                this.totalLossFieldSpecified = value;
            }
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_Vehicle
    {

        private string vRNField;

        private string makeField;

        private string modelField;

        private string engineSizeField;

        private string colorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string VRN
        {
            get
            {
                return this.vRNField;
            }
            set
            {
                this.vRNField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Make
        {
            get
            {
                return this.makeField;
            }
            set
            {
                this.makeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string EngineSize
        {
            get
            {
                return this.engineSizeField;
            }
            set
            {
                this.engineSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_INPUT_VehicleOwner_PersonalDetails
    {

        private CT_INPUT_Address addressField;

        private string nameField;

        private string middleNameField;

        private string surnameField;

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
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class DocumentInput
    {

        private DocumentInputApplicationData applicationDataField;

        private DocumentInputClaimAndClaimantDetails claimAndClaimantDetailsField;

        private DocumentInputMedicalDetails medicalDetailsField;

        private DocumentInputRepairsAndAlternativeVehicleProvision repairsAndAlternativeVehicleProvisionField;

        private DocumentInputAccidentData accidentDataField;

        private CT_INPUT_OtherParty[] otherPartyDetailsField;

        private DocumentInputLiabilityFunding liabilityFundingField;

        /// <remarks/>
        public DocumentInputApplicationData ApplicationData
        {
            get
            {
                return this.applicationDataField;
            }
            set
            {
                this.applicationDataField = value;
            }
        }

        /// <remarks/>
        public DocumentInputClaimAndClaimantDetails ClaimAndClaimantDetails
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
        public DocumentInputMedicalDetails MedicalDetails
        {
            get
            {
                return this.medicalDetailsField;
            }
            set
            {
                this.medicalDetailsField = value;
            }
        }

        /// <remarks/>
        public DocumentInputRepairsAndAlternativeVehicleProvision RepairsAndAlternativeVehicleProvision
        {
            get
            {
                return this.repairsAndAlternativeVehicleProvisionField;
            }
            set
            {
                this.repairsAndAlternativeVehicleProvisionField = value;
            }
        }

        /// <remarks/>
        public DocumentInputAccidentData AccidentData
        {
            get
            {
                return this.accidentDataField;
            }
            set
            {
                this.accidentDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherParty", IsNullable = false)]
        public CT_INPUT_OtherParty[] OtherPartyDetails
        {
            get
            {
                return this.otherPartyDetailsField;
            }
            set
            {
                this.otherPartyDetailsField = value;
            }
        }

        /// <remarks/>
        public DocumentInputLiabilityFunding LiabilityFunding
        {
            get
            {
                return this.liabilityFundingField;
            }
            set
            {
                this.liabilityFundingField = value;
            }
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentInputAccidentData
    {

        private CT_INPUT_AccidentDetails accidentDetailsField;

        private CT_INPUT_BusCoach busCoachField;

        /// <remarks/>
        public CT_INPUT_AccidentDetails AccidentDetails
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

        /// <remarks/>
        public CT_INPUT_BusCoach BusCoach
        {
            get
            {
                return this.busCoachField;
            }
            set
            {
                this.busCoachField = value;
            }
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentInputApplicationData
    {

        private CT_INPUT_Claim_Details claimDetailsField;

        /// <remarks/>
        public CT_INPUT_Claim_Details ClaimDetails
        {
            get
            {
                return this.claimDetailsField;
            }
            set
            {
                this.claimDetailsField = value;
            }
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentInputClaimAndClaimantDetails
    {

        private DocumentInputClaimAndClaimantDetailsClaimantRepresentative claimantRepresentativeField;

        private CT_INPUT_DefendantDetails defendantDetailsField;

        private CT_INPUT_ClaimantDetails claimantDetailsField;

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
        public CT_INPUT_DefendantDetails DefendantDetails
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
        public CT_INPUT_ClaimantDetails ClaimantDetails
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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentInputClaimAndClaimantDetailsClaimantRepresentative
    {

        private CT_INPUT_ClaimantRepresentative_CompanyDetails companyDetailsField;

        /// <remarks/>
        public CT_INPUT_ClaimantRepresentative_CompanyDetails CompanyDetails
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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentInputLiabilityFunding
    {

        private CT_INPUT_Liability liabilityField;

        private CT_INPUT_Funding fundingField;

        /// <remarks/>
        public CT_INPUT_Liability Liability
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
        public CT_INPUT_Funding Funding
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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentInputMedicalDetails
    {

        private CT_INPUT_Injury injuryField;

        private CT_INPUT_Hospital_R3[] hospitalField;

        private CT_INPUT_Rehabilitation rehabilitationField;

        /// <remarks/>
        public CT_INPUT_Injury Injury
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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentInputRepairsAndAlternativeVehicleProvision
    {

        private CT_INPUT_Repairs repairsField;

        private CT_INPUT_AlternativeVehicleProvision alternativeVehicleProvisionField;

        /// <remarks/>
        public CT_INPUT_Repairs Repairs
        {
            get
            {
                return this.repairsField;
            }
            set
            {
                this.repairsField = value;
            }
        }

        /// <remarks/>
        public CT_INPUT_AlternativeVehicleProvision AlternativeVehicleProvision
        {
            get
            {
                return this.alternativeVehicleProvisionField;
            }
            set
            {
                this.alternativeVehicleProvisionField = value;
            }
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CT_A2A_MedCoCase
    {

        private C00_YNFlag softTissueField;

        private string medCoCaseIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public C00_YNFlag SoftTissue
        {
            get
            {
                return this.softTissueField;
            }
            set
            {
                this.softTissueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string MedCoCaseID
        {
            get
            {
                return this.medCoCaseIDField;
            }
            set
            {
                this.medCoCaseIDField = value;
            }
        }
    }
}
