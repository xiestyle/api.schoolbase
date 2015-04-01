// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Collections.Generic;
using System.Linq;

namespace api.schoolbase.entities.DBBase
{
    public class FakeOKBaseEntities : FakeOKBaseEntitiesBase
    {
                #region Function Imports
    	

                #endregion

    
    	public override int SaveChanges()
    	{
    		return 0;
    	}
    	
    	public override void DiscardChanges()
    	{
    	}
    	
    	public virtual IEnumerable<T> ExecuteFunction<T>(string functionName, params object[] parameters)
    	{
    		if (OnExecuteFunction != null) OnExecuteFunction(functionName, parameters);
    		return Enumerable.Empty<T>();
    	}
    	
    	public virtual int ExecuteFunction(string functionName, params object[] parameters)
    	{
    		if (OnExecuteFunction != null) OnExecuteFunction(functionName, parameters);
    		return 0;
    	}
    	
    	public Action<string, object[]> OnExecuteFunction;
    }
}


