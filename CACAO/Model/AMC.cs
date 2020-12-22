using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACAO.Model
{
    public class AMC
    {
        [DisplayName("Name")]
        public string name { get; set; }

        [DisplayName("AMC Number")]
        public string amcNumber { get; set; }       

        [DisplayName("Credit Card Number")]
        public string creditCardNumber { get; set; }

        public string PNR { get; set; }

        public bool ValivateAMC()
        {
            bool isValid = true;
            if (amcNumber is null)
            {
                isValid = false;
            }
            return isValid;

        }

        public static string Push()
        {
            return "Successfully pushed to Marvel.";
        }
        public static string Pull()
        {
            return "Successfully pulled data from CACAO.";
        }

        public List<AMC> GetData(string path)
        {
            string jsonResult;
            StreamReader r = new StreamReader(path);   
            jsonResult = r.ReadToEnd();
            List<AMC>  listAMC = JsonConvert.DeserializeObject<List<AMC>>(jsonResult);
            r.Close();
            return listAMC;
        }
    }    
}
