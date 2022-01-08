namespace MMag.Data.Models
{
    public class Instrument
    {
        public int id { get; set; }
        public string instrumentName { get; set; }

        public string shortDesc { get; set; }

        public string year { get; set; }
        public string img { get; set; }

        public uint price { get; set; }

        public bool isFavourite { get; set; }//true - na glavnoi,false - ne na glavnoi

        public bool available { get; set; }//esli v nalichie, kol-vo

        public int categoryID { get; set; }

        public virtual Category Category { get; set; }


    }
}
