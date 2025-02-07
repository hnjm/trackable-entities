//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiSample.Client.Entities.Temp
{
    using System;
    using System.Collections.Generic;
    using TrackableEntities.Client;
    
    public partial class Category : EntityBase
    {
        public Category()
        {
            this.Products = new ChangeTrackingCollection<Product>();
        }
        
    	public int CategoryId
    	{ 
    		get { return _CategoryId; }
    		set
    		{
    			if (Equals(value, _CategoryId)) return;
    			_CategoryId = value;
    			NotifyPropertyChanged(() => CategoryId);
    		}
    	}
    	private int _CategoryId;
        
    	public string CategoryName
    	{ 
    		get { return _CategoryName; }
    		set
    		{
    			if (Equals(value, _CategoryName)) return;
    			_CategoryName = value;
    			NotifyPropertyChanged(() => CategoryName);
    		}
    	}
    	private string _CategoryName;
    
    	public ChangeTrackingCollection<Product> Products
    	{
    		get { return _Products; }
    		set
    		{
    			if (Equals(value, _Products)) return;
    			_Products = value;
    			NotifyPropertyChanged(() => Products);
    		}
    	}
    	private ChangeTrackingCollection<Product> _Products;
    }
}
