using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using SupportTools.Models;
using System.Configuration;

namespace SupportTools
{
    public partial class KhuVucBaoVe : DevExpress.XtraEditors.XtraUserControl
    {
        private string connString = "Server=10.17.215.212;Database=ITS;Connection Timeout=60;User Id=FEAWUser; PWD=!FEAWUser89";
        public KhuVucBaoVe()
        {
            InitializeComponent();
            //loadComboboxUnit();
            //loadComboboxItem();
            //loadComboboxbophan_keydown();
            //loadComboboxUser_keydown();
            gridView1.OptionsView.ShowGroupPanel = false;
            loaddanhsachdacaidat();
            DesignGV1();
        }

        private void loaddanhsachdacaidat()
        {

            var connection = new SqlConnection(connString);
            string Sql = @"SELECT cc.Remark AS 'Bộ phận', u.UserID AS 'ID người ký', u.UserName AS 'Người ký duyệt', i.ItemName AS 'Nhóm hạng mục', id.ItemDetailName AS 'Tên vật phẩm', un.Name AS 'Đơn vị', cc.CompanyCode AS 'Công ty'
                            FROM dbo.ExportItemApproverItem AS eiai
                            INNER JOIN dbo.[User] AS u
                            ON u.UserID = eiai.ApproverID
                            INNER JOIN dbo.CostCenter AS cc
                            ON cc.CostCenterCode = eiai.CostCenterCode
                            INNER JOIN dbo.Item AS i
                            ON i.ID = eiai.ItemID
                            INNER JOIN dbo.ItemDetail AS id
                            ON id.ID = eiai.ItemDetailID
                            INNER JOIN dbo.Unit AS un
                            ON un.ID = id.Temp2
                            WHERE eiai.Status=1 
                            AND i.Status=1
                            AND id.Status=1
                            AND cc.CompanyCode IN (7910, 79101)
                            AND id.CompanyCode LIKE '%7910%'";
            try
            {
                connection.Open();
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                gridControl1.DataSource = dt;

            }
            catch //(Exception ex)
            {

            }
        }
            

        private void loadComboboxUnit()
        {
            try
            {
                var connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;

                string sqlStr = @"
                SELECT ID, NAME AS [Name]
                FROM dbo.Unit
                WHERE Status = 1
                ORDER BY NAME ASC
                ";
                command.CommandText = sqlStr;
                var reader = command.ExecuteReader();
                List<UnitDTO> listItem = new List<UnitDTO>();
                // Kiểm tra có kết quả trả về
                if (reader.HasRows)
                {
                    // Đọc từng dòng tập kết quả
                    while (reader.Read())
                    {
                        listItem.Add(new UnitDTO()
                        {
                            ID = reader["ID"].ToString(),
                            Name = reader["Name"].ToString()
                        });
                    }
                }
                //set to combobox
                cbUnit.DataSource = listItem;
                cbUnit.DisplayMember = "Name";
                cbUnit.ValueMember = "ID";
                connection.Close();
                cbUnit.Text = "";
            }
            catch// (Exception ex)
            {
            }
        }

