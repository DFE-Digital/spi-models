namespace Dfe.Spi.Models.RatesModels.LearningProviderModels
{
    /// <summary>
    /// Represents illustrative funding.
    /// </summary>
    public class IllustrativeFunding
    {
        /// <summary>
        /// Gets or sets the <c>TotalNffFunding</c> value.
        /// Spreadsheets: 2018, 2019.
        /// </summary>
        public long? TotalNffFunding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>PercentageChangeComparedToBaseline</c> value.
        /// Spreadsheets: 2018, 2019.
        /// </summary>
        public double? PercentageChangeComparedToBaseline
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the
        /// <c>NewAndGrowingSchoolsTotalNffFundingIfFullyImplemented</c> value.
        /// Spreadsheets: 2018, 2019.
        /// </summary>
        public long? NewAndGrowingSchoolsTotalNffFundingIfFullyImplemented
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>TotalNffFundingIfFullyImplemented</c> value.
        /// Spreadsheets: 2018.
        /// </summary>
        public long? TotalNffFundingIfFullyImplemented
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>PercentageChangeInPupilLedFunding</c> value.
        /// Spreadsheets: 2018.
        /// </summary>
        public double? PercentageChangeInPupilLedFunding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the
        /// <c>PercentageChangeComparedToBaselineIfFullyImplemented</c> value.
        /// Spreadsheets: 2018.
        /// </summary>
        public double? PercentageChangeComparedToBaselineIfFullyImplemented
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the
        /// <c>PercentageChangeInPupilLedFundingIfFullyImplemented</c> value.
        /// Spreadsheets: 2018.
        /// </summary>
        public double? PercentageChangeInPupilLedFundingIfFullyImplemented
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>TotalNffFundingIfFullyImplementedPerPupil</c>
        /// value.
        /// Spreadsheets: 2019.
        /// </summary>
        public long? TotalNffFundingIfFullyImplementedPerPupil
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>PercentageChangeInPupilLedFundingPerPupil</c>
        /// value.
        /// Spreadsheets: 2019.
        /// </summary>
        public double? PercentageChangeInPupilLedFundingPerPupil
        {
            get;
            set;
        }
    }
}
