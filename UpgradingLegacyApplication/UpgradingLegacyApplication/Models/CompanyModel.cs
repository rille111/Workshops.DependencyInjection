namespace UpgradingLegacyApplication.Api.Models
{
    public class CompanyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        #region Hidden code - You don't see this!

        public string ResourceUri
        {
            get { return string.Format("{0}/{1}", "http://localhost:57446/api/companies", Id); }
        }

        #endregion
    }
}