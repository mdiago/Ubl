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
    /// A class to describe one stage of movement in a transport of goods.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class ShipmentStage
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// A code signifying the method of transport used for this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TransportModeCode { get; set; }

        /// <summary>
        /// A code signifying the kind of transport means (truck, vessel, etc.) used for this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TransportMeansTypeCode { get; set; }

        /// <summary>
        /// A code signifying the direction of transit in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TransitDirectionCode { get; set; }

        /// <summary>
        /// An indicator that this stage takes place before the main carriage of the shipment (true) or not (false).
        /// Truck delivery to wharf
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool PreCarriageIndicator { get; set; }

        /// <summary>
        ///	An indicator that this stage takes place after the main carriage of the shipment (true) or not (false).
        ///	Truck delivery from wharf
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool OnCarriageIndicator { get; set; }

        /// <summary>
        /// The estimated date of delivery in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// The estimated time of delivery in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime EstimatedDeliveryTime { get; set; }

        /// <summary>
        /// The delivery date required by the buyer in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime RequiredDeliveryDate { get; set; }

        /// <summary>
        /// The delivery time required by the buyer in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime RequiredDeliveryTime { get; set; }

        /// <summary>
        /// An identifier for the loading sequence (of consignments) associated with this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string LoadingSequenceID { get; set; }

        /// <summary>
        /// Identifies the successive loading sequence (of consignments) associated with a shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string SuccessiveSequenceID { get; set; }

        /// <summary>
        /// <para> Text of instructions applicable to a shipment stage.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Instructions { get; set; }

        /// <summary>
        /// <para> Text of instructions relating to demurrage (the case in which a vessel is prevented from loading or discharging cargo within the stipulated laytime).</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] DemurrageInstructions { get; set; }

        /// <summary>
        /// The total number of crew aboard a transport means.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity CrewQuantity { get; set; }

        /// <summary>
        /// The total number of passengers aboard a transport means.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity PassengerQuantity { get; set; }

        /// <summary>
        ///	The period during which this shipment stage actually took place.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period TransitPeriod { get; set; }

        /// <summary>
        /// A carrier party responsible for this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Party> CarrierParty { get; set; }

        /// <summary>
        ///	The means of transport used in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportMeans TransportMeans { get; set; }

        /// <summary>
        ///	The location of loading for a shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location LoadingPortLocation { get; set; }

        /// <summary>
        ///	The location of unloading for a shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location UnloadingPortLocation { get; set; }

        /// <summary>
        ///	The location of transshipment relating to a shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location TransshipPortLocation { get; set; }

        /// <summary>
        ///	The loading of goods in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent LoadingTransportEvent { get; set; }

        /// <summary>
        ///	The examination of shipments in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent ExaminationTransportEvent { get; set; }

        /// <summary>
        ///	The making available of shipments in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent AvailabilityTransportEvent { get; set; }

        /// <summary>
        ///	The export event associated with this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent ExportationTransportEvent { get; set; }

        /// <summary>
        /// The discharge event associated with this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent DischargeTransportEvent { get; set; }

        /// <summary>
        ///	The warehousing event associated with this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent WarehousingTransportEvent { get; set; }

        /// <summary>
        ///	The receiver's takeover of the goods in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent TakeoverTransportEvent { get; set; }

        /// <summary>
        ///	The optional takeover of the goods in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent OptionalTakeoverTransportEvent { get; set; }

        /// <summary>
        /// The dropping off of goods in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent DropoffTransportEvent { get; set; }

        /// <summary>
        ///	The pickup of goods in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent ActualPickupTransportEvent { get; set; }

        /// <summary>
        ///	The delivery of goods in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent DeliveryTransportEvent { get; set; }

        /// <summary>
        ///	The receipt of goods in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent ReceiptTransportEvent { get; set; }

        /// <summary>
        ///	The storage of goods in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent StorageTransportEvent { get; set; }

        /// <summary>
        ///	The acceptance of goods in this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent AcceptanceTransportEvent { get; set; }

        /// <summary>
        ///	A terminal operator associated with this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party TerminalOperatorParty { get; set; }

        /// <summary>
        ///	A customs agent associated with this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party CustomsAgentParty { get; set; }

        /// <summary>
        ///	The estimated transit period of this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period EstimatedTransitPeriod { get; set; }

        /// <summary>
        /// A carrier party responsible for this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<AllowanceCharge> FreightAllowanceCharge { get; set; }

        /// <summary>
        ///	The location associated with a freight charge related to this shipment stage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location FreightChargeLocation { get; set; }

        /// <summary>
        ///	The detention of a transport means during loading and unloading operations.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent DetentionTransportEvent { get; set; }

        /// <summary>
        ///	The departure requested by the party requesting a transportation service.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent RequestedDepartureTransportEvent { get; set; }

        /// <summary>
        ///	The arrival requested by the party requesting a transportation service.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent RequestedArrivalTransportEvent { get; set; }

        /// <summary>
        ///	A waypoint requested by the party requesting a transportation service.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent RequestedWaypointTransportEvent { get; set; }

        /// <summary>
        ///	The departure planned by the party providing a transportation service.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent PlannedDepartureTransportEvent { get; set; }

        /// <summary>
        ///	The arrival planned by the party providing a transportation service.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent PlannedArrivalTransportEvent { get; set; }

        /// <summary>
        ///	A waypoint planned by the party providing a transportation service.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent PlannedWaypointTransportEvent { get; set; }

        /// <summary>
        ///	The actual departure from a specific location during a transportation service.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent ActualDepartureTransportEvent { get; set; }

        /// <summary>
        ///	The location of an actual waypoint during a transportation service.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent ActualWaypointTransportEvent { get; set; }

        /// <summary>
        ///	The actual arrival at a specific location during a transportation service.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent ActualArrivalTransportEvent { get; set; }

        /// <summary>
        ///	A significant occurrence in the course of this shipment of goods.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TransportEvent> TransportEvent { get; set; }

        /// <summary>
        ///	Describes an estimated departure at a location during a transport service.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent EstimatedDepartureTransportEvent { get; set; }

        /// <summary>
        ///	Describes an estimated arrival at a location during a transport service.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportEvent EstimatedArrivalTransportEvent { get; set; }

        /// <summary>
        ///	A person who travels in a conveyance without participating in its operation.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Person> PassengerPerson { get; set; }

        /// <summary>
        ///	escribes a person responsible for driving the transport means.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Person> DriverPerson { get; set; }

        /// <summary>
        ///	Describes a person being responsible for providing the required administrative reporting relating to a transport.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Person ReportingPerson { get; set; }

        /// <summary>
        ///	A person operating or serving aboard a transport means.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Person> CrewMemberPerson { get; set; }

        /// <summary>
        ///	The person on board the vessel, accountable to the master, designated
        ///	by the company as responsible for the security of the ship, including
        ///	implementation and maintenance of the ship security plan and for the
        ///	liaison with the company security officer and the port facility
        ///	security officers.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Person SecurityOfficerPerson { get; set; }

        /// <summary>
        ///	The person responsible for the ship's safe and efficient operation,
        ///	including cargo operations, navigation, crew management and for
        ///	ensuring that the vessel complies with local and international
        ///	laws, as well as company and flag state policies.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Person MasterPerson { get; set; }

        /// <summary>
        ///	he person responsible for the health of the people aboard a ship at sea.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Person ShipsSurgeonPerson { get; set; }

        #endregion

    }

}