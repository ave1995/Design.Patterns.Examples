using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.BidirectionalObserver
{
    public class Window : INotifyPropertyChanged
    {
        private string productName;

        public string ProductName
        {
            get => productName;
            set
            {
                if (value == productName) return; // critical
                productName = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Window(Product product)
        {
            ProductName = product.Name;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(
          [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return $"Window: {ProductName}";
        }
    }
}
