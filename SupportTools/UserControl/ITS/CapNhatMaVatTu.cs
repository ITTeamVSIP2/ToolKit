using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SupportTools
{
    public partial class CapNhatMaVatTu : UserControl
    {
        private string connString = "Server=10.17.215.212;Database=ITS;Connection Timeout=60;User Id=FEAWUser; PWD=!FEAWUser89";
        
        public CapNhatMaVatTu()
        {
            InitializeComponent();
            loadComboboxItem();
        }

        private void simplebtnCapNhat_Click(object sender, EventArgs e)
        {
            ItemDTO typeItem = (ItemDTO)cbItem.SelectedItem;
            if (typeItem != null)
            {
                var connection = new SqlConnection(connString);
                connection.Open();
                try
                {
                    string sqlUpdate = @"
                    UPDATE id SET id.ItemID = @ID
                    FROM dbo.SplitString(@ItemList, ',') AS ss
                        INNER JOIN dbo.ItemDetail AS id
                            ON ss.s = id.ID;
                    ";
                    var command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = sqlUpdate;
                    command.Parameters.AddWithValue("@ID", typeItem.ID.ToString());
                    command.Parameters.AddWithValue("@ItemList", rtbItemDetail.Text.TrimEnd().ToString().Replace("\n", ","));
                    var rows_affected = command.ExecuteNonQuery();
                    MessageBox.Show($"Có {rows_affected} item đã được cập nhật");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                connection.Close();
            }
        }
        public void loadComboboxItem()
        {
            try
            {
                var connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;

                string sqlStr = @"
                SELECT i.ID,i.ItemType,i.ItemName, i.ItemType + ' - ' + i.ItemName as [Name]
                FROM dbo.Item AS i
                WHERE i.Status = 1
                      AND i.ItemType IN ( 'GENERALAFFAIR', 'HARDWAREREQUIREMENT', 'MAINTENANCE',
                                          'PACONSTRUCTREQUEST', 'PANORMALREQUEST'
                                        )
                ORDER BY i.ItemType, i.ItemName
                ";
                command.CommandText = sqlStr;
                var reader = command.ExecuteReader();
                List<ItemDTO> listItem = new List<ItemDTO>();
                // Kiểm tra có kết quả trả về
                if (reader.HasRows)
                {
                    // Đọc từng dòng tập kết quả
                    while (reader.Read())
                    {
                        listItem.Add(new ItemDTO()
                        {
                            ID = reader["ID"].ToString(),
                            ItemType = reader["ItemType"].ToString(),
                            ItemName = reader["ItemName"].ToString(),
                            Name = reader["Name"].ToString()
                        });
                    }
                }
                //set to combobox
                cbItem.DataSource = listItem;
                cbItem.DisplayMember = "Name";
                cbItem.ValueMember = "ID";
                connection.Close();
            }
            catch// (Exception ex)
            {
            }
        }
    }
}
