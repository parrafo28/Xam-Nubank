﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nubank.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DashboardPanel : ViewCell
	{
		public DashboardPanel ()
		{
			InitializeComponent ();
		}
	}
}