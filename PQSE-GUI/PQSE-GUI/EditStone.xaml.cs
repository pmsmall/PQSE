﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PQSE_GUI
{
    /// <summary>
    /// Interaktionslogik für EditStone.xaml
    /// </summary>
    public partial class EditStone : Window
    {
        private StoneData stoneResult;
        public EditStone(StoneData stone)
        { 
            InitializeComponent();

            //InitColorBox();
            //InitCategoryBox();
            stoneResult = stone;

            txt_stoneVal.Text = stoneResult.stoneData[92].ToString();
        }
        internal StoneData GetStoneResult()
        {
            return stoneResult;
        }

        private void saveStone_Click(object sender, RoutedEventArgs e)
        {
            int nVal = 0;
            int resultVal = 0;

            int numba = Convert.ToInt32(txt_stoneVal.Text);


            int ns = 0;
            for(int i = 0; i < numba-256; i+=256)
            {
                ns++;
            }



            stoneResult.stoneData[93] = Convert.ToByte(ns);
            stoneResult.stoneData[92] = Convert.ToByte(resultVal);




            this.DialogResult = true;
        }
    }
}
