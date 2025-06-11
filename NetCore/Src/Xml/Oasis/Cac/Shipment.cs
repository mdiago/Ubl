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
    /// A class defining an identifiable collection of one or more goods
    /// items to be transported between the seller party and the buyer party.
    /// This information may be defined within a commercial contract.
    /// A shipment can be transported in different consignments
    /// (e.g., split for logistical purposes).
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class Shipment
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// <para>	An identifier for this shipment.</para>
        /// <para>	Sample: Waybill Number</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// A code signifying the priority or level of service required for this shipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ShippingPriorityLevelCode { get; set; }

        /// <summary>
        /// The handling required for this shipment, expressed as a code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string HandlingCode { get; set; }

        /// <summary>
        /// <para> The handling required for this shipment, expressed as text.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] HandlingInstructions { get; set; }

        /// <summary>
        /// <para> Free-form text pertinent to this shipment, conveying
        /// information that is not contained explicitly in other structures.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Information { get; set; }

        /// <summary>
        /// The total gross weight of a shipment; the weight of the goods plus packaging plus transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure GrossWeightMeasure { get; set; }

        /// <summary>
        /// The net weight of this shipment, excluding packaging.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure NetWeightMeasure { get; set; }

        /// <summary>
        /// The total net weight of this shipment, excluding packaging and transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure NetNetWeightMeasure { get; set; }

        /// <summary>
        /// The total volume of the goods in this shipment, including packaging.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure GrossVolumeMeasure { get; set; }

        /// <summary>
        /// The total volume of the goods in this shipment, excluding packaging and transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure NetVolumeMeasure { get; set; }

        /// <summary>
        /// The total number of goods items in this shipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity TotalGoodsItemQuantity { get; set; }

        /// <summary>
        /// The number of pieces of transport handling equipment (pallets, boxes, cases, etc.) in this shipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity TotalTransportHandlingUnitQuantity { get; set; }

        /// <summary>
        /// The amount covered by insurance for this shipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount InsuranceValueAmount { get; set; }

        /// <summary>
        /// The total declared value for customs purposes of those goods in this shipment
        /// that are subject to the same customs procedure and have the same
        /// tariff/statistical heading, country information, and duty regime.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount DeclaredCustomsValueAmount { get; set; }

        /// <summary>
        /// The value of this shipment, declared by the shipper or his agent solely
        /// for the purpose of varying the carrier's level of liability from that
        /// provided in the contract of carriage, in case of loss or damage to goods
        /// or delayed delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount DeclaredForCarriageValueAmount { get; set; }

        /// <summary>
        /// The value, declared for statistical purposes, of those goods in this shipment that have the same statistical heading.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount DeclaredStatisticsValueAmount { get; set; }

        /// <summary>
        /// The monetary amount that has to be or has been paid as calculated under the applicable trade delivery.
        /// FOB Value
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount FreeOnBoardValueAmount { get; set; }

        /// <summary>
        /// <para>	Special instructions relating to this shipment.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] SpecialInstructions { get; set; }

        /// <summary>
        /// <para> Delivery instructions relating to this shipment.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] DeliveryInstructions { get; set; }

        /// <summary>
        /// An indicator that the consignment has been split in transit (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool SplitConsignmentIndicator { get; set; }

        /// <summary>
        /// The total number of consignments within this shipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity ConsignmentQuantity { get; set; }

        /// <summary>
        /// The customer party itself.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Consignment> Consignment { get; set; }

        /// <summary>
        /// The customer party itself.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<GoodsItem> GoodsItem { get; set; }

        /// <summary>
        /// The customer party itself.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<ShipmentStage> ShipmentStage { get; set; }

        /// <summary>
        /// The customer party itself.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Delivery Delivery { get; set; }

        /// <summary>
        /// The customer party itself.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TransportHandlingUnit> TransportHandlingUnit { get; set; }

        /// <summary>
        /// The customer party itself.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Address ReturnAddress { get; set; }

        /// <summary>
        /// The customer party itself.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Address OriginAddress { get; set; }

        /// <summary>
        /// The customer party itself.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location FirstArrivalPortLocation { get; set; }

        /// <summary>
        /// The customer party itself.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location LastExitPortLocation { get; set; }

        /// <summary>
        /// The customer party itself.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Country ExportCountry { get; set; }

        /// <summary>
        /// The customer party itself.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<AllowanceCharge> FreightAllowanceCharge { get; set; }

        #endregion

    }

}