using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace WebApplication_Mysql.Models
{
    public class CustomerContext
    {
        public  string ConnectionString { get; set;  }

        public CustomerContext(String connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<PersonalDetails> GetAllPersonalDetails()
        {
            List<PersonalDetails> personalDetails = new  List<PersonalDetails>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from personaldetails",conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        personalDetails.Add(new PersonalDetails()
                            {
                                   NRIC =  Convert.ToInt32(reader["NRIC"]),
                                   Name =  reader["Name"].ToString(),
                                   Email =  reader["Email"].ToString()
                            }
                        );
                    }
                }
            }
            return personalDetails;

        }
    }

    
}
