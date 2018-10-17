using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using landscape_generator;
namespace landscape_generator.Presenters
{
    public class DataGeneratorPresenter
    {
        Views.Interfaces.IDataGenerator view;
        Models.IDataGenerator model;

        public DataGeneratorPresenter(Views.Interfaces.IDataGenerator view, Models.IDataGenerator model)
        {
            this.view = view;
            this.model = model;

            this.view.tempEvent += this.model.testMethod;
        }

    }
}
