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
    /// A class to define a line in a Receipt Advice.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class ReceiptLine
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this receipt line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// A universally unique identifier for this receipt line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string UUID { get; set; }

        /// <summary>
        /// <para> Free-form text conveying information that is not contained explicitly in other structures.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Note { get; set; }

        /// <summary>
        /// The quantity received.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity ReceivedQuantity { get; set; }

        /// <summary>
        /// The quantity received short; the difference between the quantity reported despatched and the quantity actually received.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity ShortQuantity { get; set; }

        /// <summary>
        /// A code signifying the action that the delivery party wishes the despatch party to take as the result of a shortage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ShortageActionCode { get; set; }

        /// <summary>
        /// The quantity rejected.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity RejectedQuantity { get; set; }

        /// <summary>
        /// The reason for a rejection, expressed as a code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string RejectReasonCode { get; set; }

        /// <summary>
        /// <para> The reason for a rejection, expressed as text.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] RejectReason { get; set; }

        /// <summary>
        /// A code signifying the action that the delivery party wishes the despatch party to take as the result of a rejection.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string RejectActionCode { get; set; }

        /// <summary>
        /// A code signifying the type of a discrepancy in quantity.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string QuantityDiscrepancyCode { get; set; }

        /// <summary>
        /// The quantity over-supplied, i.e., the quantity over and above the quantity ordered.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity OversupplyQuantity { get; set; }

        /// <summary>
        /// The date on which the goods or services were received.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime ReceivedDate { get; set; }

        /// <summary>
        /// A complaint about the timing of delivery, expressed as a code
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TimingComplaintCode { get; set; }

        /// <summary>
        /// A complaint about the timing of delivery, expressed as text.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TimingComplaint { get; set; }

        /// <summary>
        /// A reference to the order line associated with this receipt line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public OrderLineReference OrderLineReference { get; set; }

        /// <summary>
        /// A reference to the order line associated with this receipt line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<LineReference> DespatchLineReference { get; set; }

        /// <summary>
        /// A reference to a document associated with this receipt line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<DocumentReference> DocumentReference { get; set; }

        /// <summary>
        /// An item associated with this receipt line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Item> Item { get; set; }

        /// <summary>
        /// A shipment associated with this receipt line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Shipment> Shipment { get; set; }

        #endregion

    }

}