        private void loadComboboxUnit_keydown()
        {
            try
            {
                var connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;

                string sqlStr = @"
                SELECT ID, NAME AS [Name]
                FROM dbo.Unit
                WHERE Status = 1 AND NAME LIKE N'%" + cbUnit.Text + "%' ORDER BY NAME ASC";
                command.CommandText = sqlStr;
                var reader = command.ExecuteReader();
                List<UnitDTO> listItem = new List<UnitDTO>();
                // Kiểm tra có kết quả trả về
                if (reader.HasRows)
                {
                    // Đọc từng dòng tập kết quả
                    while (reader.Read())
                    {
                        listItem.Add(new UnitDTO()
                        {
                            ID = reader["ID"].ToString(),
                            Name = reader["Name"].ToString()
                        });
                    }
                }
                //set to combobox
                cbUnit.DataSource = listItem;
                cbUnit.DisplayMember = "Name";
                cbUnit.ValueMember = "ID";
                connection.Close();
            }
            catch// (Exception ex)
            {
            }
        }
        private void cbUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadComboboxUnit_keydown();
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
                SELECT i.ItemName as [Name]
                FROM dbo.Item AS i
                WHERE i.Status = 1
                      AND i.ItemType IN ('SECURITYAREA')
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
                cbNhomHangMuc.DataSource = listItem;
                cbNhomHangMuc.DisplayMember = "Name";
                cbNhomHangMuc.ValueMember = "ID";
                connection.Close();
            }
            catch //(Exception ex)
            {
            }
        }
        public void loadComboboxItem_keydown()
        {
            try
            {
                var connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;

                string sqlStr = @"
                SELECT i.ID, i.ItemType, i.ItemName as [Name]
                FROM dbo.Item AS i
                WHERE i.Status = 1
                      AND i.ItemType IN ('SECURITYAREA')
                       AND ItemName LIKE N'%" + cbNhomHangMuc.Text + "%' ORDER BY i.ItemName ";
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
                            Name = reader["Name"].ToString()
                        });
                    }
                }
                //set to combobox
                cbNhomHangMuc.DataSource = listItem;
                cbNhomHangMuc.DisplayMember = "Name";
                cbNhomHangMuc.ValueMember = "ID";
                connection.Close();
            }
            catch// (Exception ex)
            {
            }
        }
        private void cbNhomHangMuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadComboboxItem_keydown();
            }
        }
        public void loadComboboxbophan_keydown()
        {
            try
            {
                var connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;

                string sqlStr = @"
                SELECT CostCenterCode, Remark
                FROM dbo.CostCenter
                WHERE CompanyCode IN (7910, 79101)
                AND Enabled=1 AND Remark LIKE N'%" + cbBoPhan.Text + "%'";
                command.CommandText = sqlStr;
                var reader = command.ExecuteReader();
                List<DepartmentDTO> listDepartment = new List<DepartmentDTO>();
                // Kiểm tra có kết quả trả về
                if (reader.HasRows)
                {
                    // Đọc từng dòng tập kết quả
                    while (reader.Read())
                    {
                        listDepartment.Add(new DepartmentDTO()
                        {
                            CostCenterCode = reader["CostCenterCode"].ToString(),
                            Remark = reader["Remark"].ToString(),
                        });
                    }
                }
                //set to combobox
                cbBoPhan.DataSource = listDepartment;
                cbBoPhan.DisplayMember = "Remark";
                cbBoPhan.ValueMember = "CostCenterCode";
                connection.Close();
            }
            catch //(Exception ex)
            {
            }
        }
        private void cbBoPhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadComboboxbophan_keydown();
            }
        }
        public void loadComboboxUser_keydown()
        {
            try
            {
                var connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;

                string sqlStr = @"
                SELECT UserID, UserName
                FROM dbo.[User]
                WHERE FactoryID IN (7910, 79101)
                AND Enabled=1 AND UserName LIKE N'%" + cbNguoiDuyet.Text + "%'";
                command.CommandText = sqlStr;
                var reader = command.ExecuteReader();
                List<UserDTO> listUser = new List<UserDTO>();
                // Kiểm tra có kết quả trả về
                if (reader.HasRows)
                {
                    // Đọc từng dòng tập kết quả
                    while (reader.Read())
                    {
                        listUser.Add(new UserDTO()
                        {
                            UserID = reader["UserID"].ToString(),
                            Name = reader["UserName"].ToString(),
                        });
                    }
                }
                //set to combobox
                cbNguoiDuyet.DataSource = listUser;
                cbNguoiDuyet.DisplayMember = "Name";
                cbNguoiDuyet.ValueMember = "UserID";
                connection.Close();
            }
            catch// (Exception ex)
            {
            }
        }

        private void cbNguoiDuyet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadComboboxUser_keydown();
            }
        }
        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            ItemDTO typeItem = (ItemDTO)cbNhomHangMuc.SelectedItem;
            UnitDTO unit = (UnitDTO)cbUnit.SelectedItem;
            DepartmentDTO department = (DepartmentDTO)cbBoPhan.SelectedItem;
            UserDTO user = (UserDTO)cbNguoiDuyet.SelectedItem;
            if (cbNhomHangMuc.Text != "" && cbUnit.Text != "" && cbBoPhan.Text != "" && cbNguoiDuyet.Text != "" && txtTenVatPham.Text != "")
            {
                try
                {
                    //string iss = unit.ID.ToString();
                    string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                    var connection = new SqlConnection(connString);
                    string sql_insert = @"DECLARE @_ItemDetailID NVARCHAR(100)
                                                SET @_ItemDetailID = NEWID()
                                                INSERT dbo.ItemDetail
                                                (
                                                    ID,
                                                    ItemID,
                                                    ItemDetailName,
                                                    Temp1,
                                                    Temp2,
                                                    Status,
                                                    LastUpdateDate,
                                                    LastUpdateUser,
                                                    CompanyCode,
                                                    Specification,
                                                    ItemDetailCode
                                                )
                                                VALUES
                                                (@_ItemDetailID,'" + typeItem.ID.ToString() + "',N'" + txtTenVatPham.Text + "','','" + unit.ID.ToString() + "',1,NULL,'9999','7910,79101',N'" + txtQuyCach.Text + "',NULL)"


                                                        + " INSERT dbo.ExportItemApproverItem"
                                                                + " (ID,"
                                                                + " ApproverID,"
                                                                + " CostCenterCode,"
                                                                + " ItemID,"
                                                                + " ItemDetailID,"
                                                                + " Status,"
                                                                + " Temp1,"
                                                                + " Temp2)"
                                                                + " VALUES"
                                                                + "(NEWID(), '" + user.UserID.ToString() + "', '" + department.CostCenterCode.ToString() + "', '" + typeItem.ID.ToString() + "', @_ItemDetailID, 1, N'', N'')";

                    try
                    {
                        connection.Open();
                        SqlCommand commandsql_insert = new SqlCommand(sql_insert, connection);
                        commandsql_insert.ExecuteNonQuery();
                        connection.Close();
                        XtraMessageBox.Show("Thêm dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddanhsachdacaidat();
                    }
                    catch/// (Exception ex)
                    {
                        XtraMessageBox.Show("Thêm dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch// (Exception ex)
                {
                    XtraMessageBox.Show("Vui lòng chọn dữ liệu trong combobox hoặc nhấn enter.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { XtraMessageBox.Show("Vui lòng chọn đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void DesignGV1()
        {
            gridView1.Columns["Bộ phận"].Width = 130;
            gridView1.Columns["ID người ký"].Width = 50;
            gridView1.Columns["Người ký duyệt"].Width = 100;
            gridView1.Columns["Nhóm hạng mục"].Width = 200;
            gridView1.Columns["Tên vật phẩm"].Width = 80;
            gridView1.Columns["Đơn vị"].Width = 50;
            gridView1.Columns["Công ty"].Width = 40;
            //gridView1.OptionsBehavior.Editable = false;
        }
    }
}
