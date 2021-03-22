using System;
using System.Collections.Generic;

public class Room
{
	private LinkedList<string> roomItems;
	private LinkedList<string> address;
	private int count = 0;
	
	public Room(string itemRoom, string address)
    {
		roomItems = new LinkedList<string>();
		this.address = new LinkedList<string>();
		addItem(itemRoom, address);
		count++;
    }

	public Boolean CompareRoom(string id)
	{
		string[] addarray = id.Split('/');
		string[] comparearray = this.address.First.Value.Split('/');
		Boolean addBool = addarray[1].Equals(comparearray[1]);
		return  addBool;
    }

	public void addItem(string value, string address)
    {
		roomItems.AddLast(value);
		this.address.AddLast(address);
		count++;
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
