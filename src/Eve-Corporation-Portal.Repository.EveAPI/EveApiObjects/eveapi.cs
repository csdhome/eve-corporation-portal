using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eve_Corporation_Portal.Repository.EveAPI.EveApiObjects
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class eveapi
    {

        private string currentTimeField;

        private eveapiResult resultField;

        private string cachedUntilField;

        private byte versionField;

        /// <remarks/>
        public string currentTime
        {
            get
            {
                return this.currentTimeField;
            }
            set
            {
                this.currentTimeField = value;
            }
        }

        /// <remarks/>
        public eveapiResult result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }

        /// <remarks/>
        public string cachedUntil
        {
            get
            {
                return this.cachedUntilField;
            }
            set
            {
                this.cachedUntilField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eveapiResult
    {

        private eveapiResultRowset rowsetField;

        /// <remarks/>
        public eveapiResultRowset rowset
        {
            get
            {
                return this.rowsetField;
            }
            set
            {
                this.rowsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eveapiResultRowset
    {

        private eveapiResultRowsetRow[] rowField;

        private string nameField;

        private string keyField;

        private string columnsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("row")]
        public eveapiResultRowsetRow[] row
        {
            get
            {
                return this.rowField;
            }
            set
            {
                this.rowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string columns
        {
            get
            {
                return this.columnsField;
            }
            set
            {
                this.columnsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eveapiResultRowsetRow
    {

        private string nameField;

        private uint characterIDField;

        private string corporationNameField;

        private uint corporationIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint characterID
        {
            get
            {
                return this.characterIDField;
            }
            set
            {
                this.characterIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string corporationName
        {
            get
            {
                return this.corporationNameField;
            }
            set
            {
                this.corporationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint corporationID
        {
            get
            {
                return this.corporationIDField;
            }
            set
            {
                this.corporationIDField = value;
            }
        }
    }


}
