namespace Dfe.Spi.Models.Entities
{
    using System;

    /// <summary>
    /// A learning provider.
    /// </summary>
    public class LearningProvider : EntityBase
    {
        /// <summary>
        /// Gets or sets the administrative ward code.
        /// Example: "E05005444".
        /// </summary>
        public string AdministrativeWardCode { get; set; }

        /// <summary>
        /// Gets or sets the administrative ward name.
        /// Example: "Quorn and Mountsorrel Castle".
        /// </summary>
        public string AdministrativeWardName { get; set; }

        /// <summary>
        /// Gets or sets the admissions policy (code).
        /// ** Enumerable type! **
        /// Example: "Selective", "Non Selective", "Not Applicable",
        ///          "Not Recorded".
        /// </summary>
        public string AdmissionsPolicy { get; set; }

        /// <summary>
        /// Gets or sets the Boarders Code.
        /// Example: 9.
        /// </summary>
        public long? BoardersCode { get; set; }

        /// <summary>
        /// Gets or sets the Boarders Name.
        /// Example: "No boarders".
        /// </summary>
        public string BoardersName { get; set; }

        /// <summary>
        /// Gets or sets the <c>PruChildcareFacilitiesName</c> value.
        /// Example: "Not applicable".
        /// </summary>
        public string PruChildcareFacilitiesName { get; set; }

        /// <summary>
        /// Gets or sets the CloseDate of the entity.
        /// Example: "2011-10-31T00:00:00Z".
        /// </summary>
        public DateTime? CloseDate { get; set; }

        /// <summary>
        /// Gets or sets Ofsted's last inspection.
        /// Example: "2018-01-11T00:00:00Z".
        /// </summary>
        public DateTime? OfstedLastInspection { get; set; }

        /// <summary>
        /// Gets or sets the Diocese Code.
        /// Example: "CE19".
        /// </summary>
        public string DioceseCode { get; set; }

        /// <summary>
        /// Gets or sets the Diocese Name.
        /// Example: "Diocese of Leicester".
        /// </summary>
        public string DioceseName { get; set; }

        /// <summary>
        /// Gets or sets the district administrative code.
        /// Example: "E07000130".
        /// </summary>
        public string DistrictAdministrativeCode { get; set; }

        /// <summary>
        /// Gets or sets the district administrative name.
        /// Example: "Charnwood".
        /// </summary>
        public string DistrictAdministrativeName { get; set; }

        /// <summary>
        /// Gets or sets the <c>Easting</c> value.
        /// Example: 456697.
        /// </summary>
        public long? Easting { get; set; }

        /// <summary>
        /// Gets or sets the <c>PruEbdProvisionCode</c> value.
        /// Example: 0.
        /// </summary>
        public long? PruEbdProvisionCode { get; set; }

        /// <summary>
        /// Gets or sets the <c>PruEbdProvisionName</c> value.
        /// Example: "Not applicable".
        /// </summary>
        public string PruEbdProvisionName { get; set; }

        /// <summary>
        /// Gets or sets the <c>PruEducatedByOtherProvidersCode</c> value.
        /// Example: 0.
        /// </summary>
        public long? PruEducatedByOtherProvidersCode { get; set; }

        /// <summary>
        /// Gets or sets the <c>PruEducatedByOtherProvidersName</c> value.
        /// Example: "Not applicable".
        /// </summary>
        public string PruEducatedByOtherProvidersName { get; set; }

        /// <summary>
        /// Gets or sets the establishment number of the entity.
        /// Example: 3330.
        /// </summary>
        public long? EstablishmentNumber { get; set; }

        /// <summary>
        /// Gets or sets the Status of the entity.
        /// ** Enumerable type! **
        /// Example: "Open", "Closed", "Opening", "Closing", "Archived".
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the type code.
        /// ** Enumerable type! **
        /// Example: See translations.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the SubType code.
        /// ** Enumerable type! **
        /// Example: See translations.
        /// </summary>
        public string SubType { get; set; }

        /// <summary>
        /// Gets or sets the further education type.
        /// Example: "Not applicable".
        /// </summary>-
        public string FurtherEducationTypeName { get; set; }

