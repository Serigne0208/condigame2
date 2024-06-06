using System;
using System.Collections.Generic;
using System.Text;

namespace CodinGame.En_Cours
{
    class _65_Node
    {
        public _65_Node left, right;

        public int value;

		public _65_Node Find(int n)
		{
			var r = this;
			
			while (r.value!=n)
			{
				if (r == null) break;
				if (r.value < n) r = r.right;
				else r = r.left;
			}

			return r;
		}
    }
}
