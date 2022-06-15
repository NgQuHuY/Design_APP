using FontAwesome.Sharp;


namespace Design
{
    public partial class TrangChu : Form
    {
        private IconButton currentBt;
        private Panel leftBoderBt;

        public Form currentForm;


        public TrangChu()
        {
            InitializeComponent();
            leftBoderBt = new Panel();
            leftBoderBt.Size = new Size(10, 91);
            p_button.Controls.Add(leftBoderBt);
            OpenForm(new Home());

        }

        private struct RBGClolour
        {
            public static Color color = Color.FromArgb(1, 22, 39);
        }

        private void AcctivateBt (object senderbt, Color color )
        {
            if (senderbt != null)
            {
                DisableBt();
                currentBt = (IconButton)senderbt;
                currentBt.BackColor = Color.FromArgb(46, 196, 182);
                currentBt.ForeColor = color;
                currentBt.TextAlign = ContentAlignment.MiddleCenter;
                currentBt.IconColor = color;
                currentBt.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBt.ImageAlign = ContentAlignment.MiddleRight;

                leftBoderBt.BackColor = color;
                leftBoderBt.Location = new Point(0,currentBt.Location.Y);
                leftBoderBt.Visible = true;
                leftBoderBt.BringToFront();

            }
        }

        private void DisableBt ()
        {
            if (currentBt != null)
            {
                currentBt.BackColor = Color.FromArgb(1, 22, 76);
                currentBt.ForeColor = Color.White;
                currentBt.TextAlign = ContentAlignment.MiddleLeft;
                currentBt.IconColor = Color.White;
                currentBt.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBt.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        public void OpenForm (Form form )
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            p_form.Controls.Add(form);
            p_form.Tag = form;
            form.BringToFront();
            form.Show();

        }

        private void bt_thongtin_Click(object sender, EventArgs e)
        {
            AcctivateBt(sender, RBGClolour.color);
            OpenForm(new ThongTin());
        }

        private void bt_chuyentien_Click(object sender, EventArgs e)
        {
            AcctivateBt(sender, RBGClolour.color);
            OpenForm(new ChuyenTien());
        }

        private void bt_tietkiem_Click(object sender, EventArgs e)
        {
            AcctivateBt(sender, RBGClolour.color);
            OpenForm(new GuiTietKiem());
        }

        private void bt_lichsu_Click(object sender, EventArgs e)
        {
            AcctivateBt(sender, RBGClolour.color);
            OpenForm(new LichSu());
        }

        private void icon_curform_Click(object sender, EventArgs e)
        {
            Reset();
            currentForm.Close();
            OpenForm(new Home());
        }

        private void Reset()
        {
            DisableBt();
            leftBoderBt.Visible = false;
           
        }
    }
}