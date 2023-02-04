using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_18._01
{
    class WorkTable
    {
        SqlConnection connection = new SqlConnection();
        DataSet data = new DataSet();
        SqlDataAdapter adapter;
        DataGridView dataGridView;
        string command;
        DataViewManager manager;
        DataView dataView;
        public WorkTable(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            
        }
        public void StartWork()
        {
            connection.ConnectionString = @"Data Source=1-ПК\SQLEXPRESS; Initial catalog = College; Integrated Security = true;";
            connection.Open();

        }

        public void ChoiceTable(int number)
        {
            
            command = "select * from Students; select * from Groups; select * from Subjects; select * from Marks; select * from SubjectStudent;";
            adapter = new SqlDataAdapter(command, connection);
            

            data.Tables.Clear();
            adapter.Fill(data);

            switch (number)
            {
                case 0:       
                    dataGridView.DataSource = data.Tables[0];                   
                    break;
                case 1:                   
                    dataGridView.DataSource = data.Tables[1];                    
                    break;
                case 2:              
                    dataGridView.DataSource = data.Tables[2];                    
                    break;
                case 3:                   
                    dataGridView.DataSource = data.Tables[3];                
                    break;
                case 4:                    
                    dataGridView.DataSource = data.Tables[4];
                    break;
            }
            manager = new DataViewManager(data);
        }

        public void SaveChange(int number)
        {
            string temp = "";
            SqlCommand update;
            switch (number)
            {
                case 0:
                    try
                    {
                        temp = "Update Students set FirstName=@pFirstName, LastName=@pLastName, Group_FK=@pGroup_FK where Id=@pId";
                        update = new SqlCommand(temp, connection);

                        update.Parameters.Add(new SqlParameter("@pFirstName", SqlDbType.NVarChar, 50));
                        update.Parameters.Add(new SqlParameter("@pLastName", SqlDbType.NVarChar, 50));
                        update.Parameters.Add(new SqlParameter("@pGroup_FK", SqlDbType.Int));
                        update.Parameters.Add(new SqlParameter("@pId", SqlDbType.Int));

                        update.Parameters["@pFirstName"].SourceVersion = DataRowVersion.Current;
                        update.Parameters["@pLastName"].SourceVersion = DataRowVersion.Current;
                        update.Parameters["@pGroup_FK"].SourceVersion = DataRowVersion.Current;
                        update.Parameters["@pId"].SourceVersion = DataRowVersion.Original;

                        update.Parameters["@pFirstName"].SourceColumn = "FirstName";
                        update.Parameters["@pLastName"].SourceColumn = "LastName";
                        update.Parameters["@pGroup_FK"].SourceColumn = "Group_FK";
                        update.Parameters["@pId"].SourceColumn = "Id";

                        adapter.UpdateCommand = update;
                        adapter.Update(data.Tables[0]);
                    }
                    catch (Exception ex)
                    {

                        //MessageBox.Show(ex.Message);
                        MessageBox.Show("Возможно введены некорректные данные. Уточните и поробуйте ещё раз");
                    }
                   
                    break;
                case 1:
                    try
                    {
                        temp = "Update Groups set GroupName = @pGroupName where Id=@pId";
                        update = new SqlCommand(temp, connection);

                        update.Parameters.Add(new SqlParameter("@pGroupName", SqlDbType.NVarChar, 50));
                        update.Parameters.Add(new SqlParameter("@pId", SqlDbType.Int));

                        update.Parameters["@pGroupName"].SourceVersion = DataRowVersion.Current;
                        update.Parameters["@pId"].SourceVersion = DataRowVersion.Original;

                        update.Parameters["@pGroupName"].SourceColumn = "GroupName";
                        update.Parameters["@pId"].SourceColumn = "Id";

                        adapter.UpdateCommand = update;
                        adapter.Update(data.Tables[1]);
                    }
                    catch (Exception ex)
                    {

                        //MessageBox.Show(ex.Message);
                        MessageBox.Show("Возможно введены некорректные данные. Уточните и поробуйте ещё раз");
                    }

                    break;
                case 2:
                    try
                    {
                        temp = "Update Subjects set SubjectName = @pSubjectName where id=@pId";
                        update = new SqlCommand(temp, connection);

                        update.Parameters.Add(new SqlParameter("@pSubjectName", SqlDbType.NVarChar, 50));
                        update.Parameters.Add(new SqlParameter("@pId", SqlDbType.Int));

                        update.Parameters["@pSubjectName"].SourceVersion = DataRowVersion.Current;
                        update.Parameters["@pId"].SourceVersion = DataRowVersion.Original;

                        update.Parameters["@pSubjectName"].SourceColumn = "SubjectName";
                        update.Parameters["@pId"].SourceColumn = "Id";

                        adapter.UpdateCommand = update;
                        adapter.Update(data.Tables[2]);
                    }
                    catch (Exception ex)
                    {

                        //MessageBox.Show(ex.Message);
                        MessageBox.Show("Возможно введены некорректные данные. Уточните и поробуйте ещё раз");
                    }

                    break;
                case 3:

                    MessageBox.Show("Эти данные не изменяются");
                    break;
                case 4:

                    
                    try
                    {
                        temp = "Update SubjectStudent set Mark_ID=@pMark_ID where Subject_ID=@pSubject_ID and Student_ID=@pStudent_ID";
                        update = new SqlCommand(temp, connection);

                        update.Parameters.Add(new SqlParameter("@pSubject_ID", SqlDbType.Int));
                        update.Parameters.Add(new SqlParameter("@pStudent_ID", SqlDbType.Int));
                        update.Parameters.Add(new SqlParameter("@pMark_ID", SqlDbType.Int));
                        

                        
                        update.Parameters["@pSubject_ID"].SourceVersion = DataRowVersion.Original;
                        update.Parameters["@pStudent_ID"].SourceVersion = DataRowVersion.Original;
                        update.Parameters["@pMark_ID"].SourceVersion = DataRowVersion.Current;
                        

                       
                        update.Parameters["@pSubject_ID"].SourceColumn = "Subject_ID";
                        update.Parameters["@pStudent_ID"].SourceColumn = "Student_ID";
                        update.Parameters["@pMark_ID"].SourceColumn = "Mark_ID";
                       

                        adapter.UpdateCommand = update;
                        adapter.Update(data.Tables[4]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Возможно введены некорректные данные. Уточните и поробуйте ещё раз");
                        MessageBox.Show("Внимание, изменить можно только оценку!");
                        //MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        
        public void FilterTable(int number, string filter)
        {
            if(adapter==null)
            {
                this.ChoiceTable(0);
            }
            switch (number)
            {
                case 0:
                    manager.DataViewSettings[0].RowFilter = $"FirstName= '{filter}'";
                    dataView = manager.CreateDataView(data.Tables[0]);
                    dataGridView.DataSource = dataView;
                    break;
                case 1:
                    
                    manager.DataViewSettings[0].RowFilter = $"Group_FK= '{filter}'";
                    dataView = manager.CreateDataView(data.Tables[0]);
                    dataGridView.DataSource = dataView;
                    break;
                case 2:
                    manager.DataViewSettings[4].RowFilter = $"Mark_ID= '{filter}'";
                    dataView = manager.CreateDataView(data.Tables[4]);
                    dataGridView.DataSource = dataView;
                    break;
                
            }
        

        }
        
    }
}
