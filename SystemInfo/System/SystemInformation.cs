﻿using System;
using System.Collections.Generic;

namespace SystemInfo
{
    [Serializable]
    public class SystemInformation
    {
        private string _owener = string.Empty;
        public string Owner
        {
            get { return _owener; }
            set { _owener = value; }
        }

        private ProcessorInformation _processor = new ProcessorInformation();

        public ProcessorInformation Processor
        {
            get { return _processor; }
        }

        private RamInformation _ram = new RamInformation();

        public RamInformation Ram
        {
            get { return _ram; }
        }

        private GraphicCardInformation _graphicCard = new GraphicCardInformation();

        public GraphicCardInformation GraphicCard
        {
            get { return _graphicCard; }
        }

        private MotherboardInformation _matherboard = new MotherboardInformation();

        public MotherboardInformation Matherboard
        {
            get { return _matherboard; }
        }

        private HardDiskInformation _hardDisks = new HardDiskInformation();

        public HardDiskInformation HardDisks
        {
            get { return _hardDisks; }
        }

        //private NetworkAdapterInformation _newtworkAdapters = new NetworkAdapterInformation();
        //public NetworkAdapterInformation NewtworkAdapters
        //{
        //    get { return _newtworkAdapters; }
        //}

        private OperatingSystemInformation _operatingSystem = new OperatingSystemInformation();

        public OperatingSystemInformation OperatingSystem
        {
            get { return _operatingSystem; }
        }

        public string ToCSV()
        {
            return string.Format("{0};{1};{2};{3};{4};{5};{6};",
                Owner,
                Processor.ToCSV(),
                Ram.ToCSV(),
                GraphicCard.ToCSV(),
                Matherboard.ToCSV(),
                HardDisks.ToCSV(),
                OperatingSystem.ToCSV());
        }
    }
}