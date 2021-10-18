using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
//using Android.Widget;
using LeadRat.Core;

namespace LeadRat.Droid.Views
{
    [Activity(Label = "ToDo", MainLauncher = true)]
    public class ToDo:BaseActivity<ToDoViewModel>
    {
        protected override int ActivityLayoutId
        {
            get => Resource.Layout.ToDo;
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ToDo);
            //ImageView imageView = FindViewById<ImageView>(Resource.Id.CalenderIcon);

            //var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            //SetSupportActionBar(toolbar);
        }

       
    }
}
