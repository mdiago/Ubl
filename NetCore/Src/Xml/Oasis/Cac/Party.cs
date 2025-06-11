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
    /// A class to describe an organization, sub-organization, or individual fulfilling a role in a business process.    
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class Party
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An indicator that this party is "care of" (c/o) (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string MarkCareIndicator { get; set; }

        /// <summary>
        /// An indicator that this party is "for the attention of" (FAO) (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string MarkAttentionIndicator { get; set; }

        /// <summary>
        /// The Uniform Resource Identifier (URI) that identifies this party's web site; i.e., the web site's Uniform Resource Locator (URL).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string WebsiteURI { get; set; }

        /// <summary>
        /// An identifier for this party's logo.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string LogoReferenceID { get; set; }

        /// <summary>
        /// An identifier for the end point of the routing service (e.g., EAN Location Number, GLN).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string EndpointID { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string IndustryClassificationCode { get; set; }

        /// <summary>
        /// Identifiers for this party.
        /// </summary>
        [XmlArray("PartyIdentification", Namespace = Namespaces.NamespaceCac)]
        [XmlArrayItem("ID", Namespace = Namespaces.NamespaceCbc)]
        public string[] IDs { get; set; }

        /// <summary>
        /// Names for this party.
        /// </summary>
        [XmlArray("PartyName", Namespace = Namespaces.NamespaceCac)]
        [XmlArrayItem("Name", Namespace = Namespaces.NamespaceCbc)]
        public string[] Names { get; set; }

        /// <summary>
        /// The language associated with this party.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Language Language { get; set; }

        /// <summary>
        /// The party's postal address.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Address PostalAddress { get; set; }

        /// <summary>
        /// The physical location of this party.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location PhysicalLocation { get; set; }

        /// <summary>
        /// A tax scheme applying to this party.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<PartyTaxScheme> PartyTaxScheme { get; set; }

        /// <summary>
        /// A description of this party as a legal entity.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<PartyLegalEntity> PartyLegalEntity { get; set; }

        /// <summary>
        /// The primary contact for this party.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Contact Contact { get; set; }

        /// <summary>
        /// A person associated with this party.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Person> Person { get; set; }

        /// <summary>
        /// A party who acts as an agent for this party.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party AgentParty { get; set; }

        /// <summary>
        /// A party providing a service to this party.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<ServiceProviderParty> ServiceProviderParty { get; set; }

        /// <summary>
        /// A power of attorney associated with this party.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<PowerOfAttorney> PowerOfAttorney { get; set; }

        /// <summary>
        /// The financial account associated with this party.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public FinancialAccount FinancialAccount { get; set; }

        /// <summary>
        /// An additional web site associated with this party (e.g. a satellite web site).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<WebSite> AdditionalWebSite { get; set; }

        /// <summary>
        /// A social media profile associated with this party.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<SocialMediaProfile> SocialMediaProfile { get; set; }

        #endregion

    }

}