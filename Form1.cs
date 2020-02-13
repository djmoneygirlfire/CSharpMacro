using System;
using System.Runtime.InteropServices; // 이거 있어야 DLLImport 씀
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C샵매크로
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte vk, byte scan, int flags, ref int extrainfo);
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEMOVE = 0x0001;   // 마우스 이동
        private const uint ABSOLUTEMOVE = 0x8000;   // 전역 위치
        private const uint LBUTTONDOWN = 0x0002;   // 왼쪽 마우스 버튼 눌림
        private const uint LBUTTONUP = 0x0004;   // 왼쪽 마우스 버튼 떼어짐

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//            MouseMove(29200,35200);
//            MouseClick();

            MouseMove(29100,44000);
            MouseClick();

            MouseMove(39500,39400);
            MouseClick();

            MouseMove(46000,22500);
            //MouseClick();
        }

        private void MouseMove(uint x, uint y)
        {
            mouse_event(MOUSEMOVE|ABSOLUTEMOVE, x, y, 0, 0);
        }

        private void MouseClick()
        {
            mouse_event(LBUTTONDOWN, 0, 0, 0, 0);
            mouse_event(LBUTTONUP, 0, 0, 0, 0);
        }
    }
}
