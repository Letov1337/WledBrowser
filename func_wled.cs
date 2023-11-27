using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using CefSharp.DevTools.Debugger;
using CefSharp.DevTools.CSS;
using System.Text.RegularExpressions;
using System.IO;
using Microsoft.Win32;
using System.Xml.Linq;

namespace brows_esp
{
    public class func_wled
    {
        //функция для прочтения файла setting.txt
        public async Task<string> ReadSettingAsync(string path_setting)
        {
            string line_site = "";

            using (StreamReader f = new StreamReader(path_setting))
            {
                while (!f.EndOfStream)
                {
                    line_site = await f.ReadLineAsync();
                }
            }

            return line_site;
        }
        //функция для прописывание в реестр программы (автозапуск)
        public bool SetAutorunValue(bool autorun,string name_soft)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                {
                    reg.SetValue(name_soft, ExePath);
                }
                else
                {
                    reg.DeleteValue(name_soft);
                }
                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        //функция для вкл/выкл подсветки
        public async Task TurnOnLedStripAsync(string ipAddress, int port, bool on_off)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string jsonContent = "";
                    string url = $"http://{ipAddress}:{port}/json/state";
                    switch (on_off)
                    {
                        case true:
                            jsonContent = "{\"on\":true}";
                            break;
                        case false:
                            jsonContent = "{\"on\":false}";
                            break;
                    }
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                    await client.PostAsync(url, content);
                }
                catch (HttpRequestException)
                {
                    Console.WriteLine("Ошибка при подключении к устройству WLED.");
                }
            }
        }
        //функция для проверки состояние подсветки (включена или нет)
        public async Task<bool> CheckLedStripStatusAsync(string ipAddress, int port)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"http://{ipAddress}:{port}/json/";
                    string response = await client.GetStringAsync(url);
                    if (response.Contains("{\"state\":{\"on\":true"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (HttpRequestException)
                {
                    Console.WriteLine("Ошибка при подключении к устройству WLED.");
                    return false;
                }
            }
        }
        //функция для настройки яркости (изменение яркости от 0 до 255)
        public async Task BrightnessAdjustment(string ipAddress, int port, string brightness_value)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"http://{ipAddress}:{port}/json/state";
                    string currentState = await client.GetStringAsync(url);
                    string newJson = Regex.Replace(currentState, "\"bri\":\\d+", $"\"bri\":{brightness_value}");
                    var content = new StringContent(newJson, Encoding.UTF8, "application/json");
                    await client.PutAsync(url, content);
                }
                catch (HttpRequestException)
                {
                    Console.WriteLine("Ошибка при подключении к устройству WLED.");
                }
            }
        }
    }
}
