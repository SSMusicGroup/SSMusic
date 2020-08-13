using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class PlayList_BLL
    {
        QLMusicDataContext da = new QLMusicDataContext();

        public PlayList_BLL() { }

        public List<Playlist> getDSPlayList()
        {
            return da.Playlists.Select(k => k).ToList();
        }

        public IQueryable getDSBaiHatCuaPLaylist(string maPlaylist)
        {
            var ds = from a in da.BaiHatVaPlayLists join b in da.BaiHats on a.maBaiHat equals b.maBaiHat where a.maPlaylist == maPlaylist select new { b.tenBaiHat};
            return ds;
        }

        public bool check_PlayList_DaTonTai(string tenPL)
        {
            if (da.Playlists.Where(t => t.tenPlaylist == tenPL).FirstOrDefault() == null)
                return false;
            return true;
        }

        public void addPlayList(string tenPL)
        {
            Playlist pl = new Playlist();
            int count = da.Playlists.Select(k => k).ToList().Count + 1;
            pl.maPlaylist = "PL00" + count;
            pl.tenPlaylist = tenPL;

            da.Playlists.InsertOnSubmit(pl);
            da.SubmitChanges();
        }

        public void addBaiHatByPlayList(string mapl, string mabh)
        {
            BaiHatVaPlayList bh = new BaiHatVaPlayList();

            bh.maPlaylist = mapl;
            bh.maBaiHat = mabh;

            da.BaiHatVaPlayLists.InsertOnSubmit(bh);
            da.SubmitChanges();
        }

        public bool check_BH_in_PL_tonTai(string mabh, string mapl)
        {
            var bhpl = from a in da.BaiHatVaPlayLists where  a.maBaiHat == mabh && a.maPlaylist == mapl  select a;
            if (bhpl.Count() > 0)
                return false;
            return true;
        }
    }
}
