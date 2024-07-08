using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Un autovehicul este caracterizat de urmatoarele proprietati
• Id:int
• Nume
• Producator
• Un numar variabil de chei (de la una la oricate)
• O carte tehnica*/

namespace Lab18Tema18.Models
{
    internal class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }

        public List<TehnicalBook> TehnicalBooks { get; set; } = [];
        public List<Key> Keys { get; set; } = [];
    }
}
