﻿using ConsoleAppCrafting.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealCraftProject.classes
{
    public class Elixer : Item
    {
        public string ElixerName { get; set; }
        public Elixer()
        {
            this.ElixerName = "Rejuvinating Elixer";
        }
    }
}
