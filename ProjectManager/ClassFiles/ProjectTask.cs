using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public class ProjectTask
    {

        public int Task_ID { get; set; }
        public string Task_Title { get; set; }
        public string Task_Desc { get; set; }
        public int Task_Completed { get; set; }
        public DateTime Task_CompleteDate { get; set; }
        public string Task_Comment { get; set; }
        public byte[] Task_Attached { get; set; }
        public int PManager_ID { get; set; }
        public int Project_ID { get; set; }
        public int PMember_ID { get; set; }

        DataTable dt = new DataTable();
        public void FillData(string query)
        {
            dt.Clear();
            dt.Columns.Clear();
            dt.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dt);
            }
        }
        public bool RunQuery(string query)
        {
            bool ret = false;
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    ret = true;
                }
            }
            return ret;
        }
        public DataTable CheckAssingedToMember(int pm_id)
        {

            string query = $"select * from PerformTask_TBL where " +
                $"PMember_ID = '{pm_id}'";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
        public bool CheckAssingedToMember(int pm_id, int task_id)
        {

            string query = $"select * from PerformTask_TBL where " +
                $"PMember_ID = '{pm_id}' and Task_ID = '{task_id}'";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteFromTaskTable()
        {
            string query = $"delete from Task_TBL where " +
                $"Task_ID = '{Task_ID}'";
            return RunQuery(query);
        }
        public bool DeleteFromAssignTaskTable()
        {
            string query = $"delete from AssignTask_TBL where " +
                   $"Task_ID = '{Task_ID}'";
            return RunQuery(query);
        }
        public bool DeleteFromPerformTaskTable()
        {
            string query = $"delete from PerformTask_TBL where " +
                   $"Task_ID = '{Task_ID}'";
            return RunQuery(query);
        }
        public bool CheckTaskStatus(int s_id)
        {
            string s;
            string query = $"select StatusName from TaskStatus_TBL where StatusID = '{s_id}'";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmnd = new SqlCommand(query, conn);
                cmnd.Connection.Open();
                s = (string)cmnd.ExecuteScalar();
            }
            if (s == "Pending")
            {
                return false;
            }
            return true;
        }

        public DataTable FillAssignedTaskList(int pm_id)
        {
            string query = $"select pt.Task_Title as Title,pt.Task_Desc as Description,ts.StatusName as Status from " +
                $"PerformTask_TBL as pt,TaskStatus_TBL as ts where " +
                $"pt.PMember_ID = '{pm_id}' and ts.StatusID = pt.Task_Completed;";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }

        public string GetStatus()
        {
            string s;
            string query = $"select StatusName from TaskStatus_TBL where StatusID = '{Task_Completed}'";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmnd = new SqlCommand(query, conn);
                cmnd.Connection.Open();
                s = (string)cmnd.ExecuteScalar();
            }
            return s;
        }

        public bool GetCompletedTask()
        {
            string query = $"select Task_Attached,Task_Comment from PerformTask_TBL" +
                $" where Task_ID = '{Task_ID}' ";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0]["Task_Attached"] != null && dt.Rows[0]["Task_Comment"] != null)
                {

                    Task_Attached = (byte[])dt.Rows[0]["Task_Attached"];
                    Task_Comment = $"{dt.Rows[0]["Task_Comment"]}";
                    return true;
                }

            }
            return false;
        }
        public DataTable GetTaskListFromProject(int proj_id)
        {
            string query = $"select at.Task_ID as ID,at.Task_title as Title,at.Task_Desc as Description,ts.StatusName as Status from" +
               $" Task_TBL as at,TaskStatus_TBL as ts" +
               $" where at.Project_ID = '{proj_id}' and at.Task_Completed = '1' and ts.StatusID = at.Task_Completed ";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }

            return null;

        }

    }
}
