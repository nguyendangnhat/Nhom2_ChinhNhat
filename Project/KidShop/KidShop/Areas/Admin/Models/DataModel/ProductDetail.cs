﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kidshop.Areas.Admin.Models.DataModel
{
    [Table("ProductDetail")]
    public class ProductDetail
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ProductDetailId { get; set; }

        [Display(Name="Sản phẩm")]
        public int? ProductId { get; set; }

        [Display(Name="Kích cỡ")]
        [Column(TypeName="varchar")]
        [StringLength(10)]
        public string Size { get; set; }

        [Display(Name = "Màu sắc")]
        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Color { get; set; }

        [Display(Name="Số lượng")]
        public int Qty { get; set; }

        [Display(Name="Giá")]
        public double Price { get; set; }

        public virtual Product Product { get; set; }
    }
}