        /// <summary>
        /// Gets or sets the gender of pupils code.
        /// Example: 3.
        /// </summary>
        public long? GenderOfPupilsCode { get; set; }

        /// <summary>
        /// Gets or sets the gender of pupils name.
        /// Example: "Mixed".
        /// </summary>
        public string GenderOfPupilsName { get; set; }

        /// <summary>
        /// Gets or sets the Government Office Region code.
        /// Example: "E".
        /// </summary>
        public string GovernmentOfficeRegionCode { get; set; }

        /// <summary>
        /// Gets or sets the Government Office Region name.
        /// Example: "East Midlands".
        /// </summary>
        public string GovernmentOfficeRegionName { get; set; }

        /// <summary>
        /// Gets or sets the Government Statistical Service Local Authority
        /// Code name.
        /// Example: "E10000018".
        /// </summary>
        public string GovernmentStatisticalServiceLocalAuthorityCodeName { get; set; }

        /// <summary>
        /// Gets or sets the inspectorate code.
        /// Example: 4.
        /// </summary>
        public long? InspectorateCode { get; set; }

        /// <summary>
        /// Gets or sets the inspectorate name.
        /// Example: "Unknown".
        /// </summary>
        public string InspectorateName { get; set; }

        /// <summary>
        /// Gets or sets the local authority code.
        /// Example: 855.
        /// Note: Although numerical, and could probably be an int, this is
        ///       being left as a string due to potential knock-on effects.
        /// </summary>
        public string LocalAuthorityCode { get; set; }

        /// <summary>
        /// Gets or sets the local authority name.
        /// Example: "Leicestershire".
        /// </summary>
        public string LocalAuthorityName { get; set; }

        /// <summary>
        /// Gets or sets the last changed date.
        /// Example: "2018-11-14T00:00:00Z".
        /// </summary>
        public DateTime? LastChangedDate { get; set; }

        /// <summary>
        /// Gets or sets the Middle Layer Super Output Area (or "MSOA") code.
        /// Example: "E02005356".
        /// </summary>
        public string MiddleLayerSuperOutputAreaCode { get; set; }

        /// <summary>
        /// Gets or sets the Middle Layer Super Output Area (or "MSOA") name.
        /// Example: "Charnwood 012".
        /// </summary>
        public string MiddleLayerSuperOutputAreaName { get; set; }

        /// <summary>
        /// Gets or sets the <c>Northing</c> value.
        /// Example: 316708.
        /// </summary>
        public long? Northing { get; set; }

        /// <summary>
        /// Gets or sets the number of pupils.
        /// Example: NULL, 181.
        /// </summary>
        public long? NumberOfPupils { get; set; }

        /// <summary>
        /// Gets or sets the sixth form status code.
        /// Example: 2.
        /// </summary>
        public long? SixthFormStatusCode { get; set; }

        /// <summary>
        /// Gets or sets the sixth form status name.
        /// Example: "Does not have a sixth form".
        /// </summary>
        public string SixthFormStatusName { get; set; }

        /// <summary>
        /// Gets or sets the Ofsted rating.
        /// Example: "Requires improvement".
        /// </summary>
        public string OfstedRatingName { get; set; }

        /// <summary>
        /// Gets or sets the OpenDate of the entity.
        /// Example: NULL, "2012-02-01T00:00:00Z".
        /// </summary>
        public DateTime? OpenDate { get; set; }

        /// <summary>
        /// Gets or sets the Parliamentary Constituency code.
        /// Example: "E14000625".
        /// </summary>
        public string ParliamentaryConstituencyCode { get; set; }

        /// <summary>
        /// Gets or sets the Parliamentary Constituency name.
        /// Example: "Charnwood".
        /// </summary>
        public string ParliamentaryConstituencyName { get; set; }

        /// <summary>
        /// Gets or sets the percentage of pupils receiving free school meals.
        /// Example: 7.5.
        /// </summary>
        public decimal? PercentageOfPupilsReceivingFreeSchoolMeals { get; set; }

