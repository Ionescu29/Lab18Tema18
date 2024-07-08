namespace Lab18Tema18.Models
/*O cheie va avea urmatoarele caracteristici
• Id (int)
• Cod de acces : Guid unic.*/
{
    internal class Key
    {
        public int Id { get; set; }
        public Guid AccessCode { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

    } 
}
