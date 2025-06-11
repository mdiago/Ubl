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
    /// A class to describe a piece of equipment used to transport goods.
    /// Shipping Container, Sea Container, Rail Wagon, Pallet, Trailer, Unit Load Device, ULD
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class TransportEquipment
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this piece of transport equipment.
        /// OCLU 1234567
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// An identifier for the consignment contained by this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ReferencedConsignmentID { get; set; }

        /// <summary>
        /// A code signifying the type of this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TransportEquipmentTypeCode { get; set; }

        /// <summary>
        /// A code signifying the type of provider of this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ProviderTypeCode { get; set; }

        /// <summary>
        /// A code signifying the type of owner of this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string OwnerTypeCode { get; set; }

        /// <summary>
        /// A code signifying the size and type of this piece of piece of transport equipment. When the piece of transport equipment is a shipping container, it is recommended to use ContainerSizeTypeCode for validation.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string SizeTypeCode { get; set; }

        /// <summary>
        /// A code signifying the current disposition of this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string DispositionCode { get; set; }

        /// <summary>
        /// A code signifying whether this piece of transport equipment is full, partially full, or empty.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string FullnessIndicationCode { get; set; }

        /// <summary>
        /// An indicator that this piece of transport equipment's refrigeration is on (true) or off (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool RefrigerationOnIndicator { get; set; }

        /// <summary>
        /// <para> Additional information about this piece of transport equipment.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Information { get; set; }

        /// <summary>
        /// An indicator that this piece of transport equipment is returnable (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool ReturnabilityIndicator { get; set; }

        /// <summary>
        /// An indication of the legal status of this piece of transport equipment with respect to the Container Convention Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool LegalStatusIndicator { get; set; }

        /// <summary>
        /// The percent of the airflow within this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal AirFlowPercent { get; set; }

        /// <summary>
        /// The percent humidity within this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal HumidityPercent { get; set; }

        /// <summary>
        /// An indicator that this piece of transport equipment is approved for animal food (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool AnimalFoodApprovedIndicator { get; set; }

        /// <summary>
        /// An indicator that this piece of transport equipment is approved for human food (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool HumanFoodApprovedIndicator { get; set; }

        /// <summary>
        /// An indicator that this piece of transport equipment is approved for dangerous goods (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool DangerousGoodsApprovedIndicator { get; set; }

        /// <summary>
        /// An indicator that this piece of transport equipment is refrigerated (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool RefrigeratedIndicator { get; set; }

        /// <summary>
        /// Characteristics of this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Characteristics { get; set; }

        /// <summary>
        /// <para> Damage associated with this piece of transport equipment.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] DamageRemarks { get; set; }

        /// <summary>
        /// <para> Text describing this piece of transport equipment.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Description { get; set; }

        /// <summary>
        /// <para> Special transport requirements expressed as text.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] SpecialTransportRequirements { get; set; }

        /// <summary>
        /// The gross weight of this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure GrossWeightMeasure { get; set; }

        /// <summary>
        /// The gross volume of this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure GrossVolumeMeasure { get; set; }

        /// <summary>
        /// The weight of this piece of transport equipment when empty.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure TareWeightMeasure { get; set; }

        /// <summary>
        /// A code signifying the tracking device for this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TrackingDeviceCode { get; set; }

        /// <summary>
        /// An indicator that this piece of transport equipment can supply power (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool PowerIndicator { get; set; }

        /// <summary>
        /// An identifier for use in tracing this piece of transport equipment, such as the EPC number used in RFID.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TraceID { get; set; }

        /// <summary>
        /// A measurable dimension (length, mass, weight, or volume) of this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Dimension> MeasurementDimension { get; set; }

        /// <summary>
        /// A seal securing the door of a piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TransportEquipmentSeal> TransportEquipmentSeal { get; set; }

        /// <summary>
        /// In the case of a refrigeration unit, the minimum allowable operating temperature for this container.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Temperature MinimumTemperature { get; set; }

        /// <summary>
        /// In the case of a refrigeration unit, the maximum allowable operating temperature for this container.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Temperature MaximumTemperature { get; set; }

        /// <summary>
        /// The party providing this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party ProviderParty { get; set; }

        /// <summary>
        /// The authorized party responsible for certifying that the goods were loaded into this piece of transport equipment.
        /// Party responsible for proof of vanning (WCO ID 059)
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party LoadingProofParty { get; set; }

        /// <summary>
        ///	The party that supplies this piece of transport equipment.
        ///	Party responsible for proof of vanning (WCO ID 059)
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public SupplierParty SupplierParty { get; set; }

        /// <summary>
        /// The party that owns this piece of transport equipment.
        /// Party responsible for proof of vanning (WCO ID 059)
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party OwnerParty { get; set; }

        /// <summary>
        /// The party that operates this piece of transport equipment.
        /// Party responsible for proof of vanning (WCO ID 059)
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party OperatingParty { get; set; }

        /// <summary>
        /// The location where this piece of transport equipment is loaded.
        /// Vanning address (WCO ID 068), Stuffing location
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location LoadingLocation { get; set; }

        /// <summary>
        /// The location where this piece of transport equipment is unloaded.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location UnloadingLocation { get; set; }

        /// <summary>
        ///	The location where this piece of transport equipment is being stored.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location StorageLocation { get; set; }

        /// <summary>
        ///	A positioning of this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TransportEvent> PositioningTransportEvent { get; set; }

        /// <summary>
        ///	A quarantine of this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TransportEvent> QuarantineTransportEvent { get; set; }

        /// <summary>
        ///	A delivery of this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TransportEvent> DeliveryTransportEvent { get; set; }

        /// <summary>
        ///	A pickup of this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TransportEvent> PickupTransportEvent { get; set; }

        /// <summary>
        ///	A handling of this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TransportEvent> HandlingTransportEvent { get; set; }

        /// <summary>
        ///	A loading of this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TransportEvent> LoadingTransportEvent { get; set; }

        /// <summary>
        /// A transport event associated with this piece of transport equipment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TransportEvent> TransportEvent { get; set; }

        /// <summary>
        /// The location where this piece of transport equipment is unloaded.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TransportMeans ApplicableTransportMeans { get; set; }

        #endregion

    }

}