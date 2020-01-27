using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace Usuarios.Models
{
    public class Usuario 
    {
        public Usuario(int id, string name, string username, string email, Address address, string phone, string website, Company company)
        {
            Id = id;
            Name = name;
            Username = username;
            Email = email;
            Address = address;
            Phone = phone;
            Website = website;
            Company = company;
        }
        
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("address")]
        public Address Address { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("website")]
        public string Website { get; set; }
        [JsonProperty("company")]
        public Company Company { get; set; }
    }
}
