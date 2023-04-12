using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        private GMapOverlay markersOverlay;
        public LoginForm()
        {
            InitializeComponent();

            btnLoad.Click += btnLoad_Click;

            markersOverlay = new GMapOverlay("markers");
            gMapControl1.Overlays.Add(markersOverlay);

            gMapControl1.CacheLocation = @"C:\GMAPCACHE";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
        }



        class ParsingF
        {
            [Newtonsoft.Json.JsonProperty("device_id")]
            public string device_id { get; set; }
            [Newtonsoft.Json.JsonProperty("gps_speed")]
            public float gps_speed { get; set; }
            [Newtonsoft.Json.JsonProperty("lon")]
            public double lon { get; set; }
            [Newtonsoft.Json.JsonProperty("lat")]
            public double lat { get; set; }
        }

        private bool _shouldRun = true;
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            _shouldRun = true;

            while (_shouldRun)
            {
                // Очищаем старые маркеры
                markersOverlay.Markers.Clear();
                // Очищаем текстовое поле перед выводом новой информации
                InfoAboutLocation.Clear();
                // Задаем путь к директории с файлами .json
                string directoryPath = @"C:\jsoni";
                // Задаем маску имени для файлов .json
                string searchPattern = "*.json";
                // Ищем файлы, соответствующие маске имени
                string[] fileNames = Directory.GetFiles(directoryPath, searchPattern);

                int fileCount = Directory.GetFiles(directoryPath, searchPattern).Length;
                if (fileCount == 0)
                {
                    _shouldRun = false;
                    break;
                }

                Array.Sort(fileNames, (a, b) => File.GetCreationTime(a).CompareTo(File.GetCreationTime(b)));
                string oldestFileName = fileNames.FirstOrDefault();

                if (!string.IsNullOrEmpty(oldestFileName))
                {
                    if (_shouldRun == false)
                    {
                        break;
                    }

                    string json = File.ReadAllText(oldestFileName);
                    ParsingF myObject = JsonConvert.DeserializeObject<ParsingF>(json);

                    // Добавляем данные в текстовое поле на форме
                    InfoAboutLocation.AppendText("Device ID: " + myObject.device_id + Environment.NewLine);
                    InfoAboutLocation.AppendText("Speed: " + myObject.gps_speed.ToString() + Environment.NewLine);
                    InfoAboutLocation.AppendText("Lat: " + myObject.lat.ToString() + Environment.NewLine);
                    InfoAboutLocation.AppendText("Lon: " + myObject.lon.ToString() + Environment.NewLine);
                    InfoAboutLocation.AppendText(Environment.NewLine);

                    GMarkerGoogle marker = new GMarkerGoogle(
                    new PointLatLng(myObject.lat, myObject.lon), GMarkerGoogleType.red);
                    markersOverlay.Markers.Add(marker);
                    gMapControl1.Position = marker.Position;
                    gMapControl1.Refresh();

                    // Удаляем файл после его обработки
                    File.Delete(oldestFileName);
                    await Task.Delay(1000);
                    
                } 
            }
          
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            _shouldRun = false;
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void close_but_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //выбор подгрузки карты – онлайн или из ресурсов
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //какой провайдер карт используется (в нашем случае гугл) 
            gMapControl1.MinZoom = 2; //минимальный зум
            gMapControl1.MaxZoom = 20; //максимальный зум
            gMapControl1.Zoom = 18; // какой используется зум при открытии
            gMapControl1.Position = new GMap.NET.PointLatLng(55.7558, 37.6173);// точка в центре карты при открытии (центр России)
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // как приближает (просто в центр карты или по положению мыши)
            gMapControl1.CanDragMap = true; // перетаскивание карты мышью
            gMapControl1.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
            gMapControl1.ShowCenter = false; //показывать или скрывать красный крестик в центре
            gMapControl1.ShowTileGridLines = false; //показывать или скрывать тайлы

        }

    }
}
