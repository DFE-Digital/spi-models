namespace Dfe.Spi.Models.RatesModels.LearningProviderModels
{
    /// <summary>
    /// Represents baseline funding.
    /// </summary>
    public class BaselineFunding : ModelsBase
    {
        /// <summary>
        /// Gets or sets the <c>BaselineFunding</c> value.
        /// Spreadsheets: 2018, 2019, 2020.
        /// </summary>
        public double? Value
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
        /// Gets or sets the <c>BaselineFundingFullSchool</c> value.
        /// Spreadsheets: 2018.
        /// </summary>
        public long? BaselineFundingFullSchool
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>NewAndGrowingSchoolsPupilCountIfFull</c> value.
        /// Spreadsheets: 2019.
        /// </summary>
        public int? NewAndGrowingSchoolsPupilCountIfFull
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>NewAndGrowingSchoolsValueIfFull</c> value.
        /// Spreadsheets: 2019.
        /// </summary>
        public long? NewAndGrowingSchoolsValueIfFull
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>ValuePerPupil</c> value.
        /// Spreadsheets: 2019.
        /// </summary>
        public long? ValuePerPupil
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <c>NewAndGrowingSchoolsValuePerPupilIfFull</c>
        /// value.
        /// Spreadsheets: 2019.
        /// </summary>
        public long? NewAndGrowingSchoolsValuePerPupilIfFull
        {
            get;
            set;
        }
    }
}