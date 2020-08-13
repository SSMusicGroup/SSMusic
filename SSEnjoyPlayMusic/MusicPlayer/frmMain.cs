using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;


namespace MusicPlayer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        CaSi_BLL daCS = new CaSi_BLL();
        BaiHat_BLL daBH = new BaiHat_BLL();
        PlayList_BLL daPL = new PlayList_BLL();
        string maCS;
        string[] paths, files;
        int Startindex = 0;
        string[] Filename;
        string[] Filepath ;
        Boolean playnext = false;
        bool repeatStatus = false;
        bool randomStatus = false;

        bool _playing = false;

        public string MaCaSi
        {
            get { return maCS; }
            set { maCS = value; }
        }

        public void loadCbo_CaSi()
        {
            cbo_CaSi.DataSource = daCS.getDSCaSi();
            cbo_CaSi.DisplayMember = "tenCaSi";
            cbo_CaSi.ValueMember = "maCaSi";
        }


        public bool isPlaying
        {
            get
            {
                return _playing;
            }
            set
            {
                _playing = value;
                if (_playing)
                {
                    axWMP_main.Ctlcontrols.pause();
                    btn_Action.Image = play.Image;
                }
                else
                {
                    axWMP_main.Ctlcontrols.play();
                    btn_Action.Image = pause.Image;
                }
            }
        }

        public void load_dsBaiHat()
        {
            dgvBaiHat.DataSource = daBH.getDSBaiHat();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            load_dsBaiHat();
            loadCbo_PlayList();
            Startindex = 0;
            playnext = false;
            StopPlayer();
            bunifuSlider1.Value = 100;
            loadCbo_CaSi();
            loadCbo_BaiHat_In_CaSi();
            loadCbo_BHinPL();
        }

        public void StopPlayer()
        {
            axWMP_main.Ctlcontrols.stop();
        }

        public void playfile(int playListIndex)
        {
            try
            {
                if (lbox_ListNhac.Items.Count <= 0)
                {
                    return;
                }
                if (playListIndex < 0)
                {
                    return;
                }
                axWMP_main.settings.autoStart = true;
                axWMP_main.URL = Filepath[playListIndex];
                lbox_ListNhac.SelectedIndex = playListIndex;
                lbl_Name_Song.Text = lbox_ListNhac.SelectedItem.ToString();
                axWMP_main.Ctlcontrols.next();
                axWMP_main.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex);
            }
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                bunifuSlider1.Value = 100;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                bunifuSlider1.Value = 100;
            }
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            Application.Exit();
            Application.ExitThread();
            this.Close();
        }

        private void btn_PlayList_Click(object sender, EventArgs e)
        {
            gbPLaylist.BringToFront();
        }

        private void btn_NowPlay_Click(object sender, EventArgs e)
        {
            lbox_ListNhac.BringToFront();
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            axWMP_main.settings.volume = bunifuSlider1.Value;
            lbl_AmLuong.Text = bunifuSlider1.Value.ToString();
            if (bunifuSlider1.Value == 0)
            {
                btn_AmLuong.Image = Properties.Resources.Mute_100px;
            }
            else
            {
                btn_AmLuong.Image = Properties.Resources.audio_100px;
            }
        }

        private void btn_AmLuong_Click(object sender, EventArgs e)
        {
            if (bunifuSlider1.Value > 0)
            {
                btn_AmLuong.Image = Properties.Resources.No_Audio_100px;
                axWMP_main.settings.volume = 0;
            }
        }

        public EventHandler onAction = null;

        private void btn_Action_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
            if (onAction != null)
            {
                onAction.Invoke(this, e);
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            axWMP_main.Ctlcontrols.pause();
        }

        private void play_Click(object sender, EventArgs e)
        {
            axWMP_main.Ctlcontrols.play();
        }

        private void btn_Stop_song_Click(object sender, EventArgs e)
        {
            StopPlayer();
        }

        private void btn_next_song_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            if(randomStatus == true)
            {
                Startindex = r.Next(0, lbox_ListNhac.Items.Count - 1);
            }
            else if(repeatStatus == true)
            {
                if (Startindex == lbox_ListNhac.Items.Count - 1)
                {
                    Startindex = 0;
                }
                else
                {
                    Startindex = Startindex + 1;
                }
            }
            else
            {
                if (Startindex == lbox_ListNhac.Items.Count - 1)
                {
                    Startindex = lbox_ListNhac.Items.Count - 1;
                }
                else if (Startindex < lbox_ListNhac.Items.Count)
                {
                    Startindex = Startindex + 1;
                }
            }
            playfile(Startindex);
        }

        private void btn_back_Song_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            if (randomStatus == true)
            {
                Startindex = r.Next(0, lbox_ListNhac.Items.Count - 1);
            }
            else if (repeatStatus == true)
            {
                if (Startindex == 0)
                {
                    Startindex = lbox_ListNhac.Items.Count - 1;
                }
                else
                {
                    Startindex = Startindex - 1;
                }
            }
            else
            {
                if (Startindex > 0)
                {
                    Startindex = Startindex - 1;
                }
            }
            playfile(Startindex);
        }

        private void time_song_Tick(object sender, EventArgs e)
        {
            lbl_time_start.Text = axWMP_main.Ctlcontrols.currentPositionString;
            lbl_time_end.Text = axWMP_main.Ctlcontrols.currentItem.durationString.ToString();
            if (axWMP_main.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                PB_Timer.Value = (int)axWMP_main.Ctlcontrols.currentPosition;
            }
        }

        private void axWMP_main_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWMP_main.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                PB_Timer.MaximumValue = (int)axWMP_main.Ctlcontrols.currentItem.duration;
                time_song.Start();
            }
            else if (axWMP_main.playState==WMPLib.WMPPlayState.wmppsPaused)
            {
                time_song.Stop();
            }
            else if (axWMP_main.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                time_song.Stop();
                PB_Timer.Value = 0;
            }
        }

        private void cbo_CaSi_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvCaSi.DataSource = daCS.getDSBaiHatByCaSi(cbo_CaSi.SelectedValue.ToString());
        }

        private void dgvCaSi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Casi_Click(object sender, EventArgs e)
        {
            gbCaSi.BringToFront();
        }

        private void btn_BaiHat_Click(object sender, EventArgs e)
        {
            gbBaihat.BringToFront();
        }

        private void dgvBaiHat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    var ht = dgvBaiHat.HitTest(e.X, e.Y);
            //    if ((ht.ColumnIndex == dgvBaiHat.Columns.Count - 1)
            //         && (ht.Type == DataGridViewHitTestType.ColumnHeader))
            //    {
            //        menuBaiHat.Show(MousePosition);
            //    }
            //}
        }

        private void lbox_ListNhac_MouseClick(object sender, MouseEventArgs e)
        {
            Startindex = lbox_ListNhac.SelectedIndex;
            playfile(Startindex);
            lbl_Name_Song.Text = lbox_ListNhac.Text;
        }

        private void cboPlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPlaylist.DataSource = daPL.getDSBaiHatCuaPLaylist(cboPlayList.SelectedValue.ToString());
        }

        public void loadCbo_PlayList()
        {
            cboPlayList.DataSource = daPL.getDSPlayList();
            cboPlayList.DisplayMember = "tenPlayList";
            cboPlayList.ValueMember = "maPlayList";
        }

        private void cboPlayList_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvPlaylist.DataSource = daPL.getDSBaiHatCuaPLaylist(cboPlayList.SelectedValue.ToString());          
        }

        private void dgvBaiHat_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string m = dgvBaiHat.SelectedCells[0].Value.ToString();
            Filepath = new string[1];
            Filepath[0] = daBH.getPathBaiHat(m);
            lbox_ListNhac.Items.Clear();
            lbox_ListNhac.Items.Add(m);
            Startindex = 0;
            playfile(0);
            lbox_ListNhac.BringToFront();

        }

        private void lbox_ListNhac_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Startindex = lbox_ListNhac.SelectedIndex;
            //playfile(Startindex);
            //lbl_Name_Song.Text = lbox_ListNhac.Text;
        }

        private void btnPhatAllBaiHat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBaiHat.RowCount > 0)
                {
                    Filepath = new string[dgvBaiHat.RowCount];
                    lbox_ListNhac.Items.Clear();
                    for (int i = 0; i < dgvBaiHat.RowCount; i++)
                    {
                        string m = dgvBaiHat.Rows[i].Cells[0].Value.ToString();
                        Filepath[i] = daBH.getPathBaiHat(m);
                        lbox_ListNhac.Items.Add(m);
                    }
                    Startindex = 0;
                    playfile(0);
                    lbox_ListNhac.BringToFront();
                }
                else
                    return;
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!");
                return; }
        }

        private void btnPhatBaiHat_Click(object sender, EventArgs e)
        {
            try
            {
                Filepath = new string[dgvBaiHat.SelectedRows.Count];
                lbox_ListNhac.Items.Clear();
                foreach (DataGridViewRow row in dgvBaiHat.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        string m = dgvBaiHat.Rows[row.Index].Cells[0].Value.ToString();
                        Filepath[row.Index] = daBH.getPathBaiHat(m);
                        lbox_ListNhac.Items.Add(m);
                    }
                }
                Startindex = 0;
                playfile(0);
                lbox_ListNhac.BringToFront();
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!");
                return;
            }

        }

        private void btnPhatAll_CaSi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCaSi.RowCount > 0)
                {
                    Filepath = new string[dgvCaSi.RowCount];
                    lbox_ListNhac.Items.Clear();
                    for (int i = 0; i < dgvCaSi.RowCount; i++)
                    {
                        string m = dgvCaSi.Rows[i].Cells[0].Value.ToString();
                        Filepath[i] = daBH.getPathBaiHat(m);
                        lbox_ListNhac.Items.Add(m);
                    }
                    Startindex = 0;
                    playfile(0);
                    lbox_ListNhac.BringToFront();
                }
                else
                    return;
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!");
                return;
            }
        }

        private void btnPhatAll_PLaylist_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPlaylist.RowCount > 0)
                {
                    Filepath = new string[dgvPlaylist.RowCount];
                    lbox_ListNhac.Items.Clear();
                    for (int i = 0; i < dgvPlaylist.RowCount; i++)
                    {
                        string m = dgvPlaylist.Rows[i].Cells[0].Value.ToString();
                        Filepath[i] = daBH.getPathBaiHat(m);
                        lbox_ListNhac.Items.Add(m);
                    }
                    Startindex = 0;
                    playfile(0);
                    lbox_ListNhac.BringToFront();
                }
                else
                    return;
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!");
                return;
            }
        }

        private void btnPhat_CaSi_Click(object sender, EventArgs e)
        {
            try
            {
                Filepath = new string[dgvCaSi.SelectedRows.Count];
                lbox_ListNhac.Items.Clear();
                foreach (DataGridViewRow row in dgvCaSi.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        string m = dgvCaSi.Rows[row.Index].Cells[0].Value.ToString();
                        Filepath[row.Index] = daBH.getPathBaiHat(m);
                        lbox_ListNhac.Items.Add(m);
                    }
                }
                Startindex = 0;
                playfile(0);
                lbox_ListNhac.BringToFront();
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!");
                return;
            }
        }

        private void btnPhat_PLaylist_Click(object sender, EventArgs e)
        {
            try
            {
                Filepath = new string[dgvPlaylist.SelectedRows.Count];
                lbox_ListNhac.Items.Clear();
                foreach (DataGridViewRow row in dgvPlaylist.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        string m = dgvPlaylist.Rows[row.Index].Cells[0].Value.ToString();
                        Filepath[row.Index] = daBH.getPathBaiHat(m);
                        lbox_ListNhac.Items.Add(m);
                    }
                }
                Startindex = 0;
                playfile(0);
                lbox_ListNhac.BringToFront();
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!");
                return;
            }
        }

        private void ImgBtnRanDom_Click(object sender, EventArgs e)
        {
            if(randomStatus == false)
            {
                randomStatus = true;
                ImgBtnRanDom.Image = Properties.Resources.not_shuffle_100px;
                if (repeatStatus == true)
                {
                    repeatStatus = false;
                    IgmBtnRepeat.Image = Properties.Resources.available_updates_100px;
                }
            }
            else
            {
                randomStatus = false;
                ImgBtnRanDom.Image = Properties.Resources.shuffle_100px;
            }
        }

        private void IgmBtnRepeat_Click(object sender, EventArgs e)
        {
            if (repeatStatus == false)
            {
                IgmBtnRepeat.Image = Properties.Resources.not_repeat100px;
                repeatStatus = true;
                if(randomStatus == true)
                {
                    randomStatus = false;
                    ImgBtnRanDom.Image = Properties.Resources.shuffle_100px;                  
                }
            }
            else
            {
                repeatStatus = false;
                IgmBtnRepeat.Image = Properties.Resources.available_updates_100px;
            }
        }

        private void dgvCaSi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string m = dgvCaSi.SelectedCells[0].Value.ToString();
            Filepath = new string[1];
            Filepath[0] = daBH.getPathBaiHat(m);
            lbox_ListNhac.Items.Clear();
            lbox_ListNhac.Items.Add(m);
            Startindex = 0;
            playfile(0);
            lbox_ListNhac.BringToFront();
        }

        private void dgvPlaylist_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string m = dgvPlaylist.SelectedCells[0].Value.ToString();
            Filepath = new string[1];
            Filepath[0] = daBH.getPathBaiHat(m);
            lbox_ListNhac.Items.Clear();
            lbox_ListNhac.Items.Add(m);
            Startindex = 0;
            playfile(0);
            lbox_ListNhac.BringToFront();
        }

        private void dgvBaiHat_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btn_Them_CaSi_Click(object sender, EventArgs e)
        {
            if(txt_Them_Casi.Text =="")
            {
                MessageBox.Show("Tên ca sĩ không được để trống.");
                return;
            }
            if (daCS.check_CaSi_DaTonTai(txt_Them_Casi.Text) == false)
            {
                daCS.addCaSi(txt_Them_Casi.Text);
                MessageBox.Show("Thêm tên ca sĩ thành công");
                cbo_CaSi.Refresh();
                cbo_CaSi.DataSource = daCS.getDSCaSi();
            }
            txt_Them_Casi.Text = "";
        }

        private void btn_Them_baiHatByCaSi_Click(object sender, EventArgs e)
        {
            string macs = cbo_CaSi.SelectedValue.ToString();
            string mabh = cbo_baiHat_CaSi.SelectedValue.ToString();

            daBH.themCaSiinBaiHat(mabh, macs);
            MessageBox.Show("Thêm bài hát cho ca sĩ thành công!");
            dgvCaSi.Refresh();
            dgvCaSi.DataSource = daCS.getDSBaiHatByCaSi(macs);
        }

        public void loadCbo_BaiHat_In_CaSi()
        {
            cbo_baiHat_CaSi.DataSource = daBH.layDSBaiHat();
            cbo_baiHat_CaSi.DisplayMember = "tenBaiHat";
            cbo_baiHat_CaSi.ValueMember = "maBaiHat";
        }

        private void btn_Them_BHinPL_Click(object sender, EventArgs e)
        {
            if (daPL.check_BH_in_PL_tonTai(cbo_BaiHat_PL.SelectedValue.ToString(), cboPlayList.SelectedValue.ToString()) == true)
            {
                daPL.addBaiHatByPlayList(cboPlayList.SelectedValue.ToString(), cbo_BaiHat_PL.SelectedValue.ToString());
                MessageBox.Show("Thêm thành công");
                dgvPlaylist.Refresh();
                dgvPlaylist.DataSource = daPL.getDSBaiHatCuaPLaylist(cboPlayList.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Đã tồn tại.");
            }
        }

        private void btn_Them_Playlist_Click(object sender, EventArgs e)
        {
            if (txt_Them_PL.Text == "")
            {
                MessageBox.Show("Tên PLaylist không được để trống.");
                return;
            }
            if (daPL.check_PlayList_DaTonTai(txt_Them_PL.Text) == false)
            {
                daPL.addPlayList(txt_Them_PL.Text);
                MessageBox.Show("Thêm tên playlist thành công");
                cboPlayList.Refresh();
                cboPlayList.DataSource = daPL.getDSPlayList();
            }
            txt_Them_PL.Text = "";
        }

        public void loadCbo_BHinPL()
        {
            cbo_BaiHat_PL.DataSource = daBH.layDSBaiHat();
            cbo_BaiHat_PL.DisplayMember = "tenBaiHat";
            cbo_BaiHat_PL.ValueMember = "maBaiHat";
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            lbox_ListNhac.Items.Clear();
            Startindex = 0;
            playnext = false;
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Multiselect = true;
            openFD.Filter = "(*.mp3)|*.mp3|all files(*.*)|*.*";
            if (openFD.ShowDialog()==DialogResult.OK)
            {
                Filename = openFD.SafeFileNames;
                Filepath = openFD.FileNames;              
                for (int i = 0; i <= Filename.Length - 1; i++)
                {
                    try
                    {
                        if (daBH.KtraTonTaiBaiHat(Filename[i]) == false)
                        {
                            daBH.setBaiHat(Filename[i], Filepath[i]);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đường dẫn quá dài không thể lưu trữ.");
                    }
                    lbox_ListNhac.Items.Add(Filename[i]);
                }
                dgvBaiHat.Refresh();
                dgvBaiHat.DataSource = daBH.getDSBaiHat();
                Startindex = 0;
                playfile(0);
            }
        }
    }
}
