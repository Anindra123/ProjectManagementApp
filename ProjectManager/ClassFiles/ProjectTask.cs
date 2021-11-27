﻿using System;
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
            if (s == "P")
            {
                return false;
            }
            return true;
        }

        public void FillAssignedTaskList(int pm_id)
        {

        }

    }
}