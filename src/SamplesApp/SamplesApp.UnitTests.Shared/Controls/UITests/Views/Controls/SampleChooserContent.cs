﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Windows.UI.Xaml;

namespace SampleControl.Entities
{
	public class SampleChooserContent : INotifyPropertyChanged
	{
		public string ControlName { get; set; }
		public Type ViewModelType { get; set; }
		public Type ControlType { get; set; }
		public string Description { get; set; }

		bool _isFavorite;
		public bool IsFavorite
		{
			get
			{
				return _isFavorite;
			}
			set
			{
				if (_isFavorite != value)
				{
					_isFavorite = value;
					RaisePropertyChanged();
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		// override object.Equals
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return this.Equals(obj as SampleChooserContent);
			}
			return false;
		}

		public bool Equals(SampleChooserContent content)
		{
			return content?.ControlName == this.ControlName;
		}

		// override object.GetHashCode
		public override int GetHashCode()
		{
			return ControlName.GetHashCode();
		}

		protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
