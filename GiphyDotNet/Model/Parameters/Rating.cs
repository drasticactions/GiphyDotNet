using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiphyDotNet.Model.Parameters
{
    public enum Rating
    {
        None,
        Y,
        G,
        Pg,
        Pg13,
        R
    }

    public static class RatingExtensions
    {
        public static string ToFriendlyString(this Rating me)
        {
            switch (me)
            {
                case Rating.None:
                    return "";
                case Rating.Y:
                    return "y";
                case Rating.G:
                    return "g";
                case Rating.Pg:
                    return "pg";
                case Rating.Pg13:
                    return "pg-13";
                case Rating.R:
                    return "r";
                default:
                    return "";
            }
        }
    }
}
