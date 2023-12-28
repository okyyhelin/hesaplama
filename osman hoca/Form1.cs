namespace osman_hoca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        void lstyaz(string Adi, string Soyadi, string OkulNo, string Cinsiyet, int Vize, int Final)
        {
            float g_notu = GecmeNotunuHesaplama(Vize, Final);
            lstOgrenciler.Items.Add(Adi + " " + Soyadi + " " + OkulNo + " " + Cinsiyet + " " + Vize + " " + Final + " " + g_notu);
        }



        float GecmeNotunuHesaplama(int Vize, int Final)
        {
            float _GecmeNotu = Vize * (float)0.4 + Final * (float)0.6;
            return _GecmeNotu;
            //return adi + "burdayým";
        }

        private void btnHesaplaKaydet_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(IlkFonksiyon("Ali"));
            int _vize = Convert.ToInt32(txtvize.Text);
            int _final = Convert.ToInt32(txtfinal.Text);
            string _adi = txtadi.Text;
            string _soyadi = txtsoyadi.Text;
            string _okulno = txtokulno.Text;
            string _cinsiyet = cmbcinsiyet.Text;
            lstyaz(_adi, _soyadi, _okulno, _cinsiyet, _vize, _final);
        }
    }
}