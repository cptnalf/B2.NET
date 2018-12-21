using System;

namespace B2Net
{
	public class B2Exception : Exception
	{
		public string status { get; set; }
		public string code { get; set; }
		public bool reply {get;set; }
		public B2Exception(string cd, string sts, string msg, bool reply) : base(msg) { status=sts; code=cd; reply=reply; }
	}
}
