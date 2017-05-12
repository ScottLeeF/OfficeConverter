using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;

namespace Wen.OurOfficeConverter.WinForm.WordConverter
{
    public partial class MainForm : Form
    {
        #region field

        /// <summary>
        /// 可支持转换的文档类型集合
        /// </summary>
        private static List<FileFormat> _formats;
        /// <summary>
        /// 文档类型
        /// </summary>
        private FileFormat _fileType;
        /// <summary>
        /// 保存的路径
        /// </summary>
        private string _savePath = "";

        #endregion field

        public MainForm()
        {
            InitializeComponent();

            InitControl();
        }

        #region 事件

        /// <summary>
        /// “打开”按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnOpen_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.ShowDialog();
                tbFilePath.Text = dialog.FileName;
            }

            if (string.IsNullOrEmpty(tbFilePath.Text))
            {
                MessageBox.Show(@"请先选择文档");
                return;
            }

            await Task.Run(() => { _savePath = GenerateNewFileName(tbFilePath.Text, _fileType); });
        }

        /// <summary>
        /// “转换”按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilePath.Text))
            {
                MessageBox.Show(@"请先选择文档");
                return;
            }

            if (string.IsNullOrEmpty(cbFileType.Text))
            {
                MessageBox.Show(@"请先选择要转换的类型");
                return;
            }

            //创建文档对象
            var document = new Document();

            //加载文档
            document.LoadFromFile(tbFilePath.Text);
            //保存文件
            document.SaveToFile(_savePath, _fileType);

            MessageBox.Show($@"文件名：{_savePath}");

            //打开文件
            Process.Start(_savePath);
        }

        /// <summary>
        /// “文件类型”下拉框项的切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void cbFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _fileType = (FileFormat)Enum.Parse(typeof(FileFormat), cbFileType.Text);

                if (!string.IsNullOrEmpty(tbFilePath.Text))
                {
                    await Task.Run(() => { _savePath = GenerateNewFileName(tbFilePath.Text, _fileType); });
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"程序异常");
            }
        }

        #endregion 事件

        #region private Method

        /// <summary>
        /// 初始化控件及数据
        /// </summary>
        private void InitControl()
        {
            _formats = new List<FileFormat> { FileFormat.PDF, FileFormat.Xml, FileFormat.Html };

            cbFileType.DataSource = _formats;
            cbFileType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// 生成新的文件名称
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        private string GenerateNewFileName(string sourceFileName, FileFormat format)
        {
            var file = new FileInfo(sourceFileName);

            var name = file.Name;
            var extension = file.Extension;
            var newExtension = GetExtension(format);

            var fileName = Path.Combine(@"E:\== Temp ==",
                name.Substring(0, name.Length - extension.Length) + "-" + Guid.NewGuid().ToString("N") + newExtension);

            return fileName;
        }

        /// <summary>
        /// 获取扩展名
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        private string GetExtension(FileFormat format)
        {
            var extension = "";

            switch (format)
            {
                case FileFormat.Doc:
                    break;
                case FileFormat.Dot:
                    break;
                case FileFormat.Docx:
                    break;
                case FileFormat.Docx2010:
                    break;
                case FileFormat.Docx2013:
                    break;
                case FileFormat.Dotx:
                    break;
                case FileFormat.Dotx2010:
                    break;
                case FileFormat.Dotx2013:
                    break;
                case FileFormat.Docm:
                    break;
                case FileFormat.Docm2010:
                    break;
                case FileFormat.Docm2013:
                    break;
                case FileFormat.Dotm:
                    break;
                case FileFormat.Dotm2010:
                    break;
                case FileFormat.Dotm2013:
                    break;
                case FileFormat.PDF:
                    extension = ".pdf";
                    break;
                case FileFormat.Rtf:
                    extension = ".rtf";
                    break;
                case FileFormat.Xml:
                    extension = ".xml";
                    break;
                case FileFormat.Txt:
                    break;
                case FileFormat.Html:
                    extension = ".html";
                    break;
                case FileFormat.XPS:
                    break;
                case FileFormat.EPub:
                    break;
                case FileFormat.WordML:
                    break;
                case FileFormat.WordXml:
                    break;
                case FileFormat.DocPre97:
                    break;
                case FileFormat.Auto:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(format), format, null);
            }

            return extension;
        }

        #endregion private
    }
}