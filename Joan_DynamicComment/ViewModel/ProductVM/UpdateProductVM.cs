﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Joan_DynamicComment.ViewModel.ProductVM
{
	public class UpdateProductVM
	{

        public IFormFile[]? formFiles { get; set; }
        public List<string> Images { get; set; }
        public string Name { get; set; }
        [Range(0, int.MaxValue)]
        public int Price { get; set; }
        public int SalePercantage { get; set; }
        [MinLength(15)]
        public string Description { get; set; }
        [Range(0, int.MaxValue)]
        public int Count { get; set; }
        public int CategoryId { get; set; }
        public UpdateProductVM()
		{
            Images = new();
		}
	}
}

