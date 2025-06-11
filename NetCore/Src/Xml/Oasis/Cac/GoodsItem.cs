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
    /// A class to describe a separately identifiable quantity of goods of a single product type.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class GoodsItem
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this goods item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// A sequence number differentiating a specific goods item within a consignment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string SequenceNumberID { get; set; }

        /// <summary>
        /// <para> Text describing this goods item to identify it for customs, statistical, or transport purposes.</para>
        /// <para> Description of goods (WCO ID 137)</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Description { get; set; }

        /// <summary>
        /// An indication that the transported goods item is subject to an international regulation concerning the carriage of dangerous goods (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool HazardousRiskIndicator { get; set; }

        /// <summary>
        /// The total declared value for customs purposes of the goods item.
        /// For Customs Value (WCO ID 108)
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount DeclaredCustomsValueAmount { get; set; }

        /// <summary>
        /// The value of this goods item, declared by the shipper or his agent solely for the purpose of varying the carrier's level of liability from that provided in the contract of carriage, in case of loss or damage to goods or delayed delivery.
        /// Interest in delivery, declared value for carriage
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount DeclaredForCarriageValueAmount { get; set; }

        /// <summary>
        /// The total declared value of all the goods items in the same consignment with this goods item that have the same statistical heading.
        /// Statistical Value (WCO ID 114)
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
        /// The amount covered by insurance for this goods item.
        /// Value Insured
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount InsuranceValueAmount { get; set; }

        /// <summary>
        /// The amount on which a duty, tax, or fee will be assessed.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount ValueAmount { get; set; }

        /// <summary>
        /// The weight of this goods item, including packing and packaging but excluding the carrier's equipment.
        /// Actual Gross Weight
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure GrossWeightMeasure { get; set; }

        /// <summary>
        /// The weight of this goods item, excluding packing but including packaging that normally accompanies the goods.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure NetWeightMeasure { get; set; }

        /// <summary>
        /// The total weight of this goods item, excluding all packing and packaging.
        /// Customs Weight (WCO ID 128)
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure NetNetWeightMeasure { get; set; }

        /// <summary>
        /// The weight on which a charge is to be based.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure ChargeableWeightMeasure { get; set; }

        /// <summary>
        /// The volume of this goods item, normally calculated by multiplying its maximum length, width, and height.
        /// Volume, Gross Measurement Cube (GMC), Cube (WCO ID 134)
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure GrossVolumeMeasure { get; set; }

        /// <summary>
        /// The volume contained by a goods item, excluding the volume of any packaging material.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure NetVolumeMeasure { get; set; }

        /// <summary>
        /// The number of units making up this goods item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity Quantity { get; set; }

        /// <summary>
        /// A code signifying the treatment preference for this goods
        /// item according to international trading agreements.
        /// Preference Criterion is used in the following manner in
        /// the paper CO of another country (e.g.): A - The good is
        /// wholly obtained or produced entirely in the territory of
        /// one or more of the NAFTA countries as reference in
        /// Article 415. Note: The purchase of a good in the
        /// territory does not necessarily render it wholly obtained
        /// or produced . 
        /// If the good is an agricultural good, see also criterion F
        /// and Annex 703.2. (Reference: Article 401(a), 415).
        /// B - ... C - ... D - ... E - ... F - The good is an
        /// originating agricultural good under preference criterion
        /// A,B, or C above and is not subjected to quantitative
        /// restriction in the importing NAFTA country because....
        /// Thus, the column Preference Criterion will indicate
        /// either A, B, C,...
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PreferenceCriterionCode { get; set; }

        /// <summary>
        /// An identifier for a set of tariff codes required to specify a type of goods for customs, transport, statistical, or other regulatory purposes.
        /// Tariff code extensions (WCO ID 255)
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string RequiredCustomsID { get; set; }

        /// <summary>
        /// A code assigned by customs to signify the status of this goods item.
        /// Customs status of goods (WCO ID 094)
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CustomsStatusCode { get; set; }

        /// <summary>
        /// Quantity of the units in this goods item as required by customs for tariff, statistical, or fiscal purposes.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity CustomsTariffQuantity { get; set; }

        /// <summary>
        /// An indicator that this goods item has been classified for import by customs (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool CustomsImportClassifiedIndicator { get; set; }

        /// <summary>
        /// The number of units in the goods item to which charges apply.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity ChargeableQuantity { get; set; }

        /// <summary>
        /// The number of units in the goods item that may be returned.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity ReturnableQuantity { get; set; }

        /// <summary>
        /// An identifier for use in tracing this goods item, such as the EPC number used in RFID.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TraceID { get; set; }

        /// <summary>
        /// Product information relating to a goods item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Item> Item { get; set; }

        /// <summary>
        /// The transporting of a goods item in a unit of transport equipment (e.g., container).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<GoodsItemContainer> GoodsItemContainer { get; set; }

        /// <summary>
        /// A cost incurred by the shipper in moving goods, by whatever means, from one place to another under the terms of the contract of carriage. In addition to transport costs, this may include such elements as packing, documentation, loading, unloading, and insurance to the extent that they relate to the freight costs.
        /// Freight Costs
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<AllowanceCharge> FreightAllowanceCharge { get; set; }

        /// <summary>
        /// Information about an invoice line relating to this goods item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<InvoiceLine> InvoiceLine { get; set; }

        /// <summary>
        /// The temperature of the goods item.
        /// maximum, storage, minimum
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Temperature> Temperature { get; set; }

        /// <summary>
        /// A goods item contained in this goods item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<GoodsItem> ContainedGoodsItem { get; set; }

        /// <summary>
        /// The region in which the goods have been produced or manufactured, according to criteria laid down for the purposes of application of the customs tariff, or of quantitative restrictions, or of any other measure related to trade.
        /// Region of origin (WCO ID 066)
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Address OriginAddress { get; set; }

        /// <summary>
        /// The delivery of this goods item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Delivery Delivery { get; set; }

        /// <summary>
        /// The pickup of this goods item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Pickup Pickup { get; set; }

        /// <summary>
        /// The despatch of this goods item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Despatch Despatch { get; set; }

        /// <summary>
        /// A measurable dimension (length, mass, weight, or volume) of this goods item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Dimension> MeasurementDimension { get; set; }

        /// <summary>
        /// A package containing this goods item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Package> ContainingPackage { get; set; }

        /// <summary>
        /// A reference to a shipping document associated with this goods item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DocumentReference ShipmentDocumentReference { get; set; }

        /// <summary>
        /// Information about minimum temperature.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Temperature MinimumTemperature { get; set; }

        /// <summary>
        /// Information about maximum temperature.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Temperature MaximumTemperature { get; set; }

        #endregion

    }

}