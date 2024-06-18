using ClosedXML.Excel;
using System.Windows.Forms;

namespace Practice_Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnSaveAsExcel_Click(object sender, EventArgs e)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Hoja1");

         
            for (int i = 0; i < dtgContent.Columns.Count; i++)
            {
                worksheet.Cell(1, i + 1).Value = dtgContent.Columns[i].HeaderText;
            }

         
            for (int i = 0; i < dtgContent.Rows.Count; i++)
            {
                for (int j = 0; j < dtgContent.Columns.Count; j++)
                {
                    worksheet.Cell(i + 2, j + 1).Value = dtgContent.Rows[i].Cells[j].Value?.ToString();
                }
            }

         
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar archivo Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("El archivo se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
