using CinemaKrakow.Data.Models;
using CinemaKrakow.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CinemaKrakow.Web.Api
{
    public class MoviesController : ApiController
    {
        private readonly IMovieData db;

        public MoviesController(IMovieData db)
        {
            this.db = db;
        }

        public IEnumerable<Movie> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}
