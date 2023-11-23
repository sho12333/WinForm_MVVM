//using Microsoft.AspNetCore.Components;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace WinForm_MVVM.BindHelpers
//{
//    public sealed class BindingListAsync<T> : BindingList<T>
//    {
//        private Dispatcher _dispatcher;

//        public BindingListAsync(Dispatcher dispatcher)
//        {
//            _dispatcher = dispatcher;
//        }

//        protected override void OnListChanged(ListChangedEventArgs e)
//        {
//            _dispatcher.InvokeAsync(() => base.OnListChanged(e));
//        }
//    }
//}