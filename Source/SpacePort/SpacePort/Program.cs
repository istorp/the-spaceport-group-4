﻿using System;
using System.Collections.Generic;
using RestSharp;
using RestSharp.Authenticators;
using System.Linq;
using Newtonsoft.Json;

namespace SpacePort
{
    class Program
    {
        static void Main(string[] args)
        {

            StarWarsApi s = new StarWarsApi();
            var obj = s.ShowData("people");

            //var name = 
            foreach (var v in obj.results)
            {
                Console.WriteLine(v.name);
            }
            //var client = new RestClient("https://swapi.co/api/");
            //var request = new RestRequest("people/", DataFormat.Json);
            //var peopleResponse = client.Get<People>(request);

            //Console.WriteLine(peopleResponse.Data.Count);
            //foreach (var p in peopleResponse.Data.Name)
            //{
            //    Console.WriteLine(p);
            //}

            //var path = new RestClient("https://swapi.co/api/");
            //var request = new RestRequest("people/", Method.GET);
            //var response = path.Execute(request);
            //var result = response.Content.ToString();
            //var data = JsonConvert.SerializeObject(result);
            //foreach(var res in result)
            //Console.WriteLine(res);

            /*var client = new RestClient("https://swapi.co/api/");
            var request = new RestRequest("people/", DataFormat.Json);
            var peopleResponse = client.Get<Swreponse>(request);

            Console.WriteLine(peopleResponse.Data.Count);
            foreach (var p in peopleResponse.Data.Results)
            {
                Console.WriteLine(p.Name);
            }*/

            //jsonc

            //client.Authenticator = new HttpBasicAuthenticator("username", "password");

            //var request = new RestRequest("people.json", DataFormat.Json);

            //var response = client.Get(request);

            //client.Execute(response);
            //var name = response.Content.Where(x => x.namee == "Luke Skywalker" );
            //Testing
            //string[] arr = { "Large", "Medium", "Small", "Small" };

            //Dictionary<string, int> dict = new Dictionary<string, int>();

            //foreach (string s in arr)
            //{
            //    if (!dict.ContainsKey(s))
            //        dict.Add(s, 10);
            //}

            //foreach (KeyValuePair<string, int> k in dict)
            //    Console.WriteLine(k);

            //Console.WriteLine("BUY");
            //CheckInParking("Large", dict);
            //CheckInParking("Large", dict);
            //CheckInParking("Medium", dict);
            //CheckInParking("Medium", dict);
            //CheckInParking("Medium", dict);
            //CheckInParking("Medium", dict);

            //foreach (KeyValuePair<string, int> k in dict)
            //    Console.WriteLine(k);

            //Console.WriteLine("SELL");
            //CheckOutParking("Medium", dict);
            //CheckOutParking("Medium", dict);

            //foreach (KeyValuePair<string, int> k in dict)
            //    Console.WriteLine(k);
        }

        //static void CheckInParking(string type, Dictionary<string, int> dict)
        //{
        //    dict[type] -= 1;
        //}

        //static void CheckOutParking(string type, Dictionary<string, int> dict)
        //{
        //    dict[type] += 1;
        //}
    }
}
