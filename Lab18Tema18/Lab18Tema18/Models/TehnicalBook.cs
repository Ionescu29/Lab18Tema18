namespace Lab18Tema18.Models

/*Cartea tehnica va avea urmatoarele:
• Id:int
• Capacitate cilindrica :int
• An de fabricatie :int
• Serie de sasiu: string*/
{
    internal class TehnicalBook
    {
        public int Id { get; set; }
        public int CilindricalCapacity { get; set; }
        public int FabYear { get; set; }
        public string ChassisSeries { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
