using System;
using System.Xml.Linq;
using ChuckNorrisASP.NET.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ChuckNorrisASP.NET
{
	public class ChuckJokeRepo : IChuckJokeRepo
	{
		public ChuckJokeRepo()
		{
		}

        public ChuckJoke GetChuckJoke()
        {
            var client = new HttpClient();

            var chuckURL = "https://api.chucknorris.io/jokes/random";

            var chuckResponse = client.GetStringAsync(chuckURL).Result;

            //var chuckQuote = JObject.Parse(chuckResponse).GetValue("value").ToString();

            //return chuckQuote;

            return JsonConvert.DeserializeObject<ChuckJoke>(chuckResponse);
        }
    }
}

