using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.BidirectionalObserver
{
    public sealed class BidirectionalBinding : IDisposable
    {
        private bool disposed;

        public BidirectionalBinding(
          INotifyPropertyChanged first,
          Expression<Func<object>> firstProperty,
          INotifyPropertyChanged second,
          Expression<Func<object>> secondProperty)
        {
            if (firstProperty.Body is MemberExpression firstExpr
                && secondProperty.Body is MemberExpression secondExpr)
            {
                if (firstExpr.Member is not PropertyInfo firstProp
                    || secondExpr.Member is not PropertyInfo secondProp)
                {
                    return;
                }

                first.PropertyChanged += (sender, args) =>
                {
                    if (!disposed)
                    {
                        secondProp.SetValue(second, firstProp.GetValue(first));
                    }
                };
                second.PropertyChanged += (sender, args) =>
                {
                    if (!disposed)
                    {
                        firstProp.SetValue(first, secondProp.GetValue(second));
                    }
                };
            }
        }

        public void Dispose()
        {
            disposed = true;
        }
    }
}
