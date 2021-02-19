﻿using System;
using System.Collections.Generic;

public class Room
{
	private string room;
	private LinkedList<string> roomItems;
	private LinkedList<string> address;
	private int count = 0;
	
	public Room(string room ,string itemRoom, string address)
    {
		roomItems = new LinkedList<string>();
		this.address = new LinkedList<string>();
		this.room = room;
		addItem(itemRoom, address);
		count++;
    }

	public Boolean CompareRoom(string rum, string id)
	{
		Boolean roomBool = rum.Equals(room);
		string[] addarray = id.Split('/');
		string[] comparearray = this.address.First.Value.Split('/');
		Boolean addBool = addarray[0].Equals(comparearray[0]);
		return roomBool && addBool;


    }

	public void addItem(string value, string address)
    {
		roomItems.AddLast(value);
		this.address.AddLast(address);
		count++;
    }

	public string getRoom()
    {
		return room;
    }
	public int getCount()
    {
		return count;
    }

	public LinkedList<string> getAddress()
    {
		return address;
    }
	public LinkedList<string> getRoomItem()
    {
		return roomItems;
    }
}