        /// <summary>
        /// Gets or sets the phase of education code.
        /// Example: 4.
        /// </summary>
        public long? PhaseOfEducationCode { get; set; }

        /// <summary>
        /// Gets or sets the phase of education name.
        /// Example: "Secondary".
        /// </summary>
        public string PhaseOfEducationName { get; set; }

        /// <summary>
        /// Gets or sets the <c>PruNumberOfPlaces</c> value.
        /// Note: Couldn't find any non-null examples!
        /// Example: NULL.
        /// </summary>
        public long? PruNumberOfPlaces { get; set; }

        /// <summary>
        /// Gets or sets the Postcode of the entity.
        /// Example: "LE12 8DX".
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or sets the previous establishment number of the entity.
        /// Note: Couldn't find any non-null examples!
        /// Example: NULL.
        /// </summary>
        public long? PreviousEstablishmentNumber { get; set; }

        /// <summary>
        /// Gets or sets the closing reason code.
        /// Example: 10.
        /// </summary>
        public long? ClosingReasonCode { get; set; }

        /// <summary>
        /// Gets or sets the closing reason name.
        /// Example: "Academy Converter".
        /// </summary>
        public string ClosingReasonName { get; set; }

        /// <summary>
        /// Gets or sets the opening reason code.
        /// Example: 00.
        /// </summary>
        public long? OpeningReasonCode { get; set; }

        /// <summary>
        /// Gets or sets the opening reason name.
        /// Example: "Not applicable".
        /// </summary>
        public string OpeningReasonName { get; set; }

        /// <summary>
        /// Gets or sets the religious ethos code.
        /// Example: 00.
        /// </summary>
        public long? ReligiousEthosCode { get; set; }

        /// <summary>
        /// Gets or sets the religious ethos name.
        /// Example: "Does not apply".
        /// </summary>
        public string ReligiousEthosName { get; set; }

        /// <summary>
        /// Gets or sets the resourced provision capacity.
        /// Note: Couldn't find any non-null examples!
        /// Example: NULL.
        /// </summary>
        public long? ResourcedProvisionCapacity { get; set; }

        /// <summary>
        /// Gets or sets the resourced provision number on roll.
        /// Note: Couldn't find any non-null examples!
        /// Example: NULL.
        /// </summary>
        public long? ResourcedProvisionNumberOnRoll { get; set; }

        /// <summary>
        /// Gets or sets the regional schools commissioner region name.
        /// Example: 1.
        /// </summary>
        public long? RegionalSchoolsCommissionerRegionCode { get; set; }

        /// <summary>
        /// Gets or sets the regional schools commissioner region name.
        /// Example: "East Midlands and the Humber".
        /// </summary>
        public string RegionalSchoolsCommissionerRegionName { get; set; }

        /// <summary>
        /// Gets or sets the school capacity.
        /// Example: 771.
        /// </summary>
        public long? SchoolCapacity { get; set; }

        /// <summary>
        /// Gets or sets the website.
        /// Example: "www.stonehill.leics.sch.uk".
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets the <c>Section41ApprovedCode</c> value.
        /// Example: 3.
        /// </summary>
        public long? Section41ApprovedCode { get; set; }

        /// <summary>
        /// Gets or sets the <c>Section41ApprovedName</c> value.
        /// Example: "Not applicable".
        /// </summary>
        public string Section41ApprovedName { get; set; }

        /// <summary>
        /// Gets or sets the special classes code.
        /// Example: 1.
        /// </summary>
        public long? SpecialClassesCode { get; set; }

        /// <summary>
        /// Gets or sets the special classes name.
        /// Example: "Has Special Classes".
        /// </summary>
        public string SpecialClassesName { get; set; }

        /// <summary>
        /// Gets or sets the statutory high age.
        /// Example: 14.
        /// </summary>
        public long? HighestAge { get; set; }

        /// <summary>
        /// Gets or sets the statutory low age.
        /// Example: 11.
        /// </summary>
        public long? LowestAge { get; set; }

        /// <summary>
        /// Gets or sets the <c>TeenageMotherProvisionCode</c> value.
        /// Example: 0.
        /// </summary>
        public long? TeenageMotherProvisionCode { get; set; }

