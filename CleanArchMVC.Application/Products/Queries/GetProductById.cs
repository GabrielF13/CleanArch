using CleanArchMvc.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Application.Products.Queries
{
    public class GetProductById : IRequest<Product>
    {
        public int Id { get; set; }
        public GetProductById(int id)
        {
            Id = id;
        }
    }
}
