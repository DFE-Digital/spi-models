namespace Dfe.Spi.Models.RatesModels.LearningProviderModels
{
    /// <summary>
    /// Represents notional funding.
    /// </summary>
    public class NotionalFunding
    {
        /// <summary>
        /// Gets or sets the <c>TotalNffFunding</c> value.
        /// Spreadsheets: 2018, 2019, 2020.
        /// </summary>
        public double? TotalNffFunding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>PercentageChangeComparedToBaseline</c> value.
        /// Spreadsheets: 2018, 2019, 2020.
        /// </summary>
        public double? PercentageChangeComparedToBaseline
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
        /// Gets or sets the <c>PupilCount</c> value.
        /// Note: A double, because helpfully, on the 2020 spreadsheet, it is
        ///       a double (quite how that works is anyone's best guess).
        /// Spreadsheets: 2019, 2020.
        /// </summary>
        public double? PupilCount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>TotalNffFundingPerPupil</c> value.
        /// Spreadsheets: 2019, 2020.
        /// </summary>
        public double? TotalNffFundingPerPupil
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>PercentageChangeInPupilLedFundingPerPupil</c>
        /// value.
        /// Spreadsheets: 2019, 2020.
        /// </summary>
        public double? PercentageChangeInPupilLedFundingPerPupil
        {
            get;
            set;
        }
    }
}