using System;
using ChuckNorrisASP.NET.Models;

namespace ChuckNorrisASP.NET
{
	public interface IChuckJokeRepo
	{
		public ChuckJoke GetChuckJoke();
	}
}

