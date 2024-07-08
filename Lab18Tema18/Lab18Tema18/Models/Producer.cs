namespace Lab18Tema18.Models
/*Producatorul va avea
• Id:int
• Nume
• Adresa:string*/
{
    internal class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Vehicle> Vehicles { get; set; } = [];

    }
}
