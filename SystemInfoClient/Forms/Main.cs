﻿using System;
using System.Windows.Forms;
using Networning;

using System.Net;
using System.Net.Sockets;

namespace SystemInfoClient
{
    public partial class Main : Form
    {
        private SystemInfo.SystemInformation _info = null;
        private ServerAdressConfig _serverAdress = null;
        private Client _client = null;

        public Main(SystemInfo.SystemInformation info, ServerAdressConfig serverAdress, Client client)
        {
            InitializeComponent();
            _info = info;
            _serverAdress = serverAdress;
            _client = client;

            processorInfo.DataBindings.Add("Text", _info.Processor, "Informatioin");
            ramInfo.DataBindings.Add("Text", _info.Ram, "Informatioin");
            graphicCardInfo.DataBindings.Add("Text", _info.GraphicCard, "Informatioin");
            motherboardInfo.DataBindings.Add("Text", _info.Matherboard, "Informatioin");
            hardDisksInfo.DataBindings.Add("Text", _info.HardDisks, "Informatioin");
            //networkAdapterInfo.DataBindings.Add("Text", _info.NewtworkAdapters, "Informatioin");
            operatingSystemInfo.DataBindings.Add("Text", _info.OperatingSystem, "Informatioin");
        }

        private void sendInfo_Click(object sender, EventArgs e)
        {
            //_info
            _client.IPAdress = _serverAdress.IP;
            _client.Port = _serverAdress.Port;
            _client.Initialize();
            _client.Send(_info);
        }

        private void config_Click(object sender, EventArgs e)
        {
            Config configuration = new Config(_serverAdress, ServerAdressConfig.Server_Adress_Congig_File_Name);
            configuration.ShowDialog();
            _info.Owner = _serverAdress.Name;
        }


    }
}