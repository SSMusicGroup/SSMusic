using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BaiHat_BLL
    {
        QLMusicDataContext da = new QLMusicDataContext();

        public BaiHat_BLL() { }

        public IQueryable getDSBaiHat()
        {
            var bh = from a in da.BaiHats select new { a.tenBaiHat};
            return bh;
        }

        public List<BaiHat> layDSBaiHat()
        {
            return da.BaiHats.Select(k => k).ToList();
        }

        public IQueryable getDSBaiHatByCaSi(string maCaSi)
        {
            var bh = from t in da.BaiHats where t.maCaSi == maCaSi select new { t.maBaiHat, t.tenBaiHat, t.maCaSi };
            return bh;
        }

        public List<BaiHat> layDSBaiHatTonTai(string mCS)
        {
            return da.BaiHats.Where(k => k.maCaSi == mCS).ToList();
        }

        public int getSLBaiHat()
        {
            return da.BaiHats.Select(k => k).ToList().Count;
        }

        public bool KtraTonTaiBaiHat(string tenBaiHat)
        {
            if (da.BaiHats.Where(t => t.tenBaiHat == tenBaiHat).FirstOrDefault() == null)
                return false;
            return true;
        }
        public string getPathBaiHat(string tenBH)
        {
            BaiHat bh = da.BaiHats.Where(t => t.tenBaiHat == tenBH).FirstOrDefault();
            return bh.pathBaiHat;
        }
        public void setBaiHat(string tenBH, string pathName)
        {

            List<BaiHat> bh2 = da.BaiHats.Select(k => k).ToList();
            int[] chuoisoint = new int[bh2.Count()];
            for (int i = 0; i < bh2.Count(); i ++)
            {
                string m = bh2[i].maBaiHat;
                chuoisoint[i] = int.Parse(m.Substring(2));
            }
            int max = chuoisoint[0];
            for (int j = 1; j < bh2.Count(); j++)
            {
                if (chuoisoint[j] > max)
                    max = chuoisoint[j];
            }

            BaiHat bh = new BaiHat();

            bh.maBaiHat = "BH"+max;
            bh.tenBaiHat = tenBH;
            bh.maCaSi = null;
            bh.pathBaiHat = pathName;

            da.BaiHats.InsertOnSubmit(bh);
            da.SubmitChanges();
        }

        public void themCaSiinBaiHat(string mabh, string macs)
        {
            BaiHat bh = da.BaiHats.Where(t => t.maBaiHat == mabh).SingleOrDefault();
            bh.maCaSi = macs;

            da.SubmitChanges();
        }

    }
}
