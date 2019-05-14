﻿using OrganizationalStructure.Data.Enums;
using OrganizationalStructure.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Data.Repositories
{
    public class SectionRepository
    {
        public List<Section> GetSectionsByLevel(OrganizationalLevel level)
        {
            List<Section> sections = new List<Section>();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = @"SELECT ID, Name, Code, OrganizationalLevel, ManagerID, SuperiorSectionID
                                    FROM Sections WHERE OrganizationalLevel = @level";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.Add("@level", SqlDbType.Int).Value = level;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Section section = new Section();
                            section.ID = reader.GetInt32(0);
                            section.Name = reader.GetString(1);
                            section.Code = reader.GetString(2);
                            section.OrganizationalLevel = (OrganizationalLevel)reader.GetInt32(3);
                            section.ManagerID = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4);
                            section.SuperiorSectionID = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5);
                            sections.Add(section);
                        }
                    }
                }
                catch(SqlException e)
                {
                    Debug.WriteLine(e.StackTrace);
                    Debug.WriteLine(e.Message);
                }
                return sections;
            }
        }

        public List<Section> GetSections(OrganizationalLevel level, int? superiorSectionId)
        {
            List<Section> sections = new List<Section>();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = @"SELECT ID, Name, Code, OrganizationalLevel, ManagerID, SuperiorSectionID
                                    FROM Sections WHERE OrganizationalLevel = @level AND SuperiorSectionID = @superiorSectionId";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.Add("@level", SqlDbType.Int).Value = level;
                    command.Parameters.Add("@superiorSectionId", SqlDbType.Int).Value = superiorSectionId;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Section section = new Section();
                            section.ID = reader.GetInt32(0);
                            section.Name = reader.GetString(1);
                            section.Code = reader.GetString(2);
                            section.OrganizationalLevel = (OrganizationalLevel)reader.GetInt32(3);
                            section.ManagerID = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4);
                            section.SuperiorSectionID = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5);
                            sections.Add(section);
                        }
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.StackTrace);
                    Debug.WriteLine(e.Message);
                }
                return sections;
            }
        }

        public List<Section> GetSectionsByCompany(string companyCode)
        {
            List<Section> sections = new List<Section>();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = @"SELECT ID, Name, Code, OrganizationalLevel, ManagerID, SuperiorSectionID
                                    FROM Sections WHERE Code LIKE '' + @CompanyCode + '%'";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.Add("@companyCode", SqlDbType.NVarChar).Value = companyCode;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Section section = new Section();
                            section.ID = reader.GetInt32(0);
                            section.Name = reader.GetString(1);
                            section.Code = reader.GetString(2);
                            section.OrganizationalLevel = (OrganizationalLevel)reader.GetInt32(3);
                            section.ManagerID = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4);
                            section.SuperiorSectionID = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5);
                            sections.Add(section);
                        }
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.StackTrace);
                    Debug.WriteLine(e.Message);
                }
                return sections;
            }
        }

        public bool InsertSection(Section section)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = @"INSERT INTO Sections (Name, Code, OrganizationalLevel, SuperiorSectionID)
                                        VALUES (@name, @code, @orgLevel, @superiorSectionId)";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = section.Name;
                    command.Parameters.Add("@code", SqlDbType.NVarChar).Value = section.Code;
                    command.Parameters.Add("@orgLevel", SqlDbType.Int).Value = (int) section.OrganizationalLevel;
                    command.Parameters.Add("@superiorSectionId", SqlDbType.Int).Value = (object)section.SuperiorSectionID ?? DBNull.Value  ;
                    return (command.ExecuteNonQuery() > 1);
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.StackTrace);
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
        }

        public bool UpdateSection(Section section)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = @"UPDATE Sections SET
                                        Name = @name,
                                        Code = @code,
                                        ManagerID = @managerId
                                        WHERE ID = @id";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = section.Name;
                    command.Parameters.Add("@code", SqlDbType.NVarChar).Value = section.Code;
                    command.Parameters.Add("@managerId", SqlDbType.Int).Value = (int)section.ManagerID;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = section.ID;
                    return (command.ExecuteNonQuery() > 1);
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.StackTrace);
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
        }

    }
}
