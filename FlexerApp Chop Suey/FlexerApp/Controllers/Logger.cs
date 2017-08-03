using FlexerApp.Models;
using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FlexerApp.Controllers
{
    public class Logger
    {
        private IKeyboardMouseEvents m_Events;
        private List<KeyboardMouseLogModel> keyboardMouseLogList = new List<KeyboardMouseLogModel>();

        private const string ACTIVITY_TYPE_APPLICATION = "Application";
        private const string ACTIVITY_TYPE_URL = "URL";

        public void BeginWatching()
        {
            Unsubscribe();
            Subscribe(Hook.GlobalEvents());
        }

        private void Subscribe(IKeyboardMouseEvents events)
        {
            m_Events = events;
            m_Events.KeyPress += HookManager_KeyPress;
            m_Events.MouseClick += HookManager_MouseClick;
        }

        private void Unsubscribe()
        {
            if (m_Events == null) return;

            m_Events.KeyPress -= HookManager_KeyPress;
            m_Events.MouseClick -= HookManager_MouseClick;
            m_Events.Dispose();
            m_Events = null;
        }

        private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Int32 hwnd = 0;
                hwnd = GetForegroundWindow();
                string appProcessName = Process.GetProcessById(GetWindowProcessID(hwnd)).ProcessName;

                if (keyboardMouseLogList.Exists(monitor => monitor.ActivityName == appProcessName))
                {
                    var monitor = keyboardMouseLogList.Where(a => a.ActivityName == appProcessName).OrderByDescending(b => b.StartTime).FirstOrDefault();
                    monitor.KeyStrokeCount++;
                    monitor.InputKey = string.Concat(monitor.InputKey, e.KeyChar.ToString());
                    monitor.EndTime = DateTime.Now;
                }
                else
                {
                    if (keyboardMouseLogList.Count > 0)
                    {
                        //SendMonitoringAsync(monitoringList);
                        keyboardMouseLogList = new List<KeyboardMouseLogModel>();
                    }

                    var monitor = new KeyboardMouseLogModel();
                    monitor.KeyboardMouseLogModelId = Guid.NewGuid().ToString();
                    monitor.ActivityName = appProcessName;
                    monitor.ActivityType = ACTIVITY_TYPE_APPLICATION;
                    monitor.InputKey = e.KeyChar.ToString();
                    monitor.KeyStrokeCount = 1;
                    monitor.MouseClickCount = 0;
                    monitor.StartTime = DateTime.Now;
                    monitor.EndTime = DateTime.Now;
                    monitor.IsSuccessSendToServer = false;

                    keyboardMouseLogList.Add(monitor);
                }

                //CreateMonitoringAsync(monitor);
            }
            catch (Exception ex)
            {

            }
        }

        private void HookManager_MouseClick(object sender, MouseEventArgs e)
        {
            Int32 hwnd = 0;
            hwnd = GetForegroundWindow();
            string appProcessName = Process.GetProcessById(GetWindowProcessID(hwnd)).ProcessName;

            if (keyboardMouseLogList.Exists(monitor => monitor.ActivityName == appProcessName))
            {
                var monitor = keyboardMouseLogList.Where(a => a.ActivityName == appProcessName).OrderByDescending(b => b.StartTime).FirstOrDefault();
                monitor.MouseClickCount++;
                monitor.EndTime = DateTime.Now;
            }
            else
            {
                if (keyboardMouseLogList.Count > 0)
                {
                    //SendMonitoringAsync(monitoringList);
                    keyboardMouseLogList = new List<KeyboardMouseLogModel>();
                }

                var monitor = new KeyboardMouseLogModel();
                monitor.KeyboardMouseLogModelId = Guid.NewGuid().ToString();
                monitor.ActivityName = appProcessName;
                monitor.ActivityType = ACTIVITY_TYPE_APPLICATION;
                monitor.KeyStrokeCount = 0;
                monitor.MouseClickCount = 1;
                monitor.StartTime = DateTime.Now;
                monitor.EndTime = DateTime.Now;
                monitor.IsSuccessSendToServer = false;

                keyboardMouseLogList.Add(monitor);
            }
        }

        private void HookManager_Screenshot()
        {
            Int32 hwnd = 0;
            hwnd = GetForegroundWindow();
            string appProcessName = Process.GetProcessById(GetWindowProcessID(hwnd)).ProcessName;

            var capture = new ScreenshotLogModel();
            capture.ScreenshotLogModelId = Guid.NewGuid().ToString();
            capture.SessionID = 0;
            capture.ActivityName = appProcessName;
            capture.Image = new ScreenCapture().CaptureScreenByteArrayString(System.Drawing.Imaging.ImageFormat.Jpeg);
            capture.CaptureScreenDate = DateTime.Now;
            capture.IsSuccessSendToServer = false;

            //screenCaptureList.Add(capture);

            //SendScreenCapture(screenCaptureList);

            //screenCaptureList = new List<amCapture>();            
        }

        [DllImport("user32.dll")]
        private static extern int GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern UInt32 GetWindowThreadProcessId(Int32 hWnd, out Int32 lpdwProcessId);

        private static Int32 GetWindowProcessID(Int32 hwnd)
        {
            Int32 pid = 1;
            GetWindowThreadProcessId(hwnd, out pid);
            return pid;
        }
    }
}
