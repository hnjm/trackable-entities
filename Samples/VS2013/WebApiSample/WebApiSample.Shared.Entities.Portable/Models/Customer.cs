using System;
using System.Collections.Generic;
using TrackableEntities.Client;

namespace WebApiSample.Shared.Entities.Portable.Models
{
    public partial class Customer : EntityBase
    {
		public Customer()
		{
			this.Orders = new ChangeTrackingCollection<Order>();
		}

		public string CustomerId
		{ 
			get { return _CustomerId; }
			set
			{
				if (Equals(value, _CustomerId)) return;
				_CustomerId = value;
				NotifyPropertyChanged(() => CustomerId);
			}
		}
		private string _CustomerId;

		public string CompanyName
		{ 
			get { return _CompanyName; }
			set
			{
				if (Equals(value, _CompanyName)) return;
				_CompanyName = value;
				NotifyPropertyChanged(() => CompanyName);
			}
		}
		private string _CompanyName;

		public string ContactName
		{ 
			get { return _ContactName; }
			set
			{
				if (Equals(value, _ContactName)) return;
				_ContactName = value;
				NotifyPropertyChanged(() => ContactName);
			}
		}
		private string _ContactName;

		public string City
		{ 
			get { return _City; }
			set
			{
				if (Equals(value, _City)) return;
				_City = value;
				NotifyPropertyChanged(() => City);
			}
		}
		private string _City;

		public string Country
		{ 
			get { return _Country; }
			set
			{
				if (Equals(value, _Country)) return;
				_Country = value;
				NotifyPropertyChanged(() => Country);
			}
		}
		private string _Country;

		public CustomerSetting CustomerSetting
		{
			get { return _CustomerSetting; }
			set
			{
				if (Equals(value, _CustomerSetting)) return;
				_CustomerSetting = value;
				CustomerSettingChangeTracker = _CustomerSetting == null ? null
					: new ChangeTrackingCollection<CustomerSetting> { _CustomerSetting };
				NotifyPropertyChanged(() => CustomerSetting);
			}
		}
		private CustomerSetting _CustomerSetting;
		private ChangeTrackingCollection<CustomerSetting> CustomerSettingChangeTracker { get; set; }

		public ChangeTrackingCollection<Order> Orders
		{
			get { return _Orders; }
			set
			{
				if (Equals(value, _Orders)) return;
				_Orders = value;
				NotifyPropertyChanged(() => Orders);
			}
		}
		private ChangeTrackingCollection<Order> _Orders;

	}
}
