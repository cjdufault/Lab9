using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSuggestions
{
    class HousePlantInfo
    {
        public string GenerateSuggestion(int temp, bool southFacing)
        {
            // determine the suggestion based on available sunlight and temperature
            if (southFacing)
            {
                if (temp > 65)
                {
                    return "Peace Lily";
                }
                else
                {
                    return "Spider Plant";
                }
            }
            else
            {
                if (temp > 65)
                {
                    return "Dragon Tree";
                }
                else
                {
                    return "Ivy";
                }
            }

        }

        public void ShowWebPage(string plantName = null)
        {
            string url = "https://houseplant411.com/";

            if (plantName != null)
            {
                url = url + "houseplant?hpq=" + plantName; // takes you to the search page for that plant on houseplant411.com
            }

            System.Diagnostics.Process.Start(url);
        }
    }
}
