///////////////////////////////////////////////////////////
//  Exit.cs
//  Implementation of the Class Exit
//  Generated by Enterprise Architect
//  Created on:      28-Apr-2014 10:13:37 PM
//  Original author: Gsimmons
///////////////////////////////////////////////////////////

using System;

namespace Mazegame.Entity {
	public class Exit
	{
	    private String description;
	    private Mazegame.Entity.Location destination;

		public Exit(String description, Location destination)
		{
		    Description = description;
		    Destination = destination;
		}


	    public string Description
	    {
	        get { return description; }
	        set { description = value; }
	    }

	    public Location Destination
	    {
	        get { return destination; }
	        set { destination = value; }
	    }
	}//end Exit

}//end namespace Entity