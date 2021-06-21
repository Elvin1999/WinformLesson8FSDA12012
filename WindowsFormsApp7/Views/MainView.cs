using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7.Model;

namespace WindowsFormsApp7.Views
{
    public partial class MainView : Form , IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> AddButtonClicked { get; set; }
        public EventHandler<EventArgs> LoadButtonClicked { get; set; }
        public string ModelText { get =>modelTxtb.Text; set => modelTxtb.Text=value; }
        public string VendorText { get =>vendorTxtb.Text; set => vendorTxtb.Text=value; }
        public string TransmissionText { get => transmissionTxtb.Text; set => transmissionTxtb.Text=value; }
        public string YearText { get => yearTxtb.Text; set => yearTxtb.Text=value; }
        public string ColorText { get => colorTxtb.Text; set => colorTxtb.Text=value; }
        public List<Car> Cars { set {
                dataListBox.DataSource = null;
                dataListBox.DataSource = value;
            } }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddButtonClicked.Invoke(sender, e);
        }

        private void loadBtb_Click(object sender, EventArgs e)
        {
            LoadButtonClicked.Invoke(sender, e);
        }
    }
}
