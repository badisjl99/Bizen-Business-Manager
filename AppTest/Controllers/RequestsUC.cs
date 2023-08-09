using AppTest.Tools;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace AppTest.Controllers
{
    public partial class RequestsUC : UserControl
    {

        InvoiceUC InvoiceUC = new InvoiceUC();
        MySqlConnection DB_CONNECTION;

        public RequestsUC()
        {
            InitializeComponent();
            SearchBox.TextChanged += SearchBox_TextChanged;
            DisplayTable();

        }



        private void DisplayTable(string filter = "")
        {
            DataTable dataTable = new DataTable();

            this.DB_CONNECTION = APP_CONFIGURATION.ESTABLISH_DB_CONNECTION();
            string selectQuery = "SELECT * FROM orders_table WHERE status = 1";

            if (!string.IsNullOrEmpty(filter))
            {
                // Assuming the column name for the client name is 'client_name'.
                selectQuery += " AND client LIKE @clientName";
            }

            selectQuery += " ORDER BY Date;";

            MySqlCommand selectCommand = new MySqlCommand(selectQuery, DB_CONNECTION);

            // Add the parameter for the client name filter.
            if (!string.IsNullOrEmpty(filter))
            {
                selectCommand.Parameters.AddWithValue("@clientName", "%" + filter + "%");
            }

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectCommand);
            dataAdapter.Fill(dataTable);

            DB_CONNECTION.Close();
            dataGridView.DataSource = dataTable;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

            string clientName = SearchBox.Text;
            DisplayTable(clientName);
        }





        private void GeneratePDF(DataGridViewRow selectedRow)
        {
            // Create a new PDF document.
            Document document = new Document(PageSize.A4, 50, 50, 25, 25);

            try
            {
                string filePath = "C:\\Users\\Badis\\Desktop\\Trends_Site\\data.pdf";


                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {

                    PdfWriter writer = PdfWriter.GetInstance(document, fs);

                    // Open the document to write data.
                    document.Open();


                    PdfPTable pdfTable = new PdfPTable(selectedRow.DataGridView.Columns.Count);


                    foreach (DataGridViewColumn column in selectedRow.DataGridView.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        pdfTable.AddCell(cell);
                    }

                    foreach (DataGridViewCell cell in selectedRow.Cells)
                    {
                        PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value.ToString()));
                        pdfTable.AddCell(pdfCell);
                    }


                    document.Add(pdfTable);

                    // Close the document.
                    document.Close();


                    MessageBox.Show("Invoice Downloaded successfully!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error generating PDF: " + ex.Message);
            }
        }


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                GeneratePDF(selectedRow);
            }
            else
            {
                MessageBox.Show("Please select a row to print.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
