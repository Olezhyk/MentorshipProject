using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMentorshipProject.Properties;

namespace WPFMentorshipProject
{
	public static class EnumHelper
	{
		public static string GetPlayerNationality(CountryNames playerNationality)
		{
			switch (playerNationality)
			{
				case CountryNames.Argentina:
					return Resources.ArgentineNationality;
				case CountryNames.Austria:
					return Resources.AustrianNationality;
				case CountryNames.Australia:
					return Resources.AustralianNationality;
				case CountryNames.Belarus:
					return Resources.BelarusianNationality;
				case CountryNames.Belgium:
					return Resources.BelgianNationality;
				case CountryNames.Bolivia:
					return Resources.BolivianNationality;
				case CountryNames.Brazil:
					return Resources.BrazilianNationality;
				case CountryNames.Bulgaria:
					return Resources.BulgarianNationality;
				case CountryNames.China:
					return Resources.ChineseNationality;
				case CountryNames.Colombia:
					return Resources.ColombianNationality;
				case CountryNames.CostaRica:
					return Resources.CostaRicanNationality;
				case CountryNames.Croatia:
					return Resources.CroatianNationality;
				case CountryNames.CzechRepublic:
					return Resources.CzechNationality;
				case CountryNames.Denmark:
					return Resources.DanishNationality;
				case CountryNames.England:
					return Resources.EnglishNationality;
				case CountryNames.France:
					return Resources.FrenchNationality;
				case CountryNames.Germany:
					return Resources.GermanNationality;
				case CountryNames.Greece:
					return Resources.GreekNationality;
				case CountryNames.Holland:
					return Resources.DutchNationality;
				case CountryNames.Hungary:
					return Resources.HungarianNationality;
				case CountryNames.Iceland:
					return Resources.IcelandicNationality;
				case CountryNames.Ireland:
					return Resources.IrishNationality;
				case CountryNames.Italy:
					return Resources.ItalianNationality;
				case CountryNames.Jamaica:
					return Resources.JamaicanNationality;
				case CountryNames.Japan:
					return Resources.JapaneseNationality;
				case CountryNames.Latvia:
					return Resources.LatvianNationality;
				case CountryNames.Lithuania:
					return Resources.LithuanianNationality;
				case CountryNames.Mexico:
					return Resources.MexicanNationality;
				case CountryNames.Nigeria:
					return Resources.NigerianNationality;
				case CountryNames.Norway:
					return Resources.NorwegianNationality;
				case CountryNames.Poland:
					return Resources.PolishNationality;
				case CountryNames.Portugal:
					return Resources.PortugueseNationality;
				case CountryNames.Romania:
					return Resources.RomanianNationality;
				case CountryNames.Scotland:
					return Resources.ScottishNationality;
				case CountryNames.Slovakia:
					return Resources.SlovakNationality;
				case CountryNames.SouthAfrica:
					return Resources.SouthAfricanNationality;
				case CountryNames.Spain:
					return Resources.SpanishNationality;
				case CountryNames.Sweden:
					return Resources.SwedishNationality;
				case CountryNames.Switzerland:
					return Resources.SwissNationality;
				case CountryNames.Turkey:
					return Resources.TurkishNationality;
				case CountryNames.Ukraine:
					return Resources.UkranianNationality;
				case CountryNames.USA:
					return Resources.AmericanNationality;
				case CountryNames.Uruguay:
					return Resources.UruguayanNationality;
				case CountryNames.Wales:
					return Resources.WelshNationality;
				default:
					return Resources.none;
			}
		}

		public static string GetFederationName(CountryNames federationName)
		{
			switch (federationName)
			{
				case CountryNames.Argentina:
					return Resources.ArgentinaFederation;
				case CountryNames.Brazil:
					return Resources.BrazilFederation;
				case CountryNames.England:
					return Resources.EnglandFederation;
				case CountryNames.France:
					return Resources.FranceFederation;
				case CountryNames.Germany:
					return Resources.GermanyFederation;
				case CountryNames.Holland:
					return Resources.HollandFederation;
				case CountryNames.Italy:
					return Resources.ItalyFederation;
				case CountryNames.Poland:
					return Resources.PolandFederation;
				case CountryNames.Portugal:
					return Resources.PortugalFederation;
				case CountryNames.Scotland:
					return Resources.ScotlandFederation;
				case CountryNames.Spain:
					return Resources.SpainFederation;
				case CountryNames.Turkey:
					return Resources.TurkeyFederation;
				case CountryNames.Ukraine:
					return Resources.UkraineFederation;
				default:
					return Resources.none;
			}
		}

		public static string GetPleyerPosition(PlayerPositionNames playerPosition)
		{
			switch (playerPosition)
			{
				case PlayerPositionNames.Goalkeeper:
					return Resources.Goalkeeper;
				case PlayerPositionNames.LeftDefender:
					return Resources.LeftDefender;
				case PlayerPositionNames.LeftCenterDefender:
					return Resources.LeftCenterDefender;
				case PlayerPositionNames.RightCenterDefender:
					return Resources.RightCenterDefender;
				case PlayerPositionNames.RightDefender:
					return Resources.RightDefender;
				case PlayerPositionNames.LeftMiddleForward:
					return Resources.LeftMiddleForward;
				case PlayerPositionNames.LeftCenterMiddleForward:
					return Resources.LeftCenterMiddleForward;
				case PlayerPositionNames.RightCenterMiddleForward:
					return Resources.RightCenterMiddleForward;
				case PlayerPositionNames.RightMiddleForward:
					return Resources.RightMiddleForward;
				case PlayerPositionNames.LeftForward:
					return Resources.LeftForward;
				case PlayerPositionNames.RightForward:
					return Resources.RightForward;
				default:
					return Resources.none;
			}
		}
	}
}
