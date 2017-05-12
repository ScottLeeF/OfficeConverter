using System;
using System.Windows.Forms;
using ExcelForm = Wen.OurOfficeConverter.WinForm.ExcelConverter;
using WordForm = Wen.OurOfficeConverter.WinForm.WordConverter;

namespace Wen.OurOfficeConverter.WinForm.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenWordConverter_Click(object sender, EventArgs e)
        {
            var form = new WordForm.MainForm();
            form.ShowDialog();

        }

        private void btnOpenExcelConverter_Click(object sender, EventArgs e)
        {
            var form = new ExcelForm.MainForm();
            form.ShowDialog();
        }
    }
}