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
    /// A class to describe an item of trade. It includes a generic description applicable to all examples of the item together with optional subsidiary descriptions of any number of actual instances of the type.
    /// article, product, goods item
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class Item
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// <para> Text describing this item.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Description { get; set; }

        /// <summary>
        /// The unit packaging quantity; the number of subunits making up this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity PackQuantity { get; set; }

        /// <summary>
        /// The number of items in a pack of this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal PackSizeNumeric { get; set; }

        /// <summary>
        /// An indicator that this item was ordered from a catalogue (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool CatalogueIndicator { get; set; }

        /// <summary>
        /// A short name optionally given to this item, such as a name from a catalogue, as distinct from a description.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Name { get; set; }

        /// <summary>
        /// An indication that the transported item, as delivered, is subject to an international regulation concerning the carriage of dangerous goods (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool HazardousRiskIndicator { get; set; }

        /// <summary>
        /// <para> Further details regarding this item (e.g., the URL of a relevant web page).</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] AdditionalInformation { get; set; }

        /// <summary>
        /// <para> A keyword (search string) for this item, assigned by the seller party. Can also be a synonym for the name of the item.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Keyword { get; set; }

        /// <summary>
        /// <para> A brand name of this item.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] BrandName { get; set; }

        /// <summary>
        /// <para> A model name of this item.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] ModelName { get; set; }

        /// <summary>
        /// Identifying information for this item, assigned by the buyer.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public ItemIdentification BuyersItemIdentification { get; set; }

        /// <summary>
        /// Identifying information for this item, assigned by the seller.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public ItemIdentification SellersItemIdentification { get; set; }

        /// <summary>
        /// Identifying information for this item, assigned by the manufacturer.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<ItemIdentification> ManufacturersItemIdentification { get; set; }

        /// <summary>
        /// Identifying information for this item, assigned according to a standard system.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public ItemIdentification StandardItemIdentification { get; set; }

        /// <summary>
        /// Identifying information for this item, assigned according to a cataloguing system.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public ItemIdentification CatalogueItemIdentification { get; set; }

        /// <summary>
        /// An additional identifier for this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<ItemIdentification> AdditionalItemIdentification { get; set; }

        /// <summary>
        /// A reference to the catalogue in which this item appears.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DocumentReference CatalogueDocumentReference { get; set; }

        /// <summary>
        /// A reference to a specification document for this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<DocumentReference> ItemSpecificationDocumentReference { get; set; }

        /// <summary>
        /// The country of origin of this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Country OriginCountry { get; set; }

        /// <summary>
        /// A classification of this item according to a specific system for classifying commodities.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<CommodityClassification> CommodityClassification { get; set; }

        /// <summary>
        /// A set of sales conditions applying to this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TransactionConditions> TransactionConditions { get; set; }

        /// <summary>
        /// Information pertaining to this item as a hazardous item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<HazardousItem> HazardousItem { get; set; }

        /// <summary>
        /// A tax category applicable to this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TaxCategory> ClassifiedTaxCategory { get; set; }

        /// <summary>
        /// An additional property of this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<ItemProperty> AdditionalItemProperty { get; set; }

        /// <summary>
        /// The manufacturer of this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Party> ManufacturerParty { get; set; }

        /// <summary>
        /// The party responsible for specification of this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party InformationContentProviderParty { get; set; }

        /// <summary>
        /// A region (not country) of origin of this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Address> OriginAddress { get; set; }

        /// <summary>
        /// A trackable, unique instantiation of this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<ItemInstance> ItemInstance { get; set; }

        /// <summary>
        /// A certificate associated with this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Certificate> Certificate { get; set; }

        /// <summary>
        /// One of the measurable dimensions (length, mass, weight, or volume) of this item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Dimension> Dimension { get; set; }

        #endregion

    }

}