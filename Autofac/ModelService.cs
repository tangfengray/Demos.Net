using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofunc
{
    public class ModelService
    {
        public Model GetModel()
        {
            return new Model() { ID = Guid.NewGuid(), Name = "wang" };
        }

        public bool UpdateModel(Model model)
        {
            return true;
        }

        public bool DeleteModel(Model model)
        {
            return true;
        }

        public bool AddModel(Model model)
        {
            Console.WriteLine(model.ID.ToString());
            Console.WriteLine(model.Name);
            return true;
        }
    }
}
