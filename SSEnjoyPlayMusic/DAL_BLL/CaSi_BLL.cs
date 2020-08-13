using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class CaSi_BLL
    {
        QLMusicDataContext da = new QLMusicDataContext();
        public CaSi_BLL() { }

        public List<CaSi> getDSCaSi()
        {
            return da.CaSis.Select(k => k).ToList();
        }

        public IQueryable getDSBaiHatByCaSi(string maCaSi)
        {
            var bh = from t in da.BaiHats where t.maCaSi == maCaSi select new { t.tenBaiHat };
            return bh;
        }
        public bool check_CaSi(string maCaSi)
        {
            if ((da.BaiHats.Where(k => k.maCaSi == maCaSi).FirstOrDefault()) == null)
            {
                return false;
            }
            return true;
        }

        public bool check_CaSi_DaTonTai(string tenCS)
        {
            if (da.CaSis.Where(t => t.tenCaSi == tenCS).FirstOrDefault() == null)
                return false;
            return true;
        }

        public void addCaSi(string tenCS)
        {
            List<CaSi> cs2 = da.CaSis.Select(k => k).ToList();
            int[] chuoisoint = new int[cs2.Count()];
            for (int i = 0; i < cs2.Count(); i++)
            {
                string m = cs2[i].maCaSi;
                chuoisoint[i] = int.Parse(m.Substring(2));
            }
            int max = chuoisoint[0];
            for (int j = 1; j < cs2.Count(); j++)
            {
                if (chuoisoint[j] > max)
                    max = chuoisoint[j];
            }


            CaSi cs = new CaSi();
            cs.maCaSi = "CS" + max;
            cs.tenCaSi = tenCS;

            da.CaSis.InsertOnSubmit(cs);
            da.SubmitChanges();
        }
    }
}
