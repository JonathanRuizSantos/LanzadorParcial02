using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_LanzadorParcial2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuFirma_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WpfRuizSantos.exe");
        }

        private void MenuSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void PDFApuntes_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("ApuntesParcial02.pdf");
        }

        private void MP1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("GraficadorV1_P20.exe");
        }

        private void MP2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("GraficadorV1_P21.exe");
        }

        private void MP3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("GraficadorV1_P22.exe");
        }

        private void MP4_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("GraficadorV4_P23.exe");
        }

        private void MP5_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("GraficadorV6_P24.exe");
        }

        private void MP6_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("GraficadorV7_P25.exe");
        }

        private void MP7_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WF_Controles_P26.exe");
        }

        private void MP8_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WF_Controles_P27.exe");
        }

        private void MP9_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WpfRuizSantos_P28.exe");
        }

        private void MP10_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WpfRuizSantos_P29.exe");
        }

        private void MP11_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Conpilacion_P30.jpg");
        }

        private void MP12_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Conpilacion_P31.jpg");
        }

        private void MP13_Click(object sender, RoutedEventArgs e)
        {
            //System.Diagnostics.Process.Start("P32.exe");
            MessageBox.Show("Ocurrio un error...");
        }

        private void MP14_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WFMatDaraGrig_P33.exe");
        }

        private void MP15_Click(object sender, RoutedEventArgs e)
        {
            //System.Diagnostics.Process.Start("P34.exe");
            MessageBox.Show("Ocurrio un error...");
        }

        private void MP16_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("ConsolaRelacionIndirecta_P35.exe");
        }

        private void MP17_Click(object sender, RoutedEventArgs e)
        {
            //System.Diagnostics.Process.Start("P36.exe");
            MessageBox.Show("Ocurrio un error...");
        }

        private void MP18_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WpfApp11_P37.exe");
        }

        private void MP19_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WpfStackPanel_P38.exe");
        }

        private void MP20_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WpfCanvas1_P39.exe");
        }

        private void MP21_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WpfNavegar_P40.exe");
        }

        private void MP22_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("GraficadorV5_P23.exe");
        }

        private void MP23_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPF_AlarmaWF01_P41.exe");
        }

        private void MP24_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPF_LATR_P42.exe");
        }

        private void PE1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPF_DocumentosDinamicos02.exe");
        }

        private void PR1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Proyecto01_Parcial2.exe");
        }

        private void PR2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Proy2_InterfaceXAML.exe");
        }

        private void PR3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("MascotaVirtualProyecto3.exe");
        }

        private void PG1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("ProyectoGrupalFormularioICE.exe");
        }

        private void PG2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("ProyectoGrupalCalculadoraICE.exe");
        }

        private void PG3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No Participe");
        }

        private void MP25_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFgenSeñales1_P43.exe");
        }
    }
}
