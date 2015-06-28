using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if DEBUG
// We need reflection in order to debug our Property Changed Notifications
using System.Reflection;
#endif

namespace Shelf.ViewModels
{
    public abstract class AbstractViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void Notify(string name)
        {
#if DEBUG
            // This will detect and throw an error if we attempt to Notify a change on a none existant property.
            // This helps eliminate stupid mistakes like spelling errors by turning them into runtime errors
            // This code is only included in the debug builds of the app, this prevents us from slowing down production code.
            Type type = this.GetType();
            PropertyInfo property = type.GetRuntimeProperty(name);
            if (property == null)
            {
                throw new InvalidOperationException(String.Format("Attempting to Notify a change on a property ({0}) that does not exist.", name));
            }
#endif

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
