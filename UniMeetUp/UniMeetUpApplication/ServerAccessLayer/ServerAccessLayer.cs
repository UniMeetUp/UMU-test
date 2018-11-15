﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UniMeetUpApplication.Model;
using UniMeetUpApplication.ServerAccessLayer.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace UniMeetUpApplication.ServerAccessLayer
{
    public class ServerAccessLayer : IServerAccessLayer
    {
        private HttpClient client = new HttpClient();

        public ServerAccessLayer()
        {
            client.BaseAddress = new Uri("https://localhost:44364/");
        }

        public  HttpStatusCode Check_if_Email_and_Password_is_in_database(UserForLogin userForLogin)
        {
            //HttpResponseMessage response = await client.PostAsJsonAsync("api/Users/login", userForLogin); DUER IKKE!!!!!
            var response = client.PostAsJsonAsync("api/Users/login", userForLogin).Result;
            
            return response.StatusCode;
        }

        public string Get_user_from_database(string email)
        {
            var str =
                  client.GetStringAsync($"api/Users/{email}").Result;

            return str;
        }

        public string Get_groups_for_specific_user(string email)
        {
            var str =
                client.GetStringAsync($"api/Group/").Result;

            return str;
        }

        public void Create_Account_In_Database(UserForCreateAccount userForCreateAccount)
        {
            //Do something
        }

        public bool Check_In_Database_If_Email_Is_Already_In_Use(string username)
        {
            //Do something
            return false;
        }
    }
}
