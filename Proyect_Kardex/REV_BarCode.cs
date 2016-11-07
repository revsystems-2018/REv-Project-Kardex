using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace Proyect_Kardex
{
    public partial class REV_BarCode : Form
    {
        ValidacionText cv = new ValidacionText();
         BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();                       

        public REV_BarCode()
        {
            InitializeComponent();

            toolCodebar.SetToolTip(textcod, "Ingresar o Generar un Codigo de Barras del Producto");
            toolCodebar.SetToolTip(combotipo, "Seleccionar el Tipo de Codigo de Barras");
            toolCodebar.SetToolTip(combotam, "Seleccionar el Tamaño de Imagen");
            toolCodebar.SetToolTip(combofont, "Seleccionar el Color de Fondo del Codigo");
            toolCodebar.SetToolTip(combocolor, "Seleccionar el Color del Codigo de Barras");
            toolCodebar.SetToolTip(pictucodebar, "Vista Previa del Codigo de Barras");
            toolCodebar.SetToolTip(picturejem, "Imagen de Ejemplo del Tipo de Codigo");
            toolCodebar.SetToolTip(buscaredboton, "Ayuda");
            toolCodebar.SetToolTip(magicode, "Generar Número del Codigo");
            toolCodebar.SetToolTip(VerEjem, "Ver Ejemplo");
            toolCodebar.SetToolTip(eliminarreg, "Eliminar Codigos Generados");
            toolCodebar.SetToolTip(Buscaritem, "Comprobar Codigo Existente");
            toolCodebar.SetToolTip(print, "Imprimir");
            toolCodebar.SetToolTip(gencode, "Generar Codigo de Barras");
            toolCodebar.SetToolTip(PrintPreview, "Ver Documento");
            toolCodebar.SetToolTip(save, "Guardar");
            toolCodebar.SetToolTip(salir, "Salir");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textcod.Text != "" && textcod.Font.Italic == true)
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese o Genere un Codigo de Barras para el Producto (13 Digitos).", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese o Genere un Codigo de Barras para el Producto (13 Digitos).", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "")
            {
                MessageBox.Show("Ingrese o Genere un Codigo de Barras para el Producto (13 Digitos).", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Codigo para el Code 11.
                    if (combotipo.SelectedItem == "Code 11")
                    {
                        if (combocolor.SelectedItem == "Negro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.Black, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.Black, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.Black, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.Black, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.Black, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.Black, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (combocolor.SelectedItem == "Verde Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.DarkGreen, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.DarkGreen, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.DarkGreen, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.DarkGreen, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.DarkGreen, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.DarkGreen, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else if (combocolor.SelectedItem == "Rojo Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.DarkRed, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.DarkRed, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.DarkRed, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.DarkRed, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.DarkRed, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, textcod.Text, Color.DarkRed, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Debe Seleccionar el Color de Lineas de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                        //Codigo para el code 128.
                    else if (combotipo.SelectedItem == "Code 128")
                    {
                        if (combocolor.SelectedItem == "Negro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.Black, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.Black, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.Black, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.Black, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.Black, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.Black, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (combocolor.SelectedItem == "Verde Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.DarkGreen, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.DarkGreen, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.DarkGreen, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.DarkGreen, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.DarkGreen, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.DarkGreen, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else if (combocolor.SelectedItem == "Rojo Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.DarkRed, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.DarkRed, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.DarkRed, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.DarkRed, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.DarkRed, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textcod.Text, Color.DarkRed, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Debe Seleccionar el Color de Lineas de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //--------------------------------------------------------------------------------
                    //Codigo para el code 39
                    else if (combotipo.SelectedItem == "Code 39")
                    {
                        if (combocolor.SelectedItem == "Negro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.Black, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.Black, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.Black, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.Black, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.Black, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.Black, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (combocolor.SelectedItem == "Verde Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.DarkGreen, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.DarkGreen, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.DarkGreen, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.DarkGreen, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.DarkGreen, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.DarkGreen, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else if (combocolor.SelectedItem == "Rojo Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.DarkRed, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.DarkRed, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.DarkRed, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.DarkRed, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.DarkRed, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, textcod.Text, Color.DarkRed, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Debe Seleccionar el Color de Lineas de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                        //--------------------------------------------------------------------------------
                    //Codigo para el code 39 mod 43
                    else if (combotipo.SelectedItem == "Code 39 Model 43")
                    {
                        if (combocolor.SelectedItem == "Negro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.Black, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.Black, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.Black, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.Black, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.Black, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.Black, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (combocolor.SelectedItem == "Verde Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.DarkGreen, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.DarkGreen, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.DarkGreen, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.DarkGreen, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.DarkGreen, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.DarkGreen, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else if (combocolor.SelectedItem == "Rojo Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.DarkRed, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.DarkRed, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.DarkRed, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.DarkRed, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.DarkRed, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, textcod.Text, Color.DarkRed, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Debe Seleccionar el Color de Lineas de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                        //--------------------------------------------------------------------------------
                    //Codigo para el code 93
                    else if (combotipo.SelectedItem == "Code 93")
                    {
                        if (combocolor.SelectedItem == "Negro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.Black, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.Black, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.Black, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.Black, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.Black, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.Black, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (combocolor.SelectedItem == "Verde Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.DarkGreen, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.DarkGreen, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.DarkGreen, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.DarkGreen, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.DarkGreen, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.DarkGreen, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else if (combocolor.SelectedItem == "Rojo Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.DarkRed, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.DarkRed, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.DarkRed, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.DarkRed, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.DarkRed, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, textcod.Text, Color.DarkRed, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Debe Seleccionar el Color de Lineas de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                        //--------------------------------------------------------------------------------
                    //Codigo para el code EAN 13
                    else if (combotipo.SelectedItem == "Code EAN 13")
                    {
                        if (combocolor.SelectedItem == "Negro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.Black, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.Black, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.Black, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.Black, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.Black, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.Black, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (combocolor.SelectedItem == "Verde Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.DarkGreen, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.DarkGreen, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.DarkGreen, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.DarkGreen, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.DarkGreen, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.DarkGreen, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else if (combocolor.SelectedItem == "Rojo Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.DarkRed, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.DarkRed, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.DarkRed, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.DarkRed, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.DarkRed, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, textcod.Text, Color.DarkRed, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Debe Seleccionar el Color de Lineas de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                        //--------------------------------------------------------------------------------
                    //Codigo para el code indus 2 of 5
                    else if (combotipo.SelectedItem == "Code Industrial 2 of 5")
                    {
                        if (combocolor.SelectedItem == "Negro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.Black, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.Black, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.Black, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.Black, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.Black, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.Black, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (combocolor.SelectedItem == "Verde Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.DarkGreen, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.DarkGreen, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.DarkGreen, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.DarkGreen, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.DarkGreen, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.DarkGreen, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else if (combocolor.SelectedItem == "Rojo Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.DarkRed, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.DarkRed, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.DarkRed, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.DarkRed, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.DarkRed, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, textcod.Text, Color.DarkRed, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Debe Seleccionar el Color de Lineas de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                        //--------------------------------------------------------------------------------
                    //Codigo para el code ITF 14
                    else if (combotipo.SelectedItem == "Code ITF 14")
                    {
                        if (combocolor.SelectedItem == "Negro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.Black, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.Black, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.Black, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.Black, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.Black, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.Black, Color.Aqua, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (combocolor.SelectedItem == "Verde Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.DarkGreen, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.DarkGreen, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.DarkGreen, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.DarkGreen, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.DarkGreen, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.DarkGreen, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else if (combocolor.SelectedItem == "Rojo Oscuro")
                        {

                            if (combofont.SelectedItem == "Blanco")
                            {

                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.DarkRed, Color.White, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.DarkRed, Color.White, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.DarkRed, Color.White, 200, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (combofont.SelectedItem == "Color Agua")
                            {
                                if (combotam.SelectedItem == "400 x 150 (Grande)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.DarkRed, Color.Aqua, 400, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "300 x 150 (Mediano)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.DarkRed, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else if (combotam.SelectedItem == "200 x 150 (Pequeño)")
                                {//Codigo mas los ajustes. 
                                    codigo.IncludeLabel = true;
                                    pictucodebar.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, textcod.Text, Color.DarkRed, Color.Aqua, 300, 150);
                                    save.Enabled = true;
                                    save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
                                    gencode.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Debe Seleccionar el Tamaño de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Seleccionar el Color de Fondo de la Imagen del Codigo de Barras.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Debe Seleccionar el Color de Lineas de la Imagen del Codigo de Barras.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe Seleccionar una Simbologia para Mostrar el Tipo de Codigo de Barras.", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            string message = "Esta Seguro que Desea Cancelar la Generación de Codigos de Barras.?";
            string caption = "Cancelar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            { // Closes the parent form.
                this.Close();
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (textcod.Text != "" && textcod.Font.Italic == true)
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese o Genere un Codigo de Barras para el Producto (13 Digitos).", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese o Genere un Codigo de Barras para el Producto (13 Digitos).", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "")
            {
                MessageBox.Show("Ingrese o Genere un Codigo de Barras para el Producto (13 Digitos).", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(comprobar()==1)
                {
                    MessageBox.Show("Error, El Codigo Ingresado Ya Existe.\nIngrese o Genere un Codigo Nuevo.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("El Codigo Esta Disponible Para el Registro.\n     Continue el Procedimiento...", "HECHO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private int comprobar()
        {
            int cnt = 0;
            Conexion cs = new Conexion();
            string buscar = "SELECT * FROM Productos WHERE CodBarP= '" + Convert.ToInt64(textcod.Text) + "' ; ";
            cs.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, cs.GetCONN());
            try
            {
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            cs.CerrarCnn();
            return cnt;
        }


        private void buscaredboton_Click(object sender, EventArgs e)
        {
            string message = "";
            string caption = "";

            if (Convert.ToString(combotipo.SelectedItem) == "Code 11"){
                message = " Se Recomienda que el Codigo sea Solo Numeros. \n       CODE 11    \n \n 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 \n - (Guión)";
                caption = "Ayuda";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (Convert.ToString(combotipo.SelectedItem) == "Code 128")
            {
                message = " Se Recomienda que el Codigo sea Solo Numeros. \n       CODE 128    \n \n Todos los 128 caracteres de ASCII";
                caption = "Ayuda";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (Convert.ToString(combotipo.SelectedItem) == "Code 39")
            {
                message = " Se Recomienda que el Codigo sea Solo Numeros. \n       CODE 39    \n \n 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 \n Las letras mayúsculas (A - Z) \n - (Guión), $ (dólar),% (porcentaje), (espacio),. (Punto), barra inclinada (/), + (Plus)";
                caption = "Ayuda";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (Convert.ToString(combotipo.SelectedItem) == "Code 93")
            {
                message = " Se Recomienda que el Codigo sea Solo Numeros. \n       CODE 93    \n \n 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 \n Las letras mayúsculas (A a Z) \n - (Guión),. (Punto), $ (dólar), barra inclinada (/), + (Plus),% (porcentaje), (espacio)";
                caption = "Ayuda";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (Convert.ToString(combotipo.SelectedItem) == "Code 39 Model 43")
            {
                message = " Se Recomienda que el Codigo sea Solo Numeros. \n   CODE 39 MODEL 43   \n \n Todos los 128 caracteres de ASCII";
                caption = "Ayuda";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (Convert.ToString(combotipo.SelectedItem) == "Code EAN 13")
            {
                message = " Se Recomienda que el Codigo sea Solo Numeros. \n    CODE EAN 13    \n \n 0, 1, 2, 3, 4, 5, 6, 7, 8, 9";
                caption = "Ayuda";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (Convert.ToString(combotipo.SelectedItem) == "Code Industrial 2 of 5")
            {
                message = " Se Recomienda que el Codigo sea Solo Numeros. \n  CODE  INDUSTRIAL 2 OF 5   \n \n 0, 1, 2, 3, 4, 5, 6, 7, 8, 9";
                caption = "Ayuda";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (Convert.ToString(combotipo.SelectedItem) == "Code ITF 14")
            {
                message = " Se Recomienda que el Codigo sea Solo Numeros. \n     CODE ITF 14    \n \n 0, 1, 2, 3, 4, 5, 6, 7, 8, 9";
                caption = "Ayuda";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                message = " Para Generar un Codigo de Barra, Debe Seleccionar el Tipo de Codigo en Simbologia.\n La Demostración del Codigo; Hacer Click en Ver Ejemplo.\n" + " Para Generar un Nuevo Codigo de Barras debe Hacer Click en Eliminar Codigos Generados.";
                caption = "Ayuda";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void numcodebar(object sender, KeyPressEventArgs e)
        {
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);
            cv.soloNumeros(e);
        }

        private void codebartextClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textcod.Text != "" && textcod.Font.Italic == true)
                {
                    textcod.Text = "";
                    textcod.ForeColor = SystemColors.WindowText;
                    textcod.Font = new Font(textcod.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textcod.ForeColor = SystemColors.WindowText;
                    textcod.Font = new Font(textcod.Font, FontStyle.Regular);
                }
            }
        }

        private void magicode_Click(object sender, EventArgs e)
        {                    
            //Inicializamos la clase Random
            Random r = new Random();

            int[] numeros = new int[13];

            textcod.Text = "";
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);

            //Recorremos el array y vamos asignando a cada
            //posición un número aleatorio
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = r.Next(0, 10);
                textcod.Text = textcod.Text + numeros[i].ToString();
            }
        }

        private void nadatipo(object sender, KeyPressEventArgs e)
        {
            cv.Nada(e);
        }

        private void nadacolor(object sender, KeyPressEventArgs e)
        {
            cv.Nada(e);
        }

        private void nadaFondo(object sender, KeyPressEventArgs e)
        {
            cv.Nada(e);
        }

        private void nadatam(object sender, KeyPressEventArgs e)
        {
            cv.Nada(e);
        }

        private void VerEjem_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();
            codigo.IncludeLabel = true;
            if(combotipo.SelectedItem == "Code 11")
            {                
                picturejem.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, "6922609611712", Color.Black, Color.White, 300, 150);
            }
            else if(combotipo.SelectedItem == "Code 128")
            {
                picturejem.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, "6922609611712", Color.Black, Color.White, 300, 150);
            }
            else if (combotipo.SelectedItem == "Code 39")
            {
                picturejem.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39, "6922609611712", Color.Black, Color.White, 300, 150);
            }
            else if (combotipo.SelectedItem == "Code 39 Model 43")
            {
                picturejem.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE39_Mod43, "6922609611712", Color.Black, Color.White, 300, 150);
            }
            else if (combotipo.SelectedItem == "Code 93")
            {
                picturejem.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE93, "6922609611712", Color.Black, Color.White, 300, 150);
            }
            else if (combotipo.SelectedItem == "Code EAN 13")
            {
                picturejem.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.EAN13, "6922609611712", Color.Black, Color.White, 300, 150);
            }
            else if (combotipo.SelectedItem == "Code Industrial 2 of 5")
            {
                picturejem.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.Industrial2of5, "6922609611712", Color.Black, Color.White, 300, 150);
            }
            else if (combotipo.SelectedItem == "Code ITF 14")
            {
                picturejem.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.ITF14, "6922609611712", Color.Black, Color.White, 300, 150);
            }
            else {
                MessageBox.Show("Debe Seleccionar una Simbologia para Mostrar el Tipo de Codigo de Barras.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarreg_Click(object sender, EventArgs e)
        {
            this.pictucodebar.BackgroundImage = null;
            this.picturejem.BackgroundImage = null;
            this.textcod.Text = "";
            this.textcod.ForeColor = SystemColors.WindowText;
            this.textcod.Font = new Font(textcod.Font, FontStyle.Regular);
            this.gencode.Enabled = true;
            this.save.Enabled = false;
            this.save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.saveblok;         
        }

        private void save_Click(object sender, EventArgs e)
        {
            Image imgfinal = (Image)pictucodebar.BackgroundImage.Clone();

            SaveFileDialog saveimg = new SaveFileDialog();
            saveimg.AddExtension = true;
            saveimg.Filter = "Imagen PNG (*.png)|*.png";
            saveimg.Title = "Guardar Imagen Codigo de Barras";
            saveimg.ShowDialog();

            if(!String.IsNullOrEmpty(saveimg.FileName)){
                imgfinal.Save(saveimg.FileName, ImageFormat.Png);
            }
            imgfinal.Dispose();
        }

        private void print_Click(object sender, EventArgs e)
        {
            if(this.PrintMain.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                this.DocxPrint.Print();              
            }
        }

        private void DocxPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictucodebar.BackgroundImage, 30, 30, pictucodebar.BackgroundImage.Width, pictucodebar.BackgroundImage.Height);
        }

        private void printview_Click(object sender, EventArgs e)
        {
            PrintPreview.Document = DocxPrint;
            PrintPreview.ShowDialog();
        }
    }
}
