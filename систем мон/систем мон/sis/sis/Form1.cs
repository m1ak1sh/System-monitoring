using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using MetroFramework.Forms;
using System.Runtime.InteropServices;

namespace Laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lvMainData.Columns.Add("Название", 305, HorizontalAlignment.Left);
            lvMainData.Columns.Add("Значение", 305, HorizontalAlignment.Left);
        }
        private void tsCB_Click(object sender, EventArgs e)
        {
            tsCB_SelectedIndexChanged(sender, e);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            tsCB.SelectedIndex = 0;
        }
        private void tsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = string.Empty;
            switch (tsCB.SelectedItem) //выбор характеристики из списка
            {
                case "Процессор":
                    key = "Win32_Processor";
                    break;
                case "Видеокарта":
                    key = "Win32_VideoController";
                    break;
                case "Чипсет":
                    key = "Win32_IDEController";
                    break;
                case "Батарея":
                    key = "Win32_Battery";
                    break;
                case "Биос":
                    key = "Win32_BIOS";
                    break;
                case "Оперативная память":
                    key = "Win32_PhysicalMemory";
                    break;
                case "Кэш":
                    key = "Win32_CacheMemory";
                    break;
                case "USB":
                    key = "Win32_USBController";
                    break;
                case "Диск":
                    key = "Win32_DiskDrive";
                    break;
                case "Логические диски":
                    key = "Win32_LogicalDisk";
                    break;
                case "Клавиатура":
                    key = "Win32_Keyboard";
                    break;
                case "Сеть":
                    key = "Win32_NetworkAdapter";
                    break;
                case "Пользователь":
                    key = "Win32_Account";
                    break;
                default:
                    key = "Win32_Processor";
                    break;
            }
            GetHardWareInfo(key, lvMainData); // вызов метода GetHardWareInfo с параметром названия характеристики
        }
        private void GetHardWareInfo(string key, ListView list) // метод для получения данных выбранной характеристики
        {
            list.Items.Clear();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + key);
            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    if (obj.Properties.Count == 0) // сообщение об ошибке, если нет данных
                    {
                        MessageBox.Show("Не удалось получить информацию", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ListViewGroup listViewGroup;
                    try
                    {
                        listViewGroup = list.Groups.Add(obj["Name"].ToString(), obj["Name"].ToString());
                    }
                    catch (Exception ex)
                    {
                        listViewGroup = list.Groups.Add(obj.ToString(), obj.ToString());
                    }
                    foreach (PropertyData data in obj.Properties)
                    {
                        ListViewItem item = new ListViewItem(listViewGroup);
                        if (list.Items.Count % 2 == 0)
                        {
                            item.BackColor = Color.WhiteSmoke;  // для заголовков
                        }
                        item.Text= data.Name;
                        if (data.Value != null &&!string.IsNullOrEmpty(data.Value.ToString()))
                        {
                            string resStr = string.Empty;
                            switch (data.Value.GetType().ToString()) // запись названий и значений
                            {
                                case "System.String[]": // для названий
                                    string[] stringData = data.Value as string[];
                                    foreach (string s in stringData) 
                                    {
                                        resStr += s + " ";
                                    }
                                    item.SubItems.Add(resStr);
                                    break;
                                case "System.UInt16[]": // для значений
                                    ushort[] ushortData = data.Value as ushort[];
                                    foreach (ushort us in ushortData)
                                    {
                                        resStr += us.ToString() + " ";
                                    }
                                    item.SubItems.Add(resStr);
                                    break;
                                default:
                                    item.SubItems.Add(data.Value.ToString());
                                    break;
                            }
                            list.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void tsbSystemMonitor_Click(object sender, EventArgs e)
        {
            new FormSystemMonitor().ShowDialog();
        }
    }
}
