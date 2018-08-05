﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProTank_v1
{
    class User
    {
        public String uname { set; get; }
        private String pwd { get; }
        public String rol { get; }

        private SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["protankDB"].ConnectionString);

        public User(String uname, String pwd, String rol)
        {
            this.uname = uname;
            this.pwd = pwd;
            this.rol = rol;
        }

        public User getUser(String uname)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM userLogin WHERE uname = @uname", cnx);
            cmd.Parameters.AddWithValue("@uname", uname);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            cnx.Close();
            return new User(reader.GetValue(0).ToString(), reader.GetValue(0).ToString(), reader.GetValue(0).ToString());
        }

        public Boolean insUser(User u)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO userLogin VALUES (@uname, @pwd, @rol)", cnx);
            cmd.Parameters.AddWithValue("@uname", u.uname);
            cmd.Parameters.AddWithValue("@pwd", u.pwd);
            cmd.Parameters.AddWithValue("@rol", u.rol);
            int i = cmd.ExecuteNonQuery();
            cnx.Close();
            return (i == 1);
        }

        public Boolean upUser(User u)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("UPDATE userLogin SET uname = @uname, pwd = @pwd, rol = @rol WHERE uname = @uname", cnx);
            cmd.Parameters.AddWithValue("@uname", u.uname);
            cmd.Parameters.AddWithValue("@pwd", u.pwd);
            cmd.Parameters.AddWithValue("@rol", u.rol);
            int i = cmd.ExecuteNonQuery();
            cnx.Close();
            return (i == 1);
        }

        public DataTable tableUser()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM userLogin", cnx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public DataTable tableUserBy(String query)
        {
            SqlCommand cmd = new SqlCommand(query, cnx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        /*Coneccion con la base de datos*/

    }
}
