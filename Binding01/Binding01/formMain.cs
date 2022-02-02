using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// ComboBox data들을 Dictionary를 사용하여  bindingSource로 데이터 묶기
/// </summary>
namespace Binding01
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> keyValues = new Dictionary<string,string>();
            keyValues.Add("1", "First");
            keyValues.Add("2", "Second");

            cbTest.DataSource = new BindingSource(keyValues, null);
            cbTest.ValueMember = "Key";
            cbTest.DisplayMember = "Value";
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbTest.Text);
            //MessageBox.Show(cbTest.SelectedText);
            /*콤보 상자에서 현재 선택되어 있는 텍스트를 나타냄
             * DropDownStyle을 DropDownList으로 설정하면 빈 문자열("")이 반환됩니다.
             * 고로 현 시점에서는 적용안되는 함수*/
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbTest.SelectedValue.ToString());
        }
    }
}
