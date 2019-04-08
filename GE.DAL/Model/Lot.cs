using System;
using System.Collections.Generic;
using System.Text;

namespace GE.DAL.Model
{
    public class Lot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        //TODO добавить поле для фотографий
        //TODO добавить отзывы

    }
}