        /// <summary>
        /// Gets or sets the <c>TeenageMotherProvisionName</c> value.
        /// Example: "Not applicable".
        /// </summary>
        public string TeenageMotherProvisionName { get; set; }

        /// <summary>
        /// Gets or sets the <c>TeenageMotherPlaces</c> value.
        /// Note: Couldn't find any non-null examples!
        /// Example: NULL.
        /// </summary>
        public long? TeenageMotherPlaces { get; set; }

        /// <summary>
        /// Gets or sets the telephone number.
        /// Example: "01162673384".
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the academy trust code of the entity.
        /// A nullable code-name pair.
        /// Note: Leaving value as string, as to not create an integration
        ///       knock-on effect.
        /// Example: 3760.
        /// </summary>
        public string AcademyTrustCode { get; set; }

        /// <summary>
        /// Gets or sets the academy trust name of the entity.
        /// Example: "LIONHEART ACADEMIES TRUST".
        /// </summary>
        public string AcademyTrustName { get; set; }

        /// <summary>
        /// Gets or sets the UKPRN of the entity.
        /// Example: 10036047.
        /// </summary>
        public long? Ukprn { get; set; }

        /// <summary>
        /// Gets or sets the UPRN of the entity.
        /// Example: "100032070570".
        /// </summary>
        public string Uprn { get; set; }

        /// <summary>
        /// Gets or sets the urban rural code.
        /// Example: "D1".
        /// </summary>
        public string UrbanRuralCode { get; set; }

        /// <summary>
        /// Gets or sets the urban rural name.
        /// Example: "Rural town and fringe".
        /// </summary>
        public string UrbanRuralName { get; set; }

        /// <summary>
        /// Gets or sets the URN of the entity.
        /// Example: 137828.
        /// </summary>
        public long? Urn { get; set; }

        /// <summary>
        /// Gets or sets the management group.
        /// </summary>
        public ManagementGroup ManagementGroup { get; set; }

        /// <summary>
        /// Gets or sets the Companies House number of the entity.
        /// Note: does not appear to originate from GIAS.
        /// </summary>
        public string CompaniesHouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the Charities Commission number of the entity.
        /// Note: does not appear to originate from GIAS.
        /// </summary>
        public string CharitiesCommissionNumber { get; set; }

        /// <summary>
        /// Gets or sets the DfE number of the entity.
        /// Note: aggregate value.
        /// </summary>
        public string DfeNumber { get; set; }

        /// <summary>
        /// Gets or sets the Lower Layer Super Output Area (or "LSOA") code.
        /// Example: "E01025734".
        /// </summary>
        public string LowerLayerSuperOutputAreaCode { get; set; }

        /// <summary>
        /// Gets or sets the Lower Layer Super Output Area (or "LSOA") name.
        /// Example: "Charnwood 012C".
        /// </summary>
        public string LowerLayerSuperOutputAreaName { get; set; }

        /// <summary>
        /// Gets or sets the date of inspection.
        /// Note: Couldn't find any non-null examples!
        /// Example: NULL.
        /// </summary>
        public DateTime? InspectionDate { get; set; }

        /// <summary>
        /// Gets or sets the inspectorate report.
        /// Note: Couldn't find any non-null examples!
        /// Example: NULL.
        /// </summary>
        public string InspectorateReport { get; set; }

        /// <summary>
        /// Gets or sets the legal name of the entity.
        /// Note: Not GIAS, UKRLP.
        /// Example: "RICHARD HILL CHURCH OF ENGLAND PRIMARY SCHOOL".
        /// </summary>
        public string LegalName { get; set; }

        /// <summary>
        /// Gets or sets the contact email.
        /// Note: Could not find any non-null examples!
        /// Example: NULL.
        /// </summary>
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or sets the first address line.
        /// Example: "Anstey Lane".
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the second address line.
        /// Example: "Thurcaston".
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the third address line.
        /// Example: NULL.
        /// </summary>
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Gets or sets the town.
        /// Example: "Leicester".
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// Example: NULL, "Leicestershire".
        /// </summary>
        public string County { get; set; }
    }
}