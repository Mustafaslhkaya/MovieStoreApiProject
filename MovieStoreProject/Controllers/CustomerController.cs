﻿using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using MovieStoreProject.DataAccess;
using MovieStoreProject.Entities;
using MovieStoreProject.Models.CustomerModels;
using MovieStoreProject.Models.MovieModels.Add;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MovieStoreProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public CustomerController(Context context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        [HttpPost]
        public void AddCustomer([FromBody] AddCustomerModel model)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.CustomerName == model.CustomerName);
            if (customer is not null)
            {
                throw new InvalidOperationException("Müsteri zaten var.");
            }
            //customer = new Customer();
            //customer.CustomerName = model.CustomerName;
            //customer.CustomerSurname = model.CustomerSurname;
            //customer.FavouriteCategories = model.FavouriteCategories;
            customer=_mapper.Map<Customer>(model);
            AddCustomerValidator validator = new AddCustomerValidator();
            validator.ValidateAndThrow(model);

            _context.Customers.Add(customer);
            _context.SaveChanges();

         }
        
        [HttpDelete]

        public void DeleteCustomer(int id)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.CustomerId == id);
            if (customer is null)
            {
                throw new InvalidOperationException("Böyle bir müşteri zaten yok..");
            }
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

    }

    
    
    
}
