using System;
using System.Collections.Generic;
namespace Visualization { 
	public class Room
	{
	
		private LinkedList<controller> roomItems;
		private int count = 0;
	

		public Room(string itemRoom, string address)
		{
			roomItems = new LinkedList<controller>();
			addItem(itemRoom, address);
			count++;
		}

		public Boolean CompareRoom(string id)
		{
			string[] addarray = id.Split('/');
			string[] comparearray = this.roomItems.First.Value.getAddress().Split('/');

			Boolean addBool = addarray[1].Equals(comparearray[1]);
			return  addBool;
		}

		public string searchroom(string id)
        {
			LinkedListNode<controller> temp = this.roomItems.First;

			while (temp != null)
            {
                if (id.Equals(temp.Value.getAddress())) 
				{
					return temp.Value.getDpt();
				}
				temp = temp.Next;
			}
			return null;
			
		}

		public void addItem(string value, string address)
		{
				controller items = new controller(value, address);
				roomItems.AddLast(items);
				count++;
		}

	
		public int getCount()
		{
			return count;
		}

		public LinkedList<controller> getControl()
		{
				return roomItems;
		}
	
	}

}