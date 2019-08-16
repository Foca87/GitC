﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Models;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] // O correto é fazer a liberação do Cors para cada método e não para a classe inteira por questão de segurança.

    public class ValuesController : ApiController
    {
        LocacaoDB locacaoDB = new LocacaoDB();

        // GET api/values
        //[EnableCors(origins:"*",headers:"*",methods:"*")]   //Habilita-se o Cors para cada método.
        public List<Carro> Get()
        {
            return locacaoDB.Carros.ToList<Carro>();
        }
        /*public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
