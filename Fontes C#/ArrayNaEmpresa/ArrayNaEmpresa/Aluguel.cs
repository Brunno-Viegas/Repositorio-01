using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNaEmpresa {
    internal class Aluguel {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Aluguel() {
        }

        public Aluguel(string name, string email, int room) {
            this.Name = name;   //obs: utilizar o This quando o nome do parâmetro for igual ao nome da clase. Ex: This.name = name; 
            this.Email = email;
            this.Room = room;
        }

        public override string ToString() {
            return $"{Room}: {Name}, {Email}";
        }
    }
}
