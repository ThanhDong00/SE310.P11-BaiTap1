using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AnimalFarm
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=AnimalFarm;Integrated Security=True;Encrypt=False";

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing); // Đăng ký sự kiện FormClosing
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tự động gọi nút Load khi form mở
            btnLoad_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận xóa dữ liệu
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu trong cơ sở dữ liệu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Nếu người dùng chọn Yes, thực hiện xóa dữ liệu
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Animals"; // Câu truy vấn xóa dữ liệu

                        SqlCommand cmd = new SqlCommand(query, conn);

                        // Thực thi lệnh SQL
                        cmd.ExecuteNonQuery();

                        // Thông báo xóa thành công
                        MessageBox.Show("Dữ liệu đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xóa dữ liệu: " + ex.Message);
                    }
                }
            }
            else
            {
                // Nếu người dùng chọn No, không xóa dữ liệu và tiếp tục đóng form
                e.Cancel = false;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Cow, Sheep, Goat FROM Animals";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    //int count = dataGridView1.Rows.Count;

                    //MessageBox.Show("count " + count);

                    // Kiểm tra nếu không có dữ liệu

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu trong database. Vui lòng nhập dữ liệu!");
                        Form2 form2 = new Form2();
                        form2.ShowDialog();

                        btnLoad_Click(sender, e);
                    }
                    else
                    {
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }

        private void Voice_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int lastRowIndex = dataGridView1.Rows.Count - 2;

                int cowValue = (int)dataGridView1.Rows[lastRowIndex].Cells[0].Value;
                int sheepValue = (int)dataGridView1.Rows[lastRowIndex].Cells[1].Value;
                int goatValue = (int)dataGridView1.Rows[lastRowIndex].Cells[2].Value;

                string result = "";

                for (int i = 0; i < cowValue; i++)
                {
                    result += "Cow ";
                }

                for (int i = 0; i < sheepValue; i++)
                {
                    result += "Sheep ";
                }

                for (int i = 0; i < goatValue; i++)
                {
                    result += "Goat ";
                }

                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu trong bảng!");
            }
        }

        private void Breed_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int lastRowIndex = dataGridView1.Rows.Count - 2;

                int cowValue = (int)dataGridView1.Rows[lastRowIndex].Cells[0].Value;
                int sheepValue = (int)dataGridView1.Rows[lastRowIndex].Cells[1].Value;
                int goatValue = (int)dataGridView1.Rows[lastRowIndex].Cells[2].Value;

                Random random = new Random();
                int totalCow = cowValue;
                int totalSheep = sheepValue;
                int totalGoat = goatValue;

                for (int i = 0; i < cowValue; i++)
                {
                    int additionalCows = random.Next(1, 4);
                    totalCow += additionalCows;
                }

                for (int i = 0; i < sheepValue; i++)
                {
                    int additionalSheep = random.Next(1, 4);
                    totalSheep += additionalSheep;
                }

                for (int i = 0; i < sheepValue; i++)
                {
                    int additionalGoat = random.Next(1, 4);
                    totalGoat += additionalGoat;
                }

                //Ghi vao database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        //string query = "UPDATE Animals SET Cow = @Cow, Sheep = @Sheep, Goat = @Goat";
                        string query = "INSERT INTO Animals (Cow, Sheep, Goat) VALUES (@Cow, @Sheep, @Goat)";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Cow", totalCow);
                        cmd.Parameters.AddWithValue("@Sheep", totalSheep);
                        cmd.Parameters.AddWithValue("@Goat", totalGoat);

                        // Thực thi câu lệnh SQL
                        cmd.ExecuteNonQuery();

                        // Thông báo cập nhật thành công
                        MessageBox.Show($"Cập nhật thành công! Số lượng mới:\nCow: {totalCow}\nSheep: {totalSheep}\nGoat: {totalGoat}");

                        // Cập nhật lại DataGridView
                        btnLoad_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi cập nhật dữ liệu: " + ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Không có dữ liệu trong bảng!");
            }
        }

        private void getMilk_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int lastRowIndex = dataGridView1.Rows.Count - 2;

                int cowValue = (int)dataGridView1.Rows[lastRowIndex].Cells[0].Value;
                int sheepValue = (int)dataGridView1.Rows[lastRowIndex].Cells[1].Value;
                int goatValue = (int)dataGridView1.Rows[lastRowIndex].Cells[2].Value;

                Random random = new Random();
                int totalMilk = 0;

                for (int i = 0; i < cowValue; i++)
                {
                    int MilkCows = random.Next(0, 21);
                    totalMilk += MilkCows;
                }

                for (int i = 0; i < sheepValue; i++)
                {
                    int MilkSheep = random.Next(0, 6);
                    totalMilk += MilkSheep;
                }

                for (int i = 0; i < sheepValue; i++)
                {
                    int MilkGoat = random.Next(0, 11);
                    totalMilk += MilkGoat;
                }

                MessageBox.Show($"milk: {totalMilk}");

            }
            else
            {
                MessageBox.Show("Không có dữ liệu trong bảng!");
            }
        }
    }
}
