﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verstoppertje_App
{
    public partial class gameSettings_Page : Form
    {
        public gameSettings_Page()
        {
            InitializeComponent();
        }

        private void returnMain_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            userMain_Page MainMenu = new userMain_Page();
            MainMenu.Closed += (s, args) => this.Close();
            MainMenu.Show();
        }

        private void startGame_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string Difficulty = difficulty_comboBox.SelectedItem.ToString();
                
                if (Difficulty == "Easy")
                {

                    var easyMode = new easyDifficultyFloorplan_UserControl();
                    mainGame_panel.Controls.Add(easyMode);
                }
                if (Difficulty == "Meduim")
                {

                }
                if (Difficulty == "Hard")
                {

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please fill in all game settings before pressing play", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}