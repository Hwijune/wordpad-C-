using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordpad
{
    public partial class Form1 : Form
    {
        Form3 f3 = new Form3();
        private Boolean textchange = false;
        public int nowtextsize = 8; // 현재 폰트 사이즈
        public string nowfont = "Georgia"; //현재 폰트 글자체
        Font font;
        public Boolean 첨자onoff = false;
        public Form4 frm4;
        public Form5 frm5;
        private string fWord; // 찾기 문자열
        private string ffWord; // 바꾸기 문자열

        public Form1()
        {
            InitializeComponent();
        }

        private void textSave()
        {
            if (this.Text == "제목없음")
            {
                var dlr = this.saveFileDialog1.ShowDialog();
                if (dlr != DialogResult.Cancel)
                {
                    var str = this.saveFileDialog1.FileName;
                    var sw = new StreamWriter(str, false, System.Text.Encoding.Default);
                    sw.Write(this.richTextBox1.Text);
                    sw.Flush();
                    sw.Close();
                    var f = new FileInfo(str);
                    this.Text = f.Name;
                    this.textchange = false;
                }
            }
            else
            {
                var strt = this.Text;
                var sw = new StreamWriter(strt, false, System.Text.Encoding.Default);
                sw.Write(this.richTextBox1.Text);
                sw.Flush();
                sw.Close();
                this.Text = strt;
                this.textchange = false;
            }
        }

        private void textOpen()
        {
            var dr = this.openFileDialog1.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                var str = this.openFileDialog1.FileName;
                var sr = new StreamReader(str, System.Text.Encoding.Default);
                this.richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                var f = new FileInfo(str);
                this.Text = f.Name;
                this.textchange = false;
            }
        }

        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textchange)
            {
                var dlr = MessageBox.Show("파일의 내용이 변경되었습니다. \r\n 변경된 내용을 저장하시겠습니까?", "wordpad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dlr == DialogResult.Yes)
                {
                    textSave();
                    this.richTextBox1.ResetText();
                    this.Text = "제목없음";
                }
                else if (dlr == DialogResult.No)
                {
                    this.richTextBox1.ResetText();
                    this.Text = "제목없음";
                    this.textchange = false;
                }
                else
                {
                    return;
                }
            }
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textOpen();
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSave();
            this.textchange = false;
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlr = this.saveFileDialog1.ShowDialog();
            if (dlr != DialogResult.Cancel)
            {
                var str = this.saveFileDialog1.FileName;
                var sw = new StreamWriter(str, false, System.Text.Encoding.Default);
                sw.Write(this.richTextBox1.Text);
                sw.Flush();
                sw.Close();
                var f = new FileInfo(str);
                this.Text = f.Name;
                this.textchange = false;
            }
        }

        private void 워드패드정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.textchange = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.textchange == true)
            {
                e.Cancel = true;

                var ret = MessageBox.Show("파일의 내용이 변경되었습니다.\n변경된 내용을 저장하시겠습니까?",
                    "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                    textSave();
                    this.Dispose();
                }
                else if (ret == DialogResult.No)
                {
                    this.Dispose();
                }
                else
                {
                    return;
                }
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e) //붙여넣기
        {
            richTextBox1.Paste();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)  //잘라내기
        {
            richTextBox1.Cut();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) //복사
        {
            richTextBox1.Copy();
        }

        /////////////

        
        private void toolStripButton13_Click(object sender, EventArgs e) //내어쓰기
        {
            richTextBox1.SelectionIndent -= 8;
        }

        private void toolStripButton14_Click(object sender, EventArgs e) //들여쓰기
        {
            richTextBox1.SelectionIndent += 8;
        }

        int a = 1;
        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e) //글머리기호
        {

            if (a == 1)
            {
                richTextBox1.SelectionBullet = true;
                a = 0;
            }
            else
            {
                richTextBox1.SelectionBullet = false;
                a = 1;
            }
        }

        int b = 1;
        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e) //줄간격
        {
            if (b == 1) {
                richTextBox1.SelectionCharOffset = 8;
                b = 0;
            }
            else
            {
                richTextBox1.SelectionCharOffset = 0;
                b = 1;
            }

        }

        private void toolStripButton19_Click(object sender, EventArgs e) //왼정렬
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton15_Click(object sender, EventArgs e) //가운데정렬
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton16_Click(object sender, EventArgs e) //오른정렬
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton17_Click(object sender, EventArgs e) //양쪽정렬
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }


        private void button1_Click(object sender, EventArgs e) //단락 이벤트
        {
            int a = int.Parse(f3.textBox1.Text);
            int b = int.Parse(f3.textBox2.Text);

            richTextBox1.SelectionIndent += b;
            richTextBox1.SelectionIndent += a;

            if (f3.comboBox1.SelectedIndex == 0)
            {
                richTextBox1.SelectionCharOffset = 8;
            }
            else
            {
                richTextBox1.SelectionCharOffset = 0;
            }
            if (f3.comboBox2.SelectedIndex == 0)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            else if (f3.comboBox2.SelectedIndex == 1)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
            else
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void toolStripButton18_Click_1(object sender, EventArgs e) //단락
        {
            f3.button1.Click += new System.EventHandler(this.button1_Click);
            f3.Show();
        }

        int c = 1;
        private void 보기ToolStripMenuItem_Click(object sender, EventArgs e) //보기탭 켜고끄기
        {
            if (c == 1)
            {
                toolStripContainer2.Visible = true;
                c = 0;
            }
            else
            {
                toolStripContainer2.Visible = false;
                c = 1;
            }
        }

        private void toolStripButton26_Click(object sender, EventArgs e) //확대
        {
            richTextBox1.ZoomFactor += 1.0f;
        }

        private void toolStripButton27_Click(object sender, EventArgs e) //축소
        {
            richTextBox1.ZoomFactor -= 1.0f;
        }

        private void toolStripButton28_Click(object sender, EventArgs e) //100%
        {
            richTextBox1.ZoomFactor = 1.0f;
        }

        int d = 1;
        private void toolStripButton31_Click(object sender, EventArgs e) //상태표시줄
        {
            if (d == 1)
            {
                statusStrip1.Visible = false;
                d = 0;
            }
            else
            {
                statusStrip1.Visible = true;
                d = 1;
            }
        }

        int f = 1;
        private void toolStripButton30_Click(object sender, EventArgs e) //자동줄바꿈
        {
            if(f == 1)
            {
                this.richTextBox1.WordWrap = !(this.richTextBox1.WordWrap);
                f = 0;
            }
            else
            {
                this.richTextBox1.WordWrap = (this.richTextBox1.WordWrap);
                f = 1;
            }
        }
        
        private void 글꼴패밀리_Click(object sender, EventArgs e)
        {
            var s = this.글꼴패밀리.SelectedItem.ToString();
            nowfont = s;
            font = new Font(nowfont, nowtextsize);

            if (this.richTextBox1.SelectionLength == 0)
            {
                richTextBox1.Font = font;
            }
            else
            {
                richTextBox1.SelectionFont = font;
            }
        }

        private void 글꼴크기_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = Convert.ToInt32(this.글꼴크기.SelectedItem.ToString());
            nowtextsize = s;
            font = new Font(nowfont, nowtextsize);

            if (this.richTextBox1.SelectionLength == 0)
            {
                richTextBox1.Font = font;
            }
            else
            {
                richTextBox1.SelectionFont = font;
            }
        }

        private void 글꼴크기늘림_Click(object sender, EventArgs e)
        {
            nowtextsize++;
            font = new Font(nowfont, nowtextsize);
            if (this.richTextBox1.SelectionLength == 0)
            {
                richTextBox1.Font = font;
            }
            else
            {
                richTextBox1.SelectionFont = font;
            }
        }

        private void 글꼴크기줄임_Click(object sender, EventArgs e)
        {
            nowtextsize--;
            font = new Font(nowfont, nowtextsize);
            if (this.richTextBox1.SelectionLength == 0)
            {
                richTextBox1.Font = font;
            }
            else
            {
                richTextBox1.SelectionFont = font;
            }
        }

        private void 굵게_Click(object sender, EventArgs e)
        {
            font = new Font(nowfont, nowtextsize, FontStyle.Bold);
            if (this.richTextBox1.SelectionLength == 0)
            {
                richTextBox1.Font = font;
            }
            else
            {
                richTextBox1.SelectionFont = font;
            }
        }

        private void 기울임꼴_Click(object sender, EventArgs e)
        {
            font = new Font(nowfont, nowtextsize, FontStyle.Italic);
            if (this.richTextBox1.SelectionLength == 0)
            {
                richTextBox1.Font = font;
            }
            else
            {
                richTextBox1.SelectionFont = font;
            }
        }

        private void 밑줄_Click(object sender, EventArgs e)
        {
            font = new Font(nowfont, nowtextsize, FontStyle.Underline);
            if (this.richTextBox1.SelectionLength == 0)
            {
                richTextBox1.Font = font;
            }
            else
            {
                richTextBox1.SelectionFont = font;
            }
        }

        private void 취소선_Click(object sender, EventArgs e)
        {
            font = new Font(nowfont, nowtextsize, FontStyle.Strikeout);
            if (this.richTextBox1.SelectionLength == 0)
            {
                richTextBox1.Font = font;
            }
            else
            {
                richTextBox1.SelectionFont = font;
            }
        }

        private void 아래첨자_Click(object sender, EventArgs e)
        {
            if (첨자onoff == false)
            {
                richTextBox1.SelectionCharOffset = -10;
                첨자onoff = true;
            }
            else
            {
                richTextBox1.SelectionCharOffset = 0;
                첨자onoff = false;
            }
        }

        private void 위첨자_Click(object sender, EventArgs e)
        {
            if (첨자onoff == false)
            {
                richTextBox1.SelectionCharOffset = -10;
                첨자onoff = true;
            }
            else
            {
                richTextBox1.SelectionCharOffset = 0;
                첨자onoff = false;
            }
        }

        private void 텍스트색_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.richTextBox1.SelectionLength == 0)
                {
                    richTextBox1.ForeColor = colorDialog1.Color;
                }
                else
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
            }
        }
        private void 찾기_Click(object sender, EventArgs e)
        {
            if (!(frm4 == null || !frm4.Visible))
            {
                frm4.Focus();
                return;
            }
            frm4 = new Form4();

            if (this.richTextBox1.SelectionLength == 0)
            {
                frm4.txtWord.Text = this.fWord;
            }
            else
            {
                frm4.txtWord.Text = this.richTextBox1.SelectedText;
            }
            frm4.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            frm4.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var updown = -1;
            var str = this.richTextBox1.Text; //본문 저장
            var findWord = frm4.txtWord.Text; //찾을 문자열 저장

            if (!frm4.chb.Checked)
            {
                str = str.ToUpper(); //저장된 본문을 대문자로 변환
                findWord = findWord.ToUpper();
            }

            if (frm4.rdb01.Checked)
            {
                if (this.richTextBox1.SelectionStart != 0)
                {
                    updown = str.LastIndexOf(findWord, this.richTextBox1.SelectionStart - 1);
                }
            }
            else
            {
                updown = str.IndexOf(findWord, this.richTextBox1.SelectionStart + this.richTextBox1.SelectionLength);
            }

            if (updown == -1)
            {
                MessageBox.Show("더 이상 찾는 문자열이 없습니다.", "메모장", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.richTextBox1.Select(updown, findWord.Length);
            fWord = frm4.txtWord.Text;
            this.richTextBox1.Focus();
            this.richTextBox1.ScrollToCaret();
        }

        private void 모두선택_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 바꾸기_Click(object sender, EventArgs e)
        {
            if (!(frm5 == null || !frm5.Visible))
            {
                frm5.Focus();
                return;
            }
            frm5 = new Form5();

            if (this.richTextBox1.SelectionLength == 0)
            {
                frm5.txtWord.Text = this.fWord;
            }
            else
            {
                frm5.txtWord.Text = this.richTextBox1.SelectedText;
            }
            frm5.btnOk.Click += new System.EventHandler(this.바꾸기btnOk_Click);
            frm5.btnOk2.Click += new System.EventHandler(this.바꾸기2btnOk_Click);
            frm5.Show();
        }

        private void 바꾸기btnOk_Click(object sender, EventArgs e)
        {
            var updown = -1;
            var str = this.richTextBox1.Text; //본문 저장
            var findWord = frm5.txtWord.Text; //찾을 문자열 저장

            if (!frm5.chb.Checked)
            {
                str = str.ToUpper(); //저장된 본문을 대문자로 변환
                findWord = findWord.ToUpper();
            }


            if (this.richTextBox1.SelectionStart != 0)
            {
                updown = str.LastIndexOf(findWord, this.richTextBox1.SelectionStart - 1);
            }

            if (!frm5.chb.Checked)
            {
                findWord = findWord + " "; //파인드워드 한칸띄워서 단어로 만들기
            }

            if (updown == -1)
            {
                MessageBox.Show("문서 검색을 마쳤습니다.", "바꾸기", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.richTextBox1.Select(updown, findWord.Length - 1);
            ffWord = frm5.txtWord.Text;
            this.richTextBox1.Focus();
            this.richTextBox1.ScrollToCaret();
        }

        private void 바꾸기2btnOk_Click(object sender, EventArgs e)
        {
            var updown = -1;
            var str = this.richTextBox1.Text; //본문 저장
            var findWord = frm5.txtWord.Text; //찾을 문자열 저장

            if (frm5.chb.Checked)
            {
                str = str.ToUpper(); //저장된 본문을 대문자로 변환
                findWord = findWord.ToUpper();
            }

            if (this.richTextBox1.SelectionStart != 0)
            {
                updown = str.LastIndexOf(findWord, this.richTextBox1.SelectionStart - 1);
            }

            if (!frm5.chb.Checked)
            {
                findWord = findWord + " "; //파인드워드 한칸띄워서 단어로 만들기
            }

            if (updown == -1)
            {
                MessageBox.Show("문서 검색을 마쳤습니다.", "바꾸기", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.richTextBox1.Select(updown, findWord.Length - 1);
            ffWord = frm5.txtWord1.Text; //찾아바꿀단어
            string indexleft = str.Substring(0, updown - 1); //바꿀문장 앞부분
            string indexright = str.Substring(updown + findWord.Length); //문장뒷부분

            this.richTextBox1.Text = indexleft + ffWord + indexright; //세개합치기
        }

        private void 텍스트강조색_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.richTextBox1.SelectionLength == 0)
                {
                    richTextBox1.BackColor = colorDialog1.Color;
                }
                else
                {
                    richTextBox1.SelectionBackColor = colorDialog1.Color;
                }
            }
        }
    }
}
