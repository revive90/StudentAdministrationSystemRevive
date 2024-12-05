﻿using StudentAdministrationSystemRevive.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.DataAccess
{
    public class ModuleRepository
    {
        //private readonly string _connectionString;

        //public ModuleRepository(string connectionString)
        //{
        //    _connectionString = connectionString;
        //}

        // Method to insert a module
        public bool InsertModule(Module module)
        {
            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();
                string query = "INSERT INTO Modules (ModuleID, ModuleTitle, ModuleDescription) VALUES (@ModuleID, @ModuleTitle, @ModuleDescription)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ModuleID", module.ModuleID);
                    command.Parameters.AddWithValue("@ModuleTitle", module.ModuleTitle);
                    command.Parameters.AddWithValue("@ModuleDescription", module.ModuleDescription);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<Module> GetModulesByTitle(string title)
        {
            var modules = new List<Module>();

            try
            {
                using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
                {
                    connection.Open();
                    var cmd = new SQLiteCommand("SELECT ModuleID, ModuleTitle, ModuleDescription FROM Modules WHERE ModuleTitle LIKE @Title", connection);
                    cmd.Parameters.AddWithValue("@Title", "%" + title + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var module = new Module
                            (
                                reader["ModuleID"].ToString(),
                                reader["ModuleTitle"].ToString(),
                                reader["ModuleDescription"].ToString()
                            );
                            modules.Add(module);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return modules;
        }

        // Remove Module
        public bool RemoveModule(string moduleID)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
                {
                    connection.Open();

                    
                    using (var transaction = connection.BeginTransaction())
                    {
                        // Delete from DegreeProgrammeModules table
                        var cmd1 = new SQLiteCommand("DELETE FROM DegreeProgrammeModules WHERE ModuleID = @ModuleID", connection);
                        cmd1.Parameters.AddWithValue("@ModuleID", moduleID);
                        cmd1.ExecuteNonQuery();

                        // Delete from Modules table
                        var cmd2 = new SQLiteCommand("DELETE FROM Modules WHERE ModuleID = @ModuleID", connection);
                        cmd2.Parameters.AddWithValue("@ModuleID", moduleID);
                        cmd2.ExecuteNonQuery();

                        int rowsAffected = cmd2.ExecuteNonQuery();

                        transaction.Commit();

                        return rowsAffected > 0;
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        // Update Module

        public void UpdateModule(string moduleID, string moduleTitle, string moduleDescription)
        {
            string query = "UPDATE Modules SET ModuleTitle = @ModuleTitle, ModuleDescription = @ModuleDescription WHERE ModuleID = @ModuleID";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@ModuleID", moduleID);
                    command.Parameters.AddWithValue("@ModuleTitle", moduleTitle);
                    command.Parameters.AddWithValue("@ModuleDescription", moduleDescription);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No changes made or invalid data.");
                    }

                }
            }
        }

    }
}