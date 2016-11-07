using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Proyect_Kardex
{
    class Export_Excel
    {


        public void ExportarDatosExcel(DataGridView data) 
        {
            try 
            {
                SaveFileDialog file = new SaveFileDialog();
                file.Filter = "Microsoft Excel (*.xls)|*.xls";
                file.Title = "Exportar Como";
                file.FileName = "DatosExportado";

                if(file.ShowDialog()==DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app;
                    Microsoft.Office.Interop.Excel.Workbook book;
                    Microsoft.Office.Interop.Excel.Worksheet heet;
                    app = new Microsoft.Office.Interop.Excel.Application();
                    book = app.Workbooks.Add();
                    heet = (Microsoft.Office.Interop.Excel.Worksheet)book.Worksheets.get_Item(1);

                    //Recorrer los datos del datagridview
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        for (int j = 0; j < data.Columns.Count; j++)
                        {
                            if((data.Rows[i].Cells[j].Value == null) == false)
                            {
                                heet.Cells[i + 1, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

                    book.SaveAs(file.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    book.Close(true);
                    app.Quit();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("No Es Posible Exportar Los Datos.\nIntente Nuevamente."+ ex.Message , "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
