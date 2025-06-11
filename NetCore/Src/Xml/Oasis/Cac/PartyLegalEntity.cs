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

namespace Ubl.Xml.Oasis.Cac
{

    /// <summary>
    /// A class to describe a party as a legal entity.    
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class PartyLegalEntity
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// The name of the party as registered with the relevant legal authority.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string RegistrationName { get; set; }

        /// <summary>
        /// An identifier for the party as registered within a company registration scheme.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CompanyID { get; set; }

        /// <summary>
        /// The registration date of the CompanyID.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// The date upon which a registration expires (e.g., registration for an import/export license).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string RegistrationExpirationDate { get; set; }

        /// <summary>
        /// A code signifying the party's legal status.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CompanyLegalFormCode { get; set; }

        /// <summary>
        /// The company legal status, expressed as a text.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CompanyLegalForm { get; set; }

        /// <summary>
        /// An indicator that the company is owned and controlled by one person (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool SoleProprietorshipIndicator { get; set; }

        /// <summary>
        /// A code signifying the party's liquidation status.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CompanyLiquidationStatusCode { get; set; }

        /// <summary>
        /// The number of shares in the capital stock of a corporation.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CorporateStockAmount { get; set; }

        /// <summary>
        /// An indicator that all shares of corporate stock have been paid by shareholders (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool FullyPaidSharesIndicator { get; set; }

        /// <summary>
        /// The registered address of the party within a corporate registration scheme.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Address RegistrationAddress { get; set; }

        /// <summary>
        /// The corporate registration scheme used to register the party.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public CorporateRegistrationScheme CorporateRegistrationScheme { get; set; }

        /// <summary>
        /// 	The head office of the legal entity
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party HeadOfficeParty { get; set; }

        /// <summary>
        /// A party owning shares in this legal entity.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Party> ShareholderParty { get; set; }

        #endregion

    }
}
