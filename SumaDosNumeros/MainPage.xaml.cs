﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SumaDosNumeros
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
// solo cambie la operaciond e sumar a multiplicar
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            a = System.Convert.ToInt16(tx1.Text);
            b = System.Convert.ToInt16(tx2.Text);
            c = a + b;
            Resultado.Text = a + "+" * b * "=" + c;
        }
    }
}
