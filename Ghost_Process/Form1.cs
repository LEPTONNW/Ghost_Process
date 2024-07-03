using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Ghost_Process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static ArrayList handleArray = new ArrayList();
        private void PRC_btn_Click(object sender, EventArgs e)
        {
            try
            {
                prc_show_btn.Enabled = false;

                if (hide_prc_list.Items.Count == 0)
                {
                    prc_hide_btn.Enabled = true;


                    handleArray.Clear();
                    prc_list.Items.Clear();

                    Process[] allProc = Process.GetProcesses();
                    int i = 1;
                    //prc_list.Items.Add("****** 모든 프로세스 정보 ******" + Environment.NewLine);
                    label1.Text = "현재 실행중인 모든 프로세스 수 : " + allProc.Length;

                    foreach (Process p in allProc)
                    {
                        if (!String.IsNullOrEmpty(p.MainWindowTitle))
                        {
                            //프로세스 별로 MainWindow 에 대한 핸들값 저장
                            IntPtr mhandle = p.MainWindowHandle;
                            handleArray.Add(mhandle.ToInt32());

                            //프로세스 이름 리스트박스에 출력
                            prc_list.Items.Add(i++ + "번째 프로세스 이름 : " + p.ProcessName + Environment.NewLine);
                        }
                    }
                }
                else
                {
                    prc_hide_btn.Enabled = false;

                    prc_list.Items.Clear();

                    Process[] allProc = Process.GetProcesses();
                    int i = 1;
                    //prc_list.Items.Add("****** 모든 프로세스 정보 ******" + Environment.NewLine);
                    label1.Text = "현재 실행중인 모든 프로세스 수 : " + allProc.Length;

                    foreach (Process p in allProc)
                    {
                        if (!String.IsNullOrEmpty(p.MainWindowTitle))
                        {
                            //프로세스 별로 MainWindow 에 대한 핸들값 저장
                            IntPtr mhandle = p.MainWindowHandle;
                            handleArray.Add(mhandle.ToInt32());

                            //프로세스 이름 리스트박스에 출력
                            prc_list.Items.Add(i++ + "번째 프로세스 이름 : " + p.ProcessName + Environment.NewLine);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        [DllImport("user32")]
        public static extern int ShowWindow(int hwnd, int nCmdShow);
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;

        //프로세스 표시 핸들값 리스트
        public static List<int> handle_list = new List<int>();
        //프로세스 숨기기
        private void prc_hide_btn_Click(object sender, EventArgs e)
        {
            try
            {
                prc_show_btn.Enabled = true;

                if (prc_list.SelectedItem != null)
                {
                    //[1]번째 프로세스 : 프로세스 이름 에서 "이름" 분리
                    string[] temp = prc_list.SelectedItem.ToString().Split(':');

                    //문자열 공백제거
                    string result = temp[1].Replace(" ", string.Empty);

                    //temp[1] = 프로세스 이름
                    hide_prc_list.Items.Add(temp[0] + " : " + result);

                    string[] temp2 = temp[0].Split('번');

                    //MessageBox.Show(temp2[0]); //1번부터 시작확인

                    //MessageBox.Show(prc_list.SelectedIndex.ToString()); //0번부터 시작 확인
                    //Hide 처리
                    ShowWindow((int)handleArray[prc_list.SelectedIndex], SW_HIDE);

                    //핸들값 리스트저장
                    handle_list.Add(prc_list.SelectedIndex);

                    //테스트구간

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //프로세스 보이기 버튼
        private void prc_show_btn_Click(object sender, EventArgs e)
        {
            try
            {

                string[] temp = hide_prc_list.SelectedItem.ToString().Split(':');
                string result = temp[1].Replace(" ", string.Empty);

                string[] temp2 = temp[0].Split('번');

                //왜인지는 몰라도 "핸들값-1 = 프로세스 번호" 로 됨 listbox 번호가 0번부터 시작해서 그런가봄
                //핸들값 리스트에서 제거

                //Show 처리
                ShowWindow((int)handleArray[Convert.ToInt32(temp2[0]) - 1], SW_SHOW);

                if (handle_list.Count == 1)
                {
                    handle_list.Clear();

                    //MessageBox.Show(handle_list.Count.ToString());
                    //테스트구간
                }
                else
                {
                    handle_list.Remove(Convert.ToInt32(temp2[0]) - 1);

                    //테스트구간
                }

                hide_prc_list.Items.Remove(hide_prc_list.SelectedItem);

                this.Focus();
            }

            catch (Exception ex2)
            {
                MessageBox.Show(ex2.ToString());
            }
        }

        private void prc_showall_btn_Click(object sender, EventArgs e)
        {
            foreach (int a in handle_list)
            {
                ShowWindow((int)handleArray[a], SW_SHOW);
            }
            hide_prc_list.Items.Clear();
            PRC_btn_Click(sender, e);
            handle_list.Clear();
            //handleArray.Clear();

            prc_hide_btn.Enabled = false;
            this.Focus();
        }

        public static void Hide_prc()
        {
            try
            {
                foreach (int a in handle_list)
                {
                    ShowWindow((int)handleArray[a], SW_HIDE);
                }
            }
            catch (Exception p1)
            {
                MessageBox.Show(p1.ToString());
            }
            //this.Focus();
        }

        public static void Show_prc()
        {
            try
            {
                foreach (int a in handle_list)
                {
                    ShowWindow((int)handleArray[a], SW_SHOW);
                }
            }
            catch (Exception p2)
            {
                MessageBox.Show(p2.ToString());
            }
            //this.Focus();
        }

        //////////////////////////////////////////////////////////
        //////////////////전역 키보드 후킹////////////////////////
        //////////////////////////////////////////////////////////

        public static String First_key1 = "";
        public static String Second_Key1 = "";

        public static String First_key2 = "";
        public static String Second_Key2 = "";

        private static int _hookID = 0;
        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static HookProc _proc = HookCallback;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(int hhk);
        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(int hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);


        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        private void Form1_Load(object sender, EventArgs e)
        {
            //후킹시작
            SetHook();
            
            //지역후킹 텍스트상자 수정금지
            Hide_text.ReadOnly = true;
            Show_text.ReadOnly = true;

            notifyIcon1.Visible = true;//트레이 아이콘 표시

            prc_show_btn.Enabled = false;
            prc_hide_btn.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unhook();
            //base.OnFormClosed(e);
        }

        private void SetHook()
        {
            _hookID = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0);
        }

        private void Unhook()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            //키가 하나라도 지정되어있지 않으면 값을 넘겨보낸다.
            if (String.IsNullOrEmpty(First_key1) || String.IsNullOrEmpty(Second_Key1) || String.IsNullOrEmpty(First_key2) || String.IsNullOrEmpty(Second_Key2))
            {
                if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
                {
                    int vkCode = Marshal.ReadInt32(lParam);
                }
                return CallNextHookEx(_hookID, nCode, wParam, lParam);
            }

            else
            {
                if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
                {
                    int vkCode = Marshal.ReadInt32(lParam);

                    //입력받은 문자열을 Keys로 변환한다.
                    //Keys temp = (Keys)Enum.Parse(typeof(Keys), "입력문자열", true);
                    Keys FirstKey1 = (Keys)Enum.Parse(typeof(Keys), First_key1, true);
                    Keys SecondKey1 = (Keys)Enum.Parse(typeof(Keys), Second_Key1, true);

                    Keys FirstKey2 = (Keys)Enum.Parse(typeof(Keys), First_key2, true);
                    Keys SecondKey2 = (Keys)Enum.Parse(typeof(Keys), Second_Key2, true);


                    //보임 및 숨김 단축키 작동
                    //if ((Control.ModifierKeys & Keys.Control) == Keys.Control && vkCode == (int)Keys.F1)
                    if ((Control.ModifierKeys & FirstKey1) == FirstKey1 && vkCode == (int)SecondKey1)
                    {
                        Hide_prc();
                    }
                    else if ((Control.ModifierKeys & FirstKey2) == FirstKey2 && vkCode == (int)SecondKey2)
                    {
                        Show_prc();
                    }
                }
                return CallNextHookEx(_hookID, nCode, wParam, lParam);
            }
        }

        //////////////////////////////////////////////////////////
        //////////////////지역 키보드 후킹////////////////////////
        //////////////////////////////////////////////////////////

        public int KeyCounter1 = 0;
        public int KeyCounter2 = 0;
        private void Hide_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (KeyCounter1 < 2)
            {
                String KeyTemp = e.KeyCode.ToString();
                if (String.IsNullOrEmpty(Hide_text.Text))
                {
                    Hide_text.Text = KeyTemp;
                }
                else
                {
                    Hide_text.Text += "+" + KeyTemp;
                }

                KeyCounter1++;
            }
            else
            {
                KeyCounter1 = 0;
                Hide_text.Text = "";
            }
        }

        private void Hide_text_Enter(object sender, EventArgs e)
        {
            Hide_text.Text = "";
        }
        private void Show_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (KeyCounter2 < 2)
            {
                String KeyTemp = e.KeyCode.ToString();
                if (String.IsNullOrEmpty(Show_text.Text))
                {
                    Show_text.Text = KeyTemp;
                }
                else
                {
                    Show_text.Text += "+" + KeyTemp;
                }

                KeyCounter2++;
            }
            else
            {
                KeyCounter2 = 0;
                Show_text.Text = "";
            }
        }
        private void Show_text_Enter(object sender, EventArgs e)
        {
            Show_text.Text = "";
        }
        private void HotKey_Save_btn_Click(object sender, EventArgs e)
        {
            //'+' 를 기준으로 두개의 조합키로 분리
            String[] Hide_arr = Hide_text.Text.Split('+');
            String[] Show_arr = Show_text.Text.Split('+');

            //변환된 Keys 저장공간
            List<String> Hide_List = new List<String>();
            List<String> Show_List = new List<String>();

            //vkcode 에서 Keys 열거형으로 변환하는 작업
            foreach (String Hide_str in  Hide_arr)
            {
                if(Hide_str == "ControlKey")
                {
                    Hide_List.Add("Control");
                }
                else if(Hide_str == "Menu")
                {
                    Hide_List.Add("Alt");
                }
                else if (Hide_str == "ShiftKey")
                {
                    Hide_List.Add("Shift");
                }
                else
                {
                    Hide_List.Add(Hide_str);
                }
            }

            foreach (String Show_str in Show_arr)
            {
                if (Show_str == "ControlKey")
                {
                    Show_List.Add("Control");
                }
                else if (Show_str == "Menu")
                {
                    Show_List.Add("Alt");
                }
                else if (Show_str == "ShiftKey")
                {
                    Show_List.Add("Shift");
                }
                else
                {
                    Show_List.Add(Show_str);
                }
            }

            //변환된 Keys를 String(Keys) 에 저장한다.
            for(int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    First_key1 = Hide_List[i].ToString();
                    First_key2 = Show_List[i].ToString();
                }
                else
                {
                    Second_Key1 = Hide_List[i].ToString();
                    Second_Key2 = Show_List[i].ToString();
                }
            }

            MessageBox.Show("단축키가 저장되었습니다.");
        }

        private void Tray_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 폼을 표시하지 않는다;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true; // 폼의 표시
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal; // 최소화를 멈춘다 
            this.Activate(); // 폼을 활성화 시킨다
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unhook();
            Application.Exit();
        }
    }
}
