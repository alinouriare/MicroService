﻿using Domain.CommandResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
  public  class AddProductCommand:IRequest<AddProductResult>
    {

        public string Title { get; set; }

        public string Body { get; set; }

        public DateTime CreateAt { get; set; }

        public decimal Price { get; set; }

        public string ImagePath { get; set; }
        public string FilePath { get; set; }

        public short ProductCategoryId { get; set; }


        public bool IsVisible { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsSallable { get; set; }
    }
}
