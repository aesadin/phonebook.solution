using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace PhoneBook.Models 
{
  public class Contact 
  {
    public string First {get; set;}
    public string Last {get; set;}
    public string Number {get; set;}
    public string Email {get; set;}
    public int Id {get; set;}
    public List<Contact> Contacts { get; set; }
  
    public Contact(string first, string last, string number, string email)
    {
      First = first;
      Last = last;
      Number = number;
      Email = email;
    }
    public Contact(string first, string last, string number, string email, int id)
    {
      First = first;
      Last = last;
      Number = number;
      Email = email;
      Id = id;
    }
    
    public override bool Equals(System.Object otherContact)
    {
      if (!(otherContact is Contact))
      {
        return false;
      }
      else
      {
        Contact newContact = (Contact)otherContact;
        bool idEquality = (this.Id == newContact.Id);
        bool emailEquality = (this.Email == newContact.Email);
        return (idEquality && emailEquality);
      }
    }
    public static List<Contact> GetAll()
    {
      List<Contact> allContacts = new List<Contact> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * From items;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while (rdr.Read())
      {
        int contactId = rdr.GetInt32(0);
        string contactFirst = rdr.GetString(1);
        string contactLast = rdr.GetString(2);
        string contactNumber = rdr.GetString(3);
        string contactEmail = rdr.GetString(4);
        Contact newContact = new Contact(contactFirst, contactLast, contactNumber, contactEmail, contactId);
        allContacts.Add(newContact);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allContacts;
    }
    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM contacts;";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
    public static Contact Find(int id)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM `contacts` WHERE id = @thisId;";

      MySqlParameter thisId = new MySqlParameter();
      thisId.ParameterName = "@thisId";
      thisId.Value = id;
      cmd.Parameters.Add(thisId);
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      int contactId = 0;
      string contactEmail = "";
      string contactFirst = "";
      string contactLast = "";
      string contactNumber = "";
      while (rdr.Read())
      {
        contactId = rdr.GetInt32(0);
        contactFirst = rdr.GetString(1);
        contactLast = rdr.GetString(2);
        contactNumber = rdr.GetString(3);
        contactEmail = rdr.GetString(4);
      }
      Contact foundContact = new Contact(contactFirst, contactLast, contactNumber, contactEmail, contactId);
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return foundContact;
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;

      
      // Begin first param
      cmd.CommandText = @"INSERT INTO contacts (first) VALUES (@ContactFirst);";
      MySqlParameter first = new MySqlParameter();
      first.ParameterName = "@ContactFirst";
      first.Value = this.First;
      cmd.Parameters.Add(first);
      
      // Beging second param
      cmd.CommandText = @"INSERT INTO contacts (last) VALUES (@ContactLast);";
      MySqlParameter last = new MySqlParameter();
      last.ParameterName = "@ContactLast";
      last.Value = this.Last;
      cmd.Parameters.Add(last);

      cmd.CommandText = @"INSERT INTO contacts (number) VALUES (@ContactNumber);";
      MySqlParameter number = new MySqlParameter();
      number.ParameterName = "@ContactNumber";
      number.Value = this.Number;
      cmd.Parameters.Add(number);

      cmd.CommandText = @"INSERT INTO contacts (email) VALUES (@ContactEmail);";
      MySqlParameter email = new MySqlParameter();
      email.ParameterName = "@ContactEmail";
      email.Value = this.Email;
      cmd.Parameters.Add(email);

      cmd.ExecuteNonQuery();
      Id = (int) cmd.LastInsertedId;

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
  }
}

