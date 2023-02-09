using System;
namespace ChuckNorrisASP.NET.Models
{
	public class ChuckJoke
	{
		public ChuckJoke()
		{
		}

        public List<string> Categories { get; set; }
        public string CreatedAt { get; set; }
        public string IconUrl { get; set; }
        public string Id { get; set; }
        public string UpdatedAt { get; set; }
        public string Url { get; set; }
        public string Value { get; set; }
        public string PicPath
        {
            get
            {
                return $"~/pics/chuck1.png";
            }
        }

        private int RandomNum()
        {
            Random rng = new Random();

            return rng.Next(0, 4);
        }
    }
}
