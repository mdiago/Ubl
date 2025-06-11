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
    /// A class to describe a uniquely identifiable unit consisting of one or more packages, goods items, or pieces of transport equipment.
    /// Logistics Unit, Handling Unit, THU
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class TransportHandlingUnit
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// Specifies the status condition of the related object.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// Specifies the status condition of the related object.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TransportHandlingUnitTypeCode { get; set; }

        /// <summary>
        /// Specifies the status condition of the related object.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string HandlingCode { get; set; }

        /// <summary>
        /// Text describing this status.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] HandlingInstructions { get; set; }

        /// <summary>
        /// Specifies an indicator relevant to a specific status.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool HazardousRiskIndicator { get; set; }

        /// <summary>
        /// The total number of packages associated with a Consignment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity TotalGoodsItemQuantity { get; set; }

        /// <summary>
        /// The total number of packages associated with a Consignment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity TotalPackageQuantity { get; set; }

        /// <summary>
        /// Text describing this status.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] DamageRemarks { get; set; }
       
        /// <summary>
        /// A sequence identifier for this status.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TraceID { get; set; }

        /// <summary>
        /// A despatch line associated with this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<DespatchLine> HandlingUnitDespatchLine { get; set; }

        /// <summary>
        /// A package contained in this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Package> ActualPackage { get; set; }

        /// <summary>
        /// A receipt line associated with this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<ReceiptLine> ReceivedHandlingUnitReceiptLine { get; set; }

        /// <summary>
        /// A piece of transport equipment associated with this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TransportEquipment> TransportEquipment { get; set; }

        /// <summary>
        /// A means of transport associated with this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TransportMeans> TransportMeans { get; set; }

        /// <summary>
        /// Transit-related information regarding a type of hazardous goods contained in this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<HazardousGoodsTransit> HazardousGoodsTransit { get; set; }

        /// <summary>
        /// A measurable dimension (length, mass, weight, or volume) of this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Dimension> MeasurementDimension { get; set; }

        /// <summary>
        /// The minimum required operating temperature of this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Temperature MinimumTemperature { get; set; }

        /// <summary>
        /// The maximum allowable operating temperature of this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Temperature MaximumTemperature { get; set; }

        /// <summary>
        /// A goods item contained in this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<GoodsItem> GoodsItem { get; set; }

        /// <summary>
        /// The floor space measurement dimension associated with this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Dimension FloorSpaceMeasurementDimension { get; set; }

        /// <summary>
        /// The pallet space measurement dimension associated to this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Dimension PalletSpaceMeasurementDimension { get; set; }

        /// <summary>
        /// A reference to a shipping document associated with this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<DocumentReference> ShipmentDocumentReference { get; set; }

        /// <summary>
        /// The status of this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Status> Status { get; set; }

        /// <summary>
        /// Describes identifiers or references relating to customs procedures.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<CustomsDeclaration> CustomsDeclaration { get; set; }

        /// <summary>
        /// A shipment associated with this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Shipment> ReferencedShipment { get; set; }

        /// <summary>
        /// A package contained in this transport handling unit.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Package> Package { get; set; }

        #endregion

    }

}