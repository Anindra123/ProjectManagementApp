﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public class ProjectManager : User
    {
        DataTable dt = new DataTable();
        public int PManager_ID { get; set; }
        public void FillData(string query)
        {
            dt.Clear();
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dt);
            }
        }
        public bool SignIn(string email, string pass)

        {
            bool ret = false;
            SqlConnection sqlConn = new SqlConnection(DBConnection.GetConnString());
            ProjectManager pM = new ProjectManager();
            sqlConn.Open();
            string query = $"SELECT * FROM  PManager_TBL WHERE PManager_Email ='{email}' AND PManager_Password = '{pass}'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConn);
            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                pM.PManager_ID = Convert.ToInt32(dtbl.Rows[0]["PMananger_ID"].ToString());
                pM.FirstName = (string)dtbl.Rows[0]["PManager_FirstName"];
                pM.LastName = (string)dtbl.Rows[0]["PManager_LastName"];
                pM.Email = (string)dtbl.Rows[0]["PManager_Email"];
                pM.password = (string)dtbl.Rows[0]["PManager_Password"];

                ret = true;
            }

            sqlConn.Close();
            return ret;


        }
        public void GetProjectManagerTitleForMember(int id)
        {
            string query = $"select pm.* from ManageProject_TBL as mp " +
                $", PManager_TBL as pm where mp.Project_ID = '{id}' and pm.PManager_ID = " +
                $" mp.PManager_ID";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                FirstName = dt.Rows[0]["PManager_FirstName"].ToString();
                LastName = dt.Rows[0]["PManager_LastName"].ToString();

            }
        }

    }
}
