//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaEstoqueVendas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedido
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public Nullable<int> ProdutoId { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> Total { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Produto Produto { get; set; }
    }
}