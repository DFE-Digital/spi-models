namespace Dfe.Spi.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A learning provider.
    /// </summary>
    public class LearningProvider : ModelsBase
    {
        /// <summary>
        /// Gets or sets the Academy Trust code of the entity.
        /// </summary>
        public string AcademyTrustCode { get; set; }

        /// <summary>
        /// Gets or sets the administrative ward code.
        /// </summary>
        public string AdministrativeWardCode { get; set; }

        /// <summary>
        /// Gets or sets the administrative ward name.
        /// </summary>
        public string AdministrativeWardName { get; set; }

        /// <summary>
        /// Gets or sets the admissions policy.
        /// </summary>
        public string AdmissionsPolicy { get; set; }

        /// <summary>
        /// Gets or sets the Boarders Code.
        /// TODO: Review name.
        /// </summary>
        public string BoardersCode { get; set; }

        /// <summary>
        /// Gets or sets the Boarders Name.
        /// TODO: Review name.
        /// </summary>
        public string BoardersName { get; set; }

        /// <summary>
        /// Gets or sets the Charities Commission number of the entity.
        /// </summary>
        public string CharitiesCommissionNumber { get; set; }

        /// <summary>
        /// Gets or sets the CloseDate of the entity.
        /// </summary>
        public DateTime? CloseDate { get; set; }

        /// <summary>
        /// Gets or sets the closing reason.
        /// </summary>
        public string ClosingReason { get; set; }

        /// <summary>
        /// Gets or sets the Companies House number of the entity.
        /// </summary>
        public string CompaniesHouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the DfE number of the entity.
        /// </summary>
        public string DfeNumber { get; set; }

        /// <summary>
        /// Gets or sets the Diocese Code.
        /// </summary>
        public string DioceseCode { get; set; }

        /// <summary>
        /// Gets or sets the Diocese Name.
        /// </summary>
        public string DioceseName { get; set; }

        /// <summary>
        /// Gets or sets the district administrative code.
        /// </summary>
        public string DistrictAdministrativeCode { get; set; }

        /// <summary>
        /// Gets or sets the district administrative name.
        /// </summary>
        public string DistrictAdministrativeName { get; set; }

        /// <summary>
        /// Gets or sets the <c>Easting</c> value.
        /// TODO: Review name.
        /// </summary>
        public string Easting { get; set; }

        /// <summary>
        /// Gets or sets the establishment number of the entity.
        /// </summary>
        public long? EstablishmentNumber { get; set; }

        /// <summary>
        /// Gets or sets the <c>FederationFlag</c> value.
        /// TODO: Review name.
        /// </summary>
        public string FederationFlag { get; set; }

        /// <summary>
        /// Gets or sets the further education type.
        /// </summary>
        public string FurtherEducationType { get; set; }

        /// <summary>
        /// Gets or sets the gender of entry.
        /// </summary>
        public string GenderOfEntry { get; set; }

        /// <summary>
        /// Gets or sets the <c>GORRegion</c>.
        /// TODO: Review name.
        /// </summary>
        public string GorRegion { get; set; }

        /// <summary>
        /// Gets or sets a set of <see cref="Governor" /> instances.
        /// </summary>
        public IEnumerable<Governor> Governors { get; set; }

        /// <summary>
        /// Gets or sets the <c>GSSLACode</c> value.
        /// TODO: Review name.
        /// </summary>
        public string GsslaCode { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the date of inspection.
        /// TODO: May or may not be a <see cref="DateTime" /> - remove this
        ///       to confirm.
        /// </summary>
        public DateTime? InspectionDate { get; set; }

        /// <summary>
        /// Gets or sets the inspectorate name.
        /// </summary>
        public string InspectorateName { get; set; }

        /// <summary>
        /// Gets or sets the inspectorate report.
        /// </summary>
        public string InspectorateReport { get; set; }

        /// <summary>
        /// Gets or sets the legal name of the entity.
        /// </summary>
        public string LegalName { get; set; }

        /// <summary>
        /// Gets or sets the local authority code.
        /// </summary>
        public string LocalAuthorityCode { get; set; }

        /// <summary>
        /// Gets or sets the local authority name.
        /// </summary>
        public string LocalAuthorityName { get; set; }

        /// <summary>
        /// Gets or sets the management group type.
        /// </summary>
        public string ManagementGroupType { get; set; }

        /// <summary>
        /// Gets or sets the <c>Northing</c> value.
        /// TODO: Review name.
        /// </summary>
        public string Northing { get; set; }

        /// <summary>
        /// Gets or sets Ofsted's last inspection.
        /// </summary>
        public string OfstedLastInspection { get; set; }

        /// <summary>
        /// Gets or sets the Ofsted rating.
        /// </summary>
        public string OfstedRating { get; set; }

        /// <summary>
        /// Gets or sets the OpenDate of the entity.
        /// </summary>
        public DateTime? OpenDate { get; set; }

        /// <summary>
        /// Gets or sets the opening reason.
        /// </summary>
        public string OpeningReason { get; set; }

        /// <summary>
        /// Gets or sets the percentage of pupils receiving free school meals.
        /// </summary>
        public string PercentageOfPupilsReceivingFreeSchoolMeals { get; set; }

        /// <summary>
        /// Gets or sets the phase of education.
        /// </summary>
        public string PhaseOfEducation { get; set; }

        /// <summary>
        /// Gets or sets the Postcode of the entity.
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or sets the previous establishment number of the entity.
        /// </summary>
        public long? PreviousEstablishmentNumber { get; set; }

        /// <summary>
        /// Gets or sets the previous local authority code.
        /// </summary>
        public string PreviousLocalAuthorityCode { get; set; }

        /// <summary>
        /// Gets or sets the previous local authority name.
        /// </summary>
        public string PreviousLocalAuthorityName { get; set; }

        /// <summary>
        /// Gets or sets the <c>RSCRegion</c> value.
        /// TODO: Review name.
        /// </summary>
        public string RscRegion { get; set; }

        /// <summary>
        /// Gets or sets the <c>Section41Approved</c> value.
        /// TODO: Review name.
        /// TODO: Type? This may be a bool.
        /// </summary>
        public string Section41Approved { get; set; }

        /// <summary>
        /// Gets or sets the Status of the entity.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the statutory low age.
        /// TODO: Review name.
        /// </summary>
        public string StatutoryLowAge { get; set; }

        /// <summary>
        /// Gets or sets the statutory high age.
        /// TODO: Review name.
        /// </summary>
        public string StatutoryHighAge { get; set; }

        /// <summary>
        /// Gets or sets the SubType of the entity.
        /// </summary>
        public string SubType { get; set; }

        /// <summary>
        /// Gets or sets the <c>SixthForm</c> value.
        /// TODO: Review name.
        /// </summary>
        public string SixthForm { get; set; }

        /// <summary>
        /// Gets or sets the <c>TeenMothers</c> value.
        /// TODO: Review name.
        /// </summary>
        public string TeenMothers { get; set; }

        /// <summary>
        /// Gets or sets the <c>TeenMothersPlaces</c> value.
        /// TODO: Review name.
        /// </summary>
        public long? TeenMothersPlaces { get; set; }

        /// <summary>
        /// Gets or sets the Type of the entity.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the updated date.
        /// TODO: May or may not be a <see cref="DateTime" /> - remove this
        ///       to confirm.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the UKPRN of the entity.
        /// </summary>
        public long? Ukprn { get; set; }

        /// <summary>
        /// Gets or sets the UPRN of the entity.
        /// </summary>
        public string Uprn { get; set; }

        /// <summary>
        /// Gets or sets the urban rural code.
        /// </summary>
        public string UrbanRuralCode { get; set; }

        /// <summary>
        /// Gets or sets the urban rural name.
        /// </summary>
        public string UrbanRuralName { get; set; }

        /// <summary>
        /// Gets or sets the URN of the entity.
        /// </summary>
        public long? Urn { get; set; }

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        public string Website { get; set; }
    }
}