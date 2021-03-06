﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Uno.Extensions;

namespace Windows.UI.Xaml.Data
{
	public partial class CollectionViewSource : DependencyObject
	{
		public CollectionViewSource()
		{
			InitializeBinder();
		}

		#region Dependency Properties
		public bool IsSourceGrouped
		{
			get { return (bool)this.GetValue(IsSourceGroupedProperty); }
			set { this.SetValue(IsSourceGroupedProperty, value); }
		}

		// Using a DependencyProperty as the backing store for IsSourceGrouped.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty IsSourceGroupedProperty =
			DependencyProperty.Register("IsSourceGrouped", typeof(bool), typeof(CollectionViewSource), new PropertyMetadata(false, (o, e) => ((CollectionViewSource)o).UpdateView()));



		public object Source
		{
			get { return (object)this.GetValue(SourceProperty); }
			set { this.SetValue(SourceProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty SourceProperty =
			DependencyProperty.Register("Source", typeof(object), typeof(CollectionViewSource), new PropertyMetadata(null, (o, e) => ((CollectionViewSource)o).UpdateView()));

		private void UpdateView()
		{
            if (Source is IEnumerable enumerable)
            {
                View = new CollectionView(enumerable, IsSourceGrouped);
            }
            else
            {
                View = null;
            }
		}

		#endregion

		public ICollectionView View { get; private set; }
	}
}
