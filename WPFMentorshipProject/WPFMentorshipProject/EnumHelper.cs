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
        public static string GetPlayerNationality(Country playerNationality)
        {
            switch (playerNationality)
            {
                case Country.Argentina:
                    return Resources.ArgentineNationality;
                default:
                    return Resources.none;
            }
        }

        public static string GetFederationName(Country federationName)
        {
            switch (federationName)
            {
                case Country.Argentina:
                    return Resources.ArgentinaFederation;
                default:
                    return Resources.none;
            }
        }

        public static string GetPleyerPosition(PlayerPosition playerPosition)
        {
            switch (playerPosition)
            {
                case PlayerPosition.Goalkeeper:
                    return Resources.Goalkeeper;
                default:
                    return Resources.none;
            }
        }
    }
}
