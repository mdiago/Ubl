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
    /// A class to describe a person.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class Person
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// The name of the party as registered with the relevant legal authority.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// An identifier for the party as registered within a company registration scheme.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string FirstName { get; set; }

        /// <summary>
        /// The registration date of the CompanyID.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string FamilyName { get; set; }

        /// <summary>
        /// The date upon which a registration expires (e.g., registration for an import/export license).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Title { get; set; }

        /// <summary>
        /// The name of the party as registered with the relevant legal authority.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string MiddleName { get; set; }

        /// <summary>
        /// An identifier for the party as registered within a company registration scheme.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string OtherName { get; set; }

        /// <summary>
        /// The registration date of the CompanyID.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string NameSuffix { get; set; }

        /// <summary>
        /// The date upon which a registration expires (e.g., registration for an import/export license).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string JobTitle { get; set; }

        /// <summary>
        /// The name of the party as registered with the relevant legal authority.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string NationalityID { get; set; }

        /// <summary>
        /// An identifier for the party as registered within a company registration scheme.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string GenderCode { get; set; }

        /// <summary>
        /// The registration date of the CompanyID.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string BirthDate { get; set; }

        /// <summary>
        /// The date upon which a registration expires (e.g., registration for an import/export license).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string BirthplaceName { get; set; }

        /// <summary>
        /// The date upon which a registration expires (e.g., registration for an import/export license).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string OrganizationDepartment { get; set; }

        /// <summary>
        /// The date upon which a registration expires (e.g., registration for an import/export license).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string RoleCode { get; set; }

        /// <summary>
        /// The country of the person's citizenship.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Country CitizenshipCountry { get; set; }

        /// <summary>
        /// Contact information for this person.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Contact Contact { get; set; }

        /// <summary>
        /// The financial account associated with this person.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public FinancialAccount FinancialAccount { get; set; }

        /// <summary>
        /// A reference to a document that can precisely identify this person (e.g., a driver's license).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DocumentReference IdentityDocumentReference { get; set; }

        /// <summary>
        /// This person's address of residence.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Address ResidenceAddress { get; set; }

        #endregion

    }

}
