using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofunc
{
    public class AutofacMgr
    {


        public static void Regist()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Model>();
            builder.RegisterType<ModelService>();
            //builder.RegisterType<SqlDatabase>().As<IDatabase>();
            //using (var container = builder.Build())
            //{
            //    var manager = container.Resolve<ModelService>();
            //    manager.AddModel(model);
            //}

            var containter = builder.Build();

            var man = containter.Resolve<ModelService>();
            man.AddModel(new Model() { ID = Guid.NewGuid(), Name = "haha" });
        }
    }
}
