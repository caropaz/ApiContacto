using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Persistence.Database
{
    public class DataBaseService: IDataBaseService
    {
        //ruta para acceder al archivo json
        private static string route = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory),"Persona.Persistence","Files");
        
        public List<PersonaEntity> GetAll() 
        {
            return null;
        }
    }
}
