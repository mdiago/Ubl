/*
    This file is part of the Ubl (R) project.
    Copyright (c) 2025-2026 Irene Solutions SL
    Authors: Irene Solutions SL.

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License version 3
    as published by the Free Software Foundation with the addition of the
    following permission added to Section 15 as permitted in Section 7(a):
    FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
    IRENE SOLUTIONS SL. IRENE SOLUTIONS SL DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
    OF THIRD PARTY RIGHTS
    
    This program is distributed in the hope that it will be useful, but
    WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
    or FITNESS FOR A PARTICULAR PURPOSE.
    See the GNU Affero General Public License for more details.
    You should have received a copy of the GNU Affero General Public License
    along with this program; if not, see http://www.gnu.org/licenses or write to
    the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, or download the license from the following URL:
        http://www.irenesolutions.com/terms-of-use.pdf
    
    The interactive user interfaces in modified source and object code versions
    of this program must display Appropriate Legal Notices, as required under
    Section 5 of the GNU Affero General Public License.
    
    You can be released from the requirements of the license by purchasing
    a commercial license. Buying such a license is mandatory as soon as you
    develop commercial activities involving the Ubl software without
    disclosing the source code of your own applications.
    These activities include: offering paid services to customers as an ASP,
    serving Ubl XML data on the fly in a web application, shipping Ubl
    with a closed source product.
    
    For more information, please contact Irene Solutions SL. at this
    address: info@irenesolutions.com
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Ubl.Xml.Oasis.Cbc;

namespace Ubl.Xml.Oasis.Cac
{

    /// <summary>
    /// A class to describe a hazardous item.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class HazardousItem
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this hazardous item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// Text of the placard notation corresponding to the hazard class
        /// of this hazardous item. Can also be the hazard identification
        /// number of the orange placard (upper part) required on the means
        /// of transport.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PlacardNotation { get; set; }

        /// <summary>
        /// Text of the placard endorsement that is to be shown on the
        /// shipping papers for this hazardous item. Can also be used
        /// for the number of the orange placard (lower part) required
        /// on the means of transport.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PlacardEndorsement { get; set; }

        /// <summary>
        /// <para> Text providing further information about the
        /// hazardous substance.</para>
        /// <para> Must be stored away from flammable materials
        /// N.O.S. or a Waste Characteristics Code in conjunction
        /// with an EPA Waste Stream code</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] AdditionalInformation { get; set; }

        /// <summary>
        /// The UN code for this kind of hazardous item.
        /// UN Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string UNDGCode { get; set; }

        /// <summary>
        /// A code signifying the emergency procedures for this hazardous item.
        /// UN Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string EmergencyProceduresCode { get; set; }

        /// <summary>
        /// A code signifying a medical first aid guide
        /// appropriate to this hazardous item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string MedicalFirstAidGuideCode { get; set; }

        /// <summary>
        /// The full technical name of a specific hazardous
        /// substance contained in this goods item.
        /// Granular Sodium Chlorate WeedKiller.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TechnicalName { get; set; }

        /// <summary>
        /// The name of the category of hazard that applies to the Item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CategoryName { get; set; }

        /// <summary>
        /// 	A code signifying a kind of hazard for a material.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string HazardousCategoryCode { get; set; }

        /// <summary>
        /// The number for the upper part of the orange hazard placard
        /// required on the means of transport.
        /// Hazard identification number (upper part)
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string UpperOrangeHazardPlacardID { get; set; }

        /// <summary>
        /// The number for the lower part of the orange hazard placard
        /// required on the means of transport.
        /// Substance identification number (lower part)
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string LowerOrangeHazardPlacardID { get; set; }

        /// <summary>
        /// An identifier to the marking of the Hazardous Item
        /// Dangerous goods label marking.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string MarkingID { get; set; }

        /// <summary>
        /// An identifier for the hazard class applicable to this hazardous
        /// item as defined by the relevant regulation authority
        /// (e.g., the IMDG Class Number of the SOLAS Convention of IMO
        /// and the ADR/RID Class Number for the road/rail environment).
        /// IMDG Class Number, ADR/RID Class Number
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string HazardClassID { get; set; }

        /// <summary>
        /// The net weight of this hazardous item, excluding packaging.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure NetWeightMeasure { get; set; }

        /// <summary>
        /// The volume of this hazardous item, excluding packaging
        /// and transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure NetVolumeMeasure { get; set; }

        /// <summary>
        /// The quantity of goods items in this hazardous item
        /// that are hazardous.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity Quantity { get; set; }

        /// <summary>
        /// The individual, group, or body to be contacted in
        /// case of a hazardous incident associated with this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party ContactParty { get; set; }

        /// <summary>
        /// A secondary hazard associated with this hazardous item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<SecondaryHazard> SecondaryHazard { get; set; }

        /// <summary>
        /// Information related to the transit of this kind of
        /// hazardous goods.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<HazardousGoodsTransit> HazardousGoodsTransit { get; set; }

        /// <summary>
        /// The threshold temperature at which emergency procedures
        /// apply in the handling of temperature-controlled goods.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Temperature EmergencyTemperature { get; set; }

        /// <summary>
        /// The flashpoint temperature of this hazardous item; i.e., the
        /// lowest temperature at which vapors above a volatile combustible
        /// substance ignite in air when exposed to flame.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Temperature FlashpointTemperature { get; set; }

        /// <summary>
        /// Another temperature relevant to the handling of this hazardous item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Temperature> AdditionalTemperature { get; set; }

        #endregion

    }

}