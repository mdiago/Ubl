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
using System.Xml.Serialization;

namespace Ubl.Xml.Oasis.Cac
{

    /// <summary>
    /// A class to describe a financial account.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class FinancialAccount
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// The identifier for this financial account; the bank account number.
        /// SWIFT(BIC) and IBAN are defined in ISO 9362 and ISO 13616.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// The name of this financial account.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Name { get; set; }

        /// <summary>
        /// An alias for the name of this financial account, to be used in place of the actual account name for security reasons.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string AliasName { get; set; }

        /// <summary>
        /// A code signifying the type of this financial account.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string AccountTypeCode { get; set; }

        /// <summary>
        /// A code signifying the format of this financial account.
        /// ISO20022 Clearing System Identification Code
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string AccountFormatCode { get; set; }

        /// <summary>
        /// A code signifying the currency in which this financial account is held.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Free-form text applying to the Payment for the owner of this account.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] PaymentNote { get; set; }

        /// <summary>
        /// The branch of the financial institution associated with this financial account.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Branch FinancialInstitutionBranch { get; set; }

        /// <summary>
        /// The country in which the holder of the financial account is domiciled.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Country Country { get; set; }

        #endregion

    }

}