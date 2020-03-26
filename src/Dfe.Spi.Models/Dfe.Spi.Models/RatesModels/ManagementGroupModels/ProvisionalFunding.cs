namespace Dfe.Spi.Models.RatesModels.ManagementGroupModels
{
    /// <summary>
    /// Represents provisional funding.
    /// </summary>
    public class ProvisionalFunding : ManagementGroupModels
    {
        /// <summary>
        /// Gets or sets the <c>ActualPrimaryUnitOfFunding</c> value.
        /// Spreadsheets: 2018, 2019, 2020.
        /// </summary>
        public double? ActualPrimaryUnitOfFunding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>ActualSecondaryUnitOfFunding</c> value.
        /// Spreadsheets: 2018, 2019, 2020.
        /// </summary>
        public double? ActualSecondaryUnitOfFunding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>PrimaryPupilNumbers</c> value.
        /// Spreadsheets: 2018, 2019, 2020.
        /// NOTE: Spreadsheet 2018 contains a double for a value from this
        ///       column.
        /// </summary>
        public double? PrimaryPupilNumbers
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>SecondaryPupilNumbers</c> value.
        /// Spreadsheets: 2018, 2019, 2020.
        /// NOTE: Spreadsheet 2018 contains a double for a value from this
        ///       column.
        /// </summary>
        public double? SecondaryPupilNumbers
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the
        /// <c>ActualFundingThroughPremesisMobilityGrowthFactors</c> value.
        /// Spreadsheets: 2018.
        /// </summary>
        public double? ActualFundingThroughPremesisMobilityGrowthFactors
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>ActualFundingThroughPremesisMobilityFactors</c>
        /// value.
        /// Spreadsheets: 2019.
        /// </summary>
        public double? ActualFundingThroughPremesisMobilityFactors
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>ActualFundingThroughPremesisFactors</c> value.
        /// Spreadsheets: 2020.
        /// </summary>
        public double? ActualFundingThroughPremesisFactors
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>NffSchoolsBlockFunding</c> value.
        /// Spreadsheets: 2018, 2019.
        /// </summary>
        public double? NffSchoolsBlockFunding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>IllustrativeGrowthFunding</c> value.
        /// Spreadsheets: 2019.
        /// </summary>
        public double? IllustrativeGrowthFunding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>LocalAuthorityProtection</c> value.
        /// Spreadsheets: 2020.
        /// </summary>
        public double? LocalAuthorityProtection
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the
        /// <c>NffSchoolsBlockFundingExcludingFundingThroughGrowthFactor</c>
        /// value.
        /// Spreadsheets: 2020.
        /// </summary>
        public double? NffSchoolsBlockFundingExcludingFundingThroughGrowthFactor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>ActualHighNeedsNffAllocations</c> value.
        /// Spreadsheets: 2018, 2019, 2020.
        /// </summary>
        public double? ActualHighNeedsNffAllocations
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the
        /// <c>ActualAcaWeightedBasicEntitlementFactorUnitRate</c> value.
        /// Spreadsheets: 2018, 2019.
        /// </summary>
        public double? ActualAcaWeightedBasicEntitlementFactorUnitRate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>NumberOfPupilsInSpecialSchoolsAcadamies</c>
        /// value.
        /// Spreadsheets: 2018, 2020.
        /// Note: This is a double on the 2020 spreadsheet (for some reason).
        /// </summary>
        public double? NumberOfPupilsInSpecialSchoolsAcadamies
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>AcaWeightedBasicEntitlementUnitRate</c>
        /// value.
        /// Spreadsheets: 2020.
        /// </summary>
        public double? AcaWeightedBasicEntitlementUnitRate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>BasicEntitlementFactor</c> value.
        /// Spreadsheets: 2020.
        /// </summary>
        public double? BasicEntitlementFactor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the
        /// <c>NumberOfPupilsInSpecialSchoolsAcadamiesIndependentSettings</c>
        /// value.
        /// Spreadsheets: 2019.
        /// Note: This value is a double in the 2019 spreadsheet.
        /// </summary>
        public double? NumberOfPupilsInSpecialSchoolsAcadamiesIndependentSettings
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the
        /// <c>ImportExportAdjustmentsIncludingAdjustmentsToNewAndGrowingSpecialFreeSchools</c>
        /// value.
        /// Spreadsheets: 2020.
        /// </summary>
        public double? ImportExportAdjustmentsIncludingAdjustmentsToNewAndGrowingSpecialFreeSchools
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the
        /// <c>HospitalEducationFundingWithEightPercentUplift</c> value.
        /// Spreadsheets: 2020.
        /// </summary>
        public double? HospitalEducationFundingWithEightPercentUplift
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>ActualImportExportAdjustmentUnitRate</c> value.
        /// Spreadsheets: 2018, 2019.
        /// </summary>
        public double? ActualImportExportAdjustmentUnitRate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>NetNumberOfImportedPupils</c> value.
        /// Spreadsheets: 2018, 2019, 2020.
        /// Note: This is a double on the 2018 spreadsheet (for some reason).
        /// </summary>
        public double? NetNumberOfImportedPupils
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the
        /// <c>AdditionalFundingForNewAndGrowingSpecialFreeSchools</c> value.
        /// Spreadsheets: 2020.
        /// </summary>
        public double? AdditionalFundingForNewAndGrowingSpecialFreeSchools
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>HospitalEducationSpending</c> value.
        /// Spreadsheets: 2019.
        /// </summary>
        public double? HospitalEducationSpending
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>NffHighNeedsBlockFunding</c> value.
        /// Spreadsheets: 2018, 2019, 2020.
        /// </summary>
        public double? NffHighNeedsBlockFunding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>ActualCssbUnitOfFunding</c> value.
        /// Spreadsheets: 2018.
        /// </summary>
        public double? ActualCssbUnitOfFunding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>ActualCssbUnitOfFundingForOngoingFunctions</c>
        /// value.
        /// Spreadsheets: 2019, 2020.
        /// </summary>
        public double? ActualCssbUnitOfFundingForOngoingFunctions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>PupilNumbers</c> value.
        /// Spreadsheets: 2018.
        /// </summary>
        public int? PupilNumbers
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the
        /// <c>PupilNumbersSchoolsBlockDsgDuplicatesApportioned</c> value.
        /// Spreadsheets: 2019, 2020.
        /// Note: Double on the 2019 spreadsheet.
        /// </summary>
        public double? PupilNumbersSchoolsBlockDsgDuplicatesApportioned
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>ActualFundingForHistoricCommitments</c> value.
        /// Spreadsheets: 2018, 2019, 2020.
        /// </summary>
        public double? ActualFundingForHistoricCommitments
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>NffCssbFunding</c> value.
        /// Spreadsheets: 2018, 2019, 2020.
        /// </summary>
        public double? NffCssbFunding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the
        /// <c>NffAllocationsForSchoolsHighNeedsAndCentralSchoolServicesBlocks</c>
        /// value.
        /// Spreadsheets: 2018, 2019, 2020.
        /// </summary>
        public double? NffAllocationsForSchoolsHighNeedsAndCentralSchoolServicesBlocks
        {
            get;
            set;
        }
    }
}