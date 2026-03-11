using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModul4_Muh_Aqsa_Sirojudin_103082400004
{
    internal class KodePos
    {
        public int getKodePos(string kelurahan)
        {
            Dictionary<string, int> tableKodePos = new Dictionary<string, int>()
            {
                {"Batununggal", 40266},
                {"Kujangsari", 40287},
                {"Mengger", 40267},
                {"Wates", 40256},
                {"Cijaura", 40287},
                {"Jatisari", 40286},
                {"Margasari", 40286},
                {"Sekejati", 40286},
                {"Kebonwaru", 40272},
                {"Maleer", 40274},
                {"Samoja", 40273}
            };

            if (tableKodePos.ContainsKey(kelurahan))
            {
                return tableKodePos[kelurahan];
            }
            return -1;
        }
    }
}
