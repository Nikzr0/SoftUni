using Azure;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;
using System.Security.Principal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Windows.Input;

namespace Ex01.InitialSetup
{
    public class Program
    {
        // Equal to pressing the connect button in Sql Server
        const string SqlConnectionString = "Server=.;Integrated Security=true;Database=MinionsDB;Encrypt=False";
        //const string SqlConnectionString = "Server=.;Database=master;Integrated Security=true";
        static void Main()
        {
            using (var connection = new SqlConnection(SqlConnectionString))
            {
                // Thisway we open the connection
                connection.Open();

            


            }
        }

        //Returns only one row with one column
        private static object ExecuteScalar(SqlConnection connection, string query)
        {
            using var command = new SqlCommand(query, connection);
            var result = command.ExecuteScalar();

            return result;
        }

        private static string[] GetCreateTableStatments()
        {
            var result = new string[]
            {
                 "Use MinionsDB",
                 "create table Countries (id int primary key identity, Name varchar(30) )",
                 "create table Towns (id int primary key identity, Name varchar(30), CountyCode varchar(30) )",
                 "create table Minions ( id int primary key identity, Name varchar(30), Age int, TownID int references Towns(id) )",
                 "create table EvilnessFactors ( id int primary key identity, Name varchar(30) )",
                 "create table Villains ( id int primary key identity, Name varchar(30), EcilnessFactorIndex int references EvilnessFactors(id))",
                 "create table MinionsVillains ( MinionId int references Minions(id), VillainId int references Villains (id) constraint PK_MinionsVillains Primary key(MinionId, VillainId))"
            };

            return result;
        }
        private static string[] InsertIntoTablesMethod()
        {
            var result = new string[]
            {
                "INSERT INTO Countries (Name) VALUES ('Bulgaria'), ('Norway'), ('Cyprus'), ('Greece'), ('UK')",
                "INSERT INTO Towns (Name, CountyCode) VALUES ('Plovdiv', 1), ('Oslo', 2), ('Larnaca', 3), ('Athens', 4), ('London', 5)",
                "INSERT INTO Minions(Name,Age,TownID) VALUES ('Stoyan', 12, 1), ('George', 22, 2), ('Ivan', 25, 3), ('Kiro', 35, 4), ('Niki', 25, 5)",
                "INSERT INTO EvilnessFactors(Name) VALUES ('super good'), ('good'), ('bad'),('evil1'), ('super evil')",
                "INSERT INTO Villains(Name,EcilnessFactorIndex) VALUES ('Gru', 1), ('Ivo', 2), ('Teo', 3),('Sto', 4),('Pro', 5)",
                "INSERT INTO MinionsVillains VALUES (1,1), (2,2), (3,3), (4,4), (5,5)"
            };

            return result;
        }
        public static void Ex6()
        {
            // A number
            int value = int.Parse(Console.ReadLine());

            string evilNameQuery = "SELECT Name FROM Villains WHERE Id = @villainId";
            using var sqlCommand = new SqlCommand(evilNameQuery, connection);

            sqlCommand.Parameters.AddWithValue("@villainId", value);

            var name = sqlCommand.ExecuteScalar();
            if (name == null)
            {
                Console.WriteLine("No such villain was found.");
                return;
            }

            var deleteMinionsVillainsQuery = @"DELETE FROM MinionsVillains WHERE VillainId = @villainId";
            // Sth to acticate the command
            using var sqlDeleteMVCommand = new SqlCommand(deleteMinionsVillainsQuery, connection);
            // Sth to give value to the variable
            sqlDeleteMVCommand.Parameters.AddWithValue("@villainId", value);
            // Affected Rows
            var affectedRows = sqlDeleteMVCommand.ExecuteNonQuery();

            var deleteVillainQuery = @"DELETE FROM Villains WHERE Id = @villainId ";

            using var deleteVCommand = new SqlCommand(deleteVillainQuery, connection);
            deleteVCommand.Parameters.AddWithValue("@villainId", value);
            var aRows = deleteVCommand.ExecuteNonQuery();

            Console.WriteLine($"{name} was deleted. ");
            Console.WriteLine($"{affectedRows} minions were released. ");
        }
        public static void Ex5()
        {

            //Country code is not a primary key
 //           string countryName = Console.ReadLine();

 //           string UpdateTownNamesQuesry = @"UPDATE Towns
 //  SET Name = UPPER(Name)
 //WHERE CountryCode = (SELECT c.Id FROM Countries AS c WHERE c.Name = @countryName)";

 //           string selectTownNameQuery = @"SELECT t.Name 
 //  FROM Towns as t
 //  JOIN Countries AS c ON c.Id = t.CountryCode
 // WHERE c.Name = @countryName";

 //           using var updateCommand = new SqlCommand(UpdateTownNamesQuesry, connection);
 //           updateCommand.Parameters.AddWithValue("@CountryName", countryName);
 //           var affectedRows = updateCommand.ExecuteNonQuery();

 //           if (affectedRows == 0)
 //           {
 //               Console.WriteLine($"No town names were affected.");
 //           }
 //           else
 //           {
 //               Console.WriteLine($"{affectedRows} town names were affected.");

 //               using var selectCommand = new SqlCommand(selectTownNameQuery, connection);
 //               selectCommand.Parameters.AddWithValue("@CountryName", countryName);

 //               using (var reader = selectCommand.ExecuteReader())
 //               {
 //                   var towns = new List<string>();

 //                   while (reader.Read())
 //                   {
 //                       towns.Add((string)reader[0]);
 //                   }

 //                   Console.WriteLine($"[{string.Join(", ", towns)}]");
 //               }
 //           }
        }
        public static void Ex3And2And1()
        {
            // Create Database
            {
                //var cmd = new SqlCommand(createDatabase, connection);
                //cmd.ExecuteNonQuery();
            }
            //Create Tables
            {
                //var crateTableStatments = GetCreateTableStatments();
                //foreach (var query in crateTableStatments)
                //{
                //    //ExecuteNonQuery(connection, query);

                //    var cmd2 = new SqlCommand(query, connection);
                //    cmd2.ExecuteNonQuery();
                //}

            }
            //Insert Into Tables
            {
                //var InsertDataStatments = InsertIntoTablesMethod();
                //foreach (var item in InsertDataStatments)
                //{
                //    var inserExec = new SqlCommand(item, connection);
                //    inserExec.ExecuteNonQuery();
                //}
            }
            //Select 
            {
                //string query = @"SELECT Name, COUNT(mv.MinionId) as MinionCount
                //    FROM Villains AS v
                //    JOIN MinionsVillains AS mv ON v. Id = mv.VillainId
                //    GROUP BY v.Id, v.Name";

                //using (var command = new SqlCommand(query, connection) )
                //{
                //    using (var reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            var name = reader[0];
                //            var count = reader[1];

                //            Console.WriteLine($"{name} - {count}");
                //        }                         
                //    }
                //}
            }
        }
        public static void Ex4()
        {        
        //    int id = int.Parse(Console.ReadLine());

        //    string vQuery = "SELECT Name FROM Villains WHERE Id = @Id";

        //    string mQuery = @"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) as RowNum,
        //                                 m.Name, 
        //                                 m.Age
        //                            FROM MinionsVillains AS mv
        //                            JOIN Minions As m ON mv.MinionId = m.Id
        //                           WHERE mv.VillainId = @Id
        //                        ORDER BY m.Name";

        //    using var command = new SqlCommand(vQuery, connection);
        //    command.Parameters.AddWithValue("@Id", id);
        //    var result = command.ExecuteScalar();

        //    if (result == null)
        //    {
        //        Console.WriteLine($"No villain with ID {id} exists in the database.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Villain: {result}.");

        //        using (var minionCommand = new SqlCommand(mQuery, connection))
        //        {
        //            minionCommand.Parameters.AddWithValue("@Id", id);
        //            using (var reader = minionCommand.ExecuteReader())
        //            {
        //                if (!reader.HasRows)
        //                {
        //                    Console.WriteLine("(no minions)");
        //                }

        //                while (reader.Read())
        //                {
        //                    Console.WriteLine($"{reader[0]}. {reader[1]} {reader[2]}");
        //                }
        //            }
        //        }
        //    }
        }
    }
}