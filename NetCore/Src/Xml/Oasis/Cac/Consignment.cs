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
    /// A class to describe an identifiable collection of one or more
    /// goods items to be transported between the consignor and the
    /// consignee. This information may be defined within a transport
    /// contract. A consignment may comprise more than one shipment
    /// (e.g., when consolidated by a freight forwarder).
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class Consignment
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// <para> An identifier assigned to a collection of goods for both import and export.</para>
        /// <para> Unique consignment reference number (UCR).</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// <para> An identifier for this consignment, assigned by the carrier.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CarrierAssignedID { get; set; }

        /// <summary>
        /// <para> 	An identifier for this consignment, assigned by the consignee.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ConsigneeAssignedID { get; set; }

        /// <summary>
        /// <para> 	An identifier for this consignment, assigned by the consignor.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ConsignorAssignedID { get; set; }

        /// <summary>
        /// <para> An identifier for this consignment, assigned by the freight forwarder.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string FreightForwarderAssignedID { get; set; }

        /// <summary>
        /// <para> An identifier for this consignment, assigned by the broker.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string BrokerAssignedID { get; set; }

        /// <summary>
        /// <para> An identifier for this consignment, assigned by the contracted carrier.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ContractedCarrierAssignedID { get; set; }

        /// <summary>
        /// <para> An identifier for this consignment, assigned by the performing carrier.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PerformingCarrierAssignedID { get; set; }

        /// <summary>
        /// <para> 	A textual summary description of the consignment.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] SummaryDescription { get; set; }

        /// <summary>
        /// The total of all invoice amounts declared in this consignment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount TotalInvoiceAmount { get; set; }

        /// <summary>
        /// The total declared value for customs purposes of all the goods
        /// in this consignment, regardless of whether they are subject to
        /// the same customs procedure, tariff/statistical categorization,
        /// country information, or duty regime.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount DeclaredCustomsValueAmount { get; set; }

        /// <summary>
        /// <para> Text describing the tariff applied to this consignment.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] TariffDescription { get; set; }

        /// <summary>
        /// <para> A code signifying the tariff applied to this consignment.</para>
        /// <para> Tariff code number (WCO ID 145).</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TariffCode { get; set; }

        /// <summary>
        /// <para> The amount of the premium payable to an insurance company
        /// for insuring the goods contained in this consignment.</para>
        /// <para> Insurance Cost.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount InsurancePremiumAmount { get; set; }

        /// <summary>
        /// <para>The total declared weight of the goods in this consignment,
        /// including packaging but excluding the carrier's equipment.</para>
        /// <para> Total gross weight (WCO ID 131)</para>
        /// <para> Total cube of all goods items referred to as one consignment.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure GrossWeightMeasure { get; set; }

        /// <summary>
        /// The total net weight of all the goods items referred to as one consignment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure NetWeightMeasure { get; set; }

        /// <summary>
        /// The total net weight of the goods in this consignment, exclusive of packaging.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure NetNetWeightMeasure { get; set; }

        /// <summary>
        /// The weight upon which a charge is to be based.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure ChargeableWeightMeasure { get; set; }

        /// <summary>
        /// The total volume of the goods referred to as one consignment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure GrossVolumeMeasure { get; set; }

        /// <summary>
        /// The total net volume of all goods items referred to as one consignment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure NetVolumeMeasure { get; set; }

        /// <summary>
        /// The total length in a means of transport or a piece of transport
        /// equipment which, given the width and height of the transport
        /// means, will accommodate all of the consignments in a single
        /// consolidation.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure LoadingLengthMeasure { get; set; }

        /// <summary>
        /// <para> Remarks concerning the complete consignment,
        /// to be printed on the transport document.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Remarks { get; set; }

        /// <summary>
        /// An indication that the transported goods in this consignment are
        /// subject to an international regulation concerning the carriage
        /// of dangerous goods (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool HazardousRiskIndicator { get; set; }

        /// <summary>
        /// An indication that the transported goods in this consignment
        /// are animal foodstuffs (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool AnimalFoodIndicator { get; set; }

        /// <summary>
        /// An indication that the transported goods in this consignment
        /// are for human consumption (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool HumanFoodIndicator { get; set; }

        /// <summary>
        /// An indication that the transported goods are livestock (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool LivestockIndicator { get; set; }

        /// <summary>
        /// An indication that the transported goods in this consignment
        /// are bulk cargoes (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool BulkCargoIndicator { get; set; }

        /// <summary>
        /// An indication that the transported goods in this consignment
        /// are containerized cargoes (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool ContainerizedIndicator { get; set; }

        /// <summary>
        /// An indication that the transported goods in this consignment
        /// are general cargoes (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool GeneralCargoIndicator { get; set; }

        /// <summary>
        /// An indication that the transported goods in this consignment
        /// require special security (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool SpecialSecurityIndicator { get; set; }

        /// <summary>
        /// An indication that this consignment will be paid for by a
        /// third party (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool ThirdPartyPayerIndicator { get; set; }

        /// <summary>
        /// <para> Service instructions to the carrier, expressed as text.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] CarrierServiceInstructions { get; set; }

        /// <summary>
        /// <para> Service instructions for customs clearance, expressed as text.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] CustomsClearanceServiceInstructions { get; set; }

        /// <summary>
        /// <para> Service instructions for the forwarder, expressed as text.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] ForwarderServiceInstructions { get; set; }

        /// <summary>
        /// <para> Special service instructions, expressed as text.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] SpecialServiceInstructions { get; set; }

        /// <summary>
        /// A sequence identifier for this consignment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string SequenceID { get; set; }

        /// <summary>
        /// A code signifying the priority or level of service required for this consignment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ShippingPriorityLevelCode { get; set; }

        /// <summary>
        /// The handling required for this consignment, expressed as a code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string HandlingCode { get; set; }

        /// <summary>
        /// <para> The handling required for this consignment, expressed as text.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] HandlingInstructions { get; set; }

        /// <summary>
        /// <para> Free-form text pertinent to this consignment, conveying information
        /// that is not contained explicitly in other structures.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Information { get; set; }

        /// <summary>
        /// The total number of goods items in this consignment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity TotalGoodsItemQuantity { get; set; }

        /// <summary>
        /// The number of pieces of transport handling equipment
        /// (pallets, boxes, cases, etc.) in this consignment. Number of THUs.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity TotalTransportHandlingUnitQuantity { get; set; }

        /// <summary>
        /// The amount covered by insurance for this consignment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount InsuranceValueAmount { get; set; }

        /// <summary>
        /// The value of this consignment, declared by the shipper or his agent solely for
        /// the purpose of varying the carrier's level of liability from that provided in
        /// the contract of carriage, in case of loss or damage to goods or delayed delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount DeclaredForCarriageValueAmount { get; set; }

        /// <summary>
        /// The value, declared for statistical purposes, of those goods in this consignment
        /// that have the same statistical heading.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount DeclaredStatisticsValueAmount { get; set; }

        /// <summary>
        /// The monetary amount that has to be or has been paid as calculated under the
        /// applicable trade delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount FreeOnBoardValueAmount { get; set; }

        /// <summary>
        /// <para> Special instructions relating to this consignment.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] SpecialInstructions { get; set; }

        /// <summary>
        /// An indicator that this consignment has been split in transit (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool SplitConsignmentIndicator { get; set; }

        /// <summary>
        /// <para> A set of delivery instructions relating to this consignment.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] DeliveryInstructions { get; set; }

        /// <summary>
        /// The count in this consignment considering goods items, child consignments, shipments.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity ConsignmentQuantity { get; set; }

        /// <summary>
        /// An indicator that this consignment can be consolidated (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool ConsolidatableIndicator { get; set; }

        /// <summary>
        /// <para> Instructions regarding haulage of this consignment, expressed as text.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] HaulageInstructions { get; set; }

        /// <summary>
        /// An identifier for the loading sequence of this consignment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string LoadingSequenceID { get; set; }

        /// <summary>
        /// The quantity of (consolidated) child consignments.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity ChildConsignmentQuantity { get; set; }

        /// <summary>
        /// The total number of packages associated with a Consignment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity TotalPackagesQuantity { get; set; }


        /// <summary>
        /// A consolidated shipment (a shipment created by an act of consolidation).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Shipment> ConsolidatedShipment { get; set; }

        /// <summary>
        /// A class describing identifiers or references relating to customs procedures.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<CustomsDeclaration> CustomsDeclaration { get; set; }

        /// <summary>
        /// An alternative delivery location.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent RequestedPickupTransportEvent { get; set; }

        /// <summary>
        /// The period requested for delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period RequestedDeliveryPeriod { get; set; }

        /// <summary>
        /// The period promised for delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period PromisedDeliveryPeriod { get; set; }

        /// <summary>
        /// The period estimated for delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period EstimatedDeliveryPeriod { get; set; }

        /// <summary>
        /// The party responsible for delivering the goods.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party CarrierParty { get; set; }

        /// <summary>
        /// The party to whom the goods are delivered.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party DeliveryParty { get; set; }

        /// <summary>
        ///	A party to be notified of this delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Party> NotifyParty { get; set; }

        /// <summary>
        /// The despatch (pickup) associated with this delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Despatch Despatch { get; set; }

        /// <summary>
        ///	Terms and conditions relating to the delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<DeliveryTerms> DeliveryTerms { get; set; }

        /// <summary>
        /// The minimum delivery unit for this delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DeliveryUnit MinimumDeliveryUnit { get; set; }

        /// <summary>
        /// The maximum delivery unit for this delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DeliveryUnit MaximumDeliveryUnit { get; set; }

        /// <summary>
        /// The shipment being delivered.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Shipment Shipment { get; set; }

        #endregion

    }

}