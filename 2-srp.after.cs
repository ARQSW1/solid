using System;
using System.Collections.Generic;
using System.Linq;
using System.Files


/// <summary>
/// Clase que no cumple el SRP
/// </summary>
public class Customer
{
    /// <summary>
    /// Agrega el cliente a la base de datos
    /// </summary>
    public void AddCustomer()
    {
        // TODO: Code for adding a customer to the database
    }
}

public class EmailService
{
    public void SendEmail(IEmail email)
    {
        // Code for sending an email
    }
}

/// <summary>
/// Interface para un email
/// </summary>
public interface IEmail
{
    List<string> To { get; set; }
    List<string> Cc { get; set; }
    List<string> Cco { get; set; }
    string Subject {get; set; }
    List<Files> Attachments{get; set; }
}