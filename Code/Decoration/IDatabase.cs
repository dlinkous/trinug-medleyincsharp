using System;

namespace Decoration
{
	internal interface IDatabase
	{
		int GetTotal();
		string GetName(int id);
	}
}
