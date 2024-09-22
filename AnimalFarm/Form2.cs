using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalFarm
{
    public partial class Form2 : Form
    {
        string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=AnimalFarm;Integrated Security=True;Encrypt=False";

        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int cowValue, sheepValue, goatValue;

            if (int.TryParse(txbCow.Text, out cowValue) && int.TryParse(txbSheep.Text, out sheepValue) && int.TryParse(txbGoat.Text, out goatValue))
            {
                // Ghi dữ liệu vào cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Animals (Cow, Sheep, Goat) VALUES (@Cow, @Sheep, @Goat)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Cow", cowValue);
                        cmd.Parameters.AddWithValue("@Sheep", sheepValue);
                        cmd.Parameters.AddWithValue("@Goat", goatValue);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Dữ liệu đã được lưu thành công!");

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi lưu dữ liệu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số lượng!");
            }
        }
    }
}
