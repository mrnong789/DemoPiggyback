using System;
using System.IO.Ports;

namespace DemoPiggyback {
    public partial class Main : Form {
        static SerialPort _serialPort;
        private int dataliveStream = 0;

        public Main () {
            InitializeComponent();
        }

        private void Form1_Load ( object sender, EventArgs e ) {

        }

        private void button_connect_Click ( object sender, EventArgs e ) {
            if ( backgroundWorker1.IsBusy != true ) {
                _serialPort = new SerialPort();
                _serialPort.PortName = "COM5";//Set your board COM
                _serialPort.BaudRate = 9600;
                _serialPort.Open();
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }



        }

        private void genTable () {
            // Set the number of rows and columns
            dgvTable.RowCount = 2;
            dgvTable.ColumnCount = 17;

            // Optionally, you can set headers, column width, row height, etc.
            dgvTable.RowHeadersVisible = false; // Hide row headers
            dgvTable.ColumnHeadersVisible = false; // Hide column headers

            // Set the column width and row height to make cells square
            int cellSize = 90; // You can adjust this value as needed
            int rowSize = 80; // You can adjust this value as needed
            for ( int i = 0; i < dgvTable.ColumnCount; i++ ) {
                dgvTable.Columns [ i ].Width = cellSize;

            }
            dgvTable.Rows [ 0 ].Height = rowSize;

            dgvTable.Rows [ 1 ].Height = rowSize;


            for ( int row = 0; row < 2; row++ ) {
                for ( int col = 0; col < dgvTable.ColumnCount; col++ ) {
                    int randomValue = ( col + 1 ) * ( 255 / dgvTable.ColumnCount );
                    if ( row == 0 ) {
                        dgvTable.Rows [ row ].Cells [ col ].Style.BackColor = Color.Blue;
                        dgvTable.Rows [ row ].Cells [ col ].Style.ForeColor = Color.White;


                    }

                    dgvTable.Rows [ row ].Cells [ col ].Value = randomValue;

                }
            }
        }

        private void backgroundWorker1_DoWork ( object sender, System.ComponentModel.DoWorkEventArgs e ) {

            while ( true ) {
                string a = _serialPort.ReadLine();
                //label_liveData.Text = a;
                //  System.Diagnostics.Debug.WriteLine(a);
                System.Threading.Thread.Sleep(1);
                int livedata;
                if ( int.TryParse(a, out livedata) ) {
                    dataliveStream = livedata;
                    backgroundWorker1.ReportProgress(livedata);
                }

            }
        }

        private void backgroundWorker1_ProgressChanged ( object sender, System.ComponentModel.ProgressChangedEventArgs e ) {
            label_liveData.Text = ( e.ProgressPercentage.ToString() );


            DataGridViewRow dataRow = dgvTable.Rows [ 0 ];
            int oldData = 0;
            foreach ( DataGridViewCell cell in dataRow.Cells ) {
                var dataGrid = cell.Value;

                int livedata;
                if ( dataGrid != null ) {
                    if ( int.TryParse(dataGrid.ToString(), out livedata) ) {
                        bool foundData = ( dataliveStream >= oldData ) && ( dataliveStream <= livedata );
                        oldData = livedata;
                        if ( cell.Value != null && foundData ) {
                            dgvTable.Rows [ 1 ].Cells [ cell.ColumnIndex ].Style.BackColor = Color.Yellow;
                            //cell.Style.BackColor = Color.Yellow;
                        } else {
                            dgvTable.Rows [ 1 ].Cells [ cell.ColumnIndex ].Style.BackColor = dgvTable.DefaultCellStyle.BackColor;

                        }
                    }


                }


            }


        }

        private void backgroundWorker1_RunWorkerCompleted ( object sender, System.ComponentModel.RunWorkerCompletedEventArgs e ) {
            if ( e.Cancelled == true ) {
                // resultLabel.Text = "Canceled!";
            } else if ( e.Error != null ) {
                // resultLabel.Text = "Error: " + e.Error.Message;
            } else {
                // resultLabel.Text = "Done!";
            }
        }

        private void button_disconnect_Click ( object sender, EventArgs e ) {
            if ( backgroundWorker1.WorkerSupportsCancellation == true ) {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }


            //dgvTable.Rows[1].Cells[5].Style.BackColor = Color.Yellow;
        }

        private void dgvTable_CellFormatting ( object sender, DataGridViewCellFormattingEventArgs e ) {

            //// Check if the cell value is equal to 10
            //int dataGrid = (int)e.Value;

            //if (e.Value != null && dataliveStream >= dataGrid && e.RowIndex != 0)
            //{
            //    // Change the background color of the cell to a custom color
            //    e.CellStyle.BackColor = Color.Yellow;
            //}
            //else
            //{
            //    // Reset the background color to the default
            //    e.CellStyle.BackColor = dgvTable.DefaultCellStyle.BackColor;
            //}

        }

        private void button3_Click ( object sender, EventArgs e ) {
            genTable();
        }
    }
}