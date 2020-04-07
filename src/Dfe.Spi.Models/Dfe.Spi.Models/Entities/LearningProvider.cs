namespace Dfe.Spi.Models.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A learning provider.
    /// </summary>
    public class LearningProvider : EntityBase
    {
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
        /// </summary>
        public string BoardersCode { get; set; }

        /// <summary>
        /// Gets or sets the Boarders Name.
        /// </summary>
        public string BoardersName { get; set; }

        /// <summary>
        /// Gets or sets the <c>PruChildcareFacilities</c> value.
        /// </summary>
        public string PruChildcareFacilities { get; set; }

        /// <summary>
        /// Gets or sets the CloseDate of the entity.
        /// </summary>
        public DateTime? CloseDate { get; set; }

        /// <summary>
        /// Gets or sets Ofsted's last inspection.
        /// </summary>
        public DateTime? OfstedLastInspection { get; set; }

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
        /// </summary>
        public long? Easting { get; set; }

        /// <summary>
        /// Gets or sets the <c>PruEdbProvision</c> value.
        /// </summary>
        public string PruEdbProvision { get; set; }

        /// <summary>
        /// Gets or sets the <c>PruEducatedByOtherProviders</c> value.
        /// </summary>
        public string PruEducatedByOtherProviders { get; set; }

        /// <summary>
        /// Gets or sets the establishment number of the entity.
        /// </summary>
        public long? EstablishmentNumber { get; set; }

        /// <summary>
        /// Gets or sets the Status of the entity.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the type code.
        /// </summary>
        public string TypeCode { get; set; }

        /// <summary>
        /// Gets or sets the type name.
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the SubType code.
        /// </summary>
        public string SubTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the SubType name.
        /// </summary>
        public string SubTypeName { get; set; }

        /// <summary>
        /// Gets or sets the further education type.
        /// </summary>
        public string FurtherEducationType { get; set; }

        /// <summary>
        /// Gets or sets the gender of pupils code.
        /// </summary>
        public string GenderOfPupilsCode { get; set; }

        /// <summary>
        /// Gets or sets the gender of pupils name.
        /// </summary>
        public string GenderOfPupilsName { get; set; }

        /// <summary>
        /// Gets or sets the Government Office Region code.
        /// </summary>
        public string GovernmentOfficeRegionCode { get; set; }

        /// <summary>
        /// Gets or sets the Government Office Region code.
        /// </summary>
        public string GovernmentOfficeRegionName { get; set; }

        /// <summary>
        /// Gets or sets the Government Statistical Service Local Authority
        /// Code.
        /// </summary>
        public string GovernmentStatisticalServiceLocalAuthorityCode { get; set; }

        /// <summary>
        /// Gets or sets the inspectorate code.
        /// </summary>
        public string InspectorateCode { get; set; }

        /// <summary>
        /// Gets or sets the inspectorate name.
        /// </summary>
        public string InspectorateName { get; set; }

        /// <summary>
        /// Gets or sets the local authority code.
        /// </summary>
        public string LocalAuthorityCode { get; set; }

        /// <summary>
        /// Gets or sets the local authority name.
        /// </summary>
        public string LocalAuthorityName { get; set; }

        /// <summary>
        /// Gets or sets the last changed date.
        /// </summary>
        public DateTime? LastChangedDate { get; set; }

        /// <summary>
        /// Gets or sets the Middle Layer Super Output Area (or "MSOA") code.
        /// </summary>
        public string MiddleLayerSuperOutputAreaCode { get; set; }

        /// <summary>
        /// Gets or sets the Middle Layer Super Output Area (or "MSOA") name.
        /// </summary>
        public string MiddleLayerSuperOutputAreaName { get; set; }

        /// <summary>
        /// Gets or sets the <c>Northing</c> value.
        /// </summary>
        public long? Northing { get; set; }

        /// <summary>
        /// Gets or sets the number of pupils.
        /// </summary>
        public long? NumberOfPupils { get; set; }

        /// <summary>
        /// Gets or sets the sixth form status.
        /// </summary>
        public string SixthFormStatusCode { get; set; }

        /// <summary>
        /// Gets or sets the sixth form status.
        /// </summary>
        public string SixthFormStatus { get; set; }

        /// <summary>
        /// Gets or sets the Ofsted rating.
        /// </summary>
        public string OfstedRating { get; set; }

        /// <summary>
        /// Gets or sets the OpenDate of the entity.
        /// </summary>
        public DateTime? OpenDate { get; set; }

        /// <summary>
        /// Gets or sets the Parliamentary Constituency code.
        /// </summary>
        public string ParliamentaryConstituencyCode { get; set; }

        /// <summary>
        /// Gets or sets the Parliamentary Constituency name.
        /// </summary>
        public string ParliamentaryConstituencyName { get; set; }

        /// <summary>
        /// Gets or sets the percentage of pupils receiving free school meals.
        /// </summary>
        public decimal? PercentageOfPupilsReceivingFreeSchoolMeals { get; set; }

        /// <summary>
        /// Gets or sets the phase of education code.
        /// </summary>
        public string PhaseOfEducationCode { get; set; }

        /// <summary>
        /// Gets or sets the phase of education name.
        /// </summary>
        public string PhaseOfEducationName { get; set; }

        /// <summary>
        /// Gets or sets the <c>PruNumberOfPlaces</c> value.
        /// </summary>
        public int? PruNumberOfPlaces { get; set; }

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
        /// Gets or sets the closing reason code.
        /// </summary>
        public string ClosingReasonCode { get; set; }

        /// <summary>
        /// Gets or sets the closing reason name.
        /// </summary>
        public string ClosingReasonName { get; set; }

        /// <summary>
        /// Gets or sets the opening reason code.
        /// </summary>
        public string OpeningReasonCode { get; set; }

        /// <summary>
        /// Gets or sets the opening reason name.
        /// </summary>
        public string OpeningReasonName { get; set; }

        /// <summary>
        /// Gets or sets the religious ethos.
        /// </summary>
        public string ReligiousEthos { get; set; }

        /// <summary>
        /// Gets or sets the resourced provision capacity.
        /// </summary>
        public long? ResourcedProvisionCapacity { get; set; }

        /// <summary>
        /// Gets or sets the resourced provision number on roll.
        /// </summary>
        public long? ResourcedProvisionNumberOnRoll { get; set; }

        /// <summary>
        /// Gets or sets the regional schools commissioner region.
        /// </summary>
        public string RegionalSchoolsCommissionerRegion { get; set; }

        /// <summary>
        /// Gets or sets the school capacity.
        /// </summary>
        public long? SchoolCapacity { get; set; }

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets the <c>Section41Approved</c> value.
        /// </summary>
        public string Section41Approved { get; set; }

        /// <summary>
        /// Gets or sets the special classes code.
        /// </summary>
        public string SpecialClassesCode { get; set; }

        /// <summary>
        /// Gets or sets the special classes name.
        /// </summary>
        public string SpecialClassesName { get; set; }

        /// <summary>
        /// Gets or sets the statutory high age.
        /// </summary>
        public long? HighestAge { get; set; }

        /// <summary>
        /// Gets or sets the statutory low age.
        /// </summary>
        public long? LowestAge { get; set; }

        /// <summary>
        /// Gets or sets the <c>TeenMothersProvision</c> value.
        /// </summary>
        public string TeenMothersProvision { get; set; }

        /// <summary>
        /// Gets or sets the <c>TeenMothersPlaces</c> value.
        /// </summary>
        public long? TeenMothersPlaces { get; set; }

        /// <summary>
        /// Gets or sets the telephone number.
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the trust code of the entity.
        /// </summary>
        public string TrustCode { get; set; }

        /// <summary>
        /// Gets or sets the trust name of the entity.
        /// </summary>
        public string TrustName { get; set; }

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
        /// Gets or sets the management group.
        /// </summary>
        public ManagementGroup ManagementGroup { get; set; }



        /// <summary>
        /// Gets or sets the Charities Commission number of the entity.
        /// </summary>
        public string CharitiesCommissionNumber { get; set; }

        /// <summary>
        /// Gets or sets the Companies House number of the entity.
        /// </summary>
        public string CompaniesHouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the DfE number of the entity.
        /// </summary>
        public string DfeNumber { get; set; }

        /// <summary>
        /// Gets or sets the Lower Layer Super Output Area (or "LSOA").
        /// </summary>
        public string LowerLayerSuperOutputArea { get; set; }

        /// <summary>
        /// Gets or sets a set of <see cref="Governor" /> instances.
        /// </summary>
        public IEnumerable<Governor> Governors { get; set; }

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
        /// Gets or sets the inspectorate report.
        /// </summary>
        public string InspectorateReport { get; set; }

        /// <summary>
        /// Gets or sets the legal name of the entity.
        /// </summary>
        public string LegalName { get; set; }

        /// <summary>
        /// Gets or sets the management group type.
        /// </summary>
        public string ManagementGroupType { get; set; }

        /// <summary>
        /// Gets or sets the Federations.
        /// </summary>
        public string Federations { get; set; }

        /// <summary>
        /// Gets or sets the contact email.
        /// </summary>
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Address" />.
        /// </summary>
        public Address Address { get; set; }
    